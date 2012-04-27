#include "database.h"
#include <QtCore>
#include "user.h"
#include "group.h"
#include "resource.h"
#include "permissionset.h"
#include <QtXml>

class Database::Private
{
public:
    QList<User*> userList;
    QList<Group*> groupList;
    QList<Resource*> resourceList;
};

Database::Database(QObject *parent) :
    QObject(parent)
{
    d = new Private();
}

Database::~Database()
{
    delete d;
}

void Database::load(const QString &fileName)
{
    QFile db(fileName);
    if (db.open(QIODevice::ReadOnly))
    {
        QDomDocument document;
        if (document.setContent(&db))
        {
            // users, groups, resources lists
            QDomNodeList mainCollections = document.documentElement().childNodes();

            for (int i = 0; i < mainCollections.size(); i++)
            {
                QDomElement collection = mainCollections.at(i).toElement();
                if (collection.tagName() == "users")
                {
                    for (int j = 0; j < collection.childNodes().size(); j++)
                    {
                        QDomElement userNode = collection.childNodes().at(j).toElement();
                        User *user = new User();
                        user->setCode(userNode.attribute("id"));
                        user->setUserName(userNode.attribute("name"));
                        user->setPassword(userNode.attribute("password"));
                        user->setLastPasswordChange(QDateTime::fromString(userNode.attribute("last"), Qt::ISODate));
                        user->setPasswordChangeCeiling(userNode.attribute("ceiling").toInt());
                        d->userList.append(user);
                    }
                }
                else if (collection.tagName() == "groups")
                {
                    for (int j = 0; j < collection.childNodes().size(); j++)
                    {
                        QDomElement groupNode = collection.childNodes().at(j).toElement();
                        Group *group = new Group();
                        group->setCode(groupNode.attribute("id"));
                        group->setGroupName(groupNode.attribute("name"));
                        d->groupList.append(group);

                        QDomElement groupUsersNode = groupNode.firstChildElement();
                        for (int k = 0; k < groupUsersNode.childNodes().size(); k++)
                        {
                            QDomElement groupUser = groupUsersNode.childNodes().at(k).toElement();
                            group->addUser(getUser(groupUser.attribute("id")));
                        }
                    }
                }
                else if (collection.tagName() == "resources")
                {
                    for (int j = 0; j < collection.childNodes().size(); j++)
                    {
                        QDomElement resourceNode = collection.childNodes().at(j).toElement();
                        Resource *res = new Resource();
                        res->setCode(resourceNode.attribute("id"));
                        res->setResourceName(resourceNode.attribute("name"));
                        res->setOwner(resourceNode.attribute("owner"));
                        res->setGroup(resourceNode.attribute("group"));
                        res->permissions()->setFromString(resourceNode.attribute("permissions"));
                        d->resourceList.append(res);
                    }
                }
            }
        }
        else
        {
            qDebug() << "its me mario";
        }

        db.close();

        return;
    }

    User *root = new User();
    root->setUserName("root");
    root->setPassword("root");
    d->userList.append(root);

    Group *rootGroup = new Group();
    rootGroup->setGroupName("root");
    d->groupList.append(rootGroup);

    Group *staffGroup = new Group();
    staffGroup->setGroupName("staff");
    d->groupList.append(staffGroup);

    rootGroup->addUser(root);
}

void Database::save(const QString &fileName)
{
    QFile db(fileName);
    if (db.open(QIODevice::WriteOnly))
    {
        QDomDocument document;

        QDomElement root = document.createElement("security-simulator-db");
        document.appendChild(root);

        QDomElement users = document.createElement("users");
        root.appendChild(users);
        foreach (User *u, allUsers())
        {
            QDomElement user = document.createElement("user");
            user.setAttribute("id", u->code());
            user.setAttribute("name", u->userName());
            user.setAttribute("password", u->password());
            user.setAttribute("last", u->lastPasswordChange().toUTC().toString(Qt::ISODate));
            user.setAttribute("ceiling", u->passwordChangeCeiling());
            users.appendChild(user);
        }

        QDomElement groups = document.createElement("groups");
        root.appendChild(groups);
        foreach (Group *g, allGroups())
        {
            QDomElement group = document.createElement("group");
            group.setAttribute("id", g->code());
            group.setAttribute("name", g->groupName());
            groups.appendChild(group);

            QDomElement groupUsers = document.createElement("users");
            group.appendChild(groupUsers);

            foreach (User *u, g->users())
            {
                QDomElement user = document.createElement("user");
                user.setAttribute("id", u->userName());
                groupUsers.appendChild(user);
            }
        }

        QDomElement resources = document.createElement("resources");
        root.appendChild(resources);
        foreach (Resource *r, allResources())
        {
            QDomElement resource = document.createElement("resource");
            resource.setAttribute("id", r->code());
            resource.setAttribute("name", r->resourceName());
            resource.setAttribute("owner", r->owner(*this)->userName());
            resource.setAttribute("group", r->group(*this)->groupName());
            resource.setAttribute("permissions", r->permissions()->toString());
            resources.appendChild(resource);
        }

        db.write(document.toString(4).toUtf8());

        db.close();
    }
}

void Database::addObject(User *user)
{
    d->userList.append(user);
}

void Database::addObject(Group *group)
{
    d->groupList.append(group);
}

void Database::addObject(Resource *resource)
{
    d->resourceList.append(resource);
}

void Database::removeObject(User *user)
{
    d->userList.removeOne(user);
}

void Database::removeObject(Group *group)
{
    d->groupList.removeOne(group);
}

void Database::removeObject(Resource *resource)
{
    d->resourceList.removeOne(resource);
}

const QList<User*> Database::allUsers() const
{
    return d->userList;
}

User *Database::getUser(const QString &userName) const
{
    foreach (User *user, d->userList)
    {
        if (user && user->userName() == userName)
        {
            return user;
        }
    }

    return NULL;
}

const QList<Group*> Database::allGroups() const
{
    return d->groupList;
}

Group *Database::getGroup(const QString &groupName) const
{
    foreach (Group *group, d->groupList)
    {
        if (group && group->groupName() == groupName)
        {
            return group;
        }
    }

    return NULL;
}

const QList<Resource*> Database::allResources() const
{
    return d->resourceList;
}

Resource *Database::getResource(const QString &resourceName) const
{
    foreach (Resource *resource, d->resourceList)
    {
        if (resource && resource->resourceName() == resourceName)
        {
            return resource;
        }
    }

    return NULL;
}
