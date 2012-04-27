#-----------------------------------------------------------
#
# Project created by NecessitasQtCreator 2012-04-19T07:38:57
#
#-----------------------------------------------------------

QT       += core xml

QT       -= gui

TARGET = SecuritySimulator
CONFIG   += console
CONFIG   -= app_bundle

TEMPLATE = app


SOURCES += main.cpp \
    user.cpp \
    group.cpp \
    resource.cpp \
    authenticator.cpp \
    securitysimulatorapplication.cpp \
    command.cpp \
    database.cpp \
    commands/touchcommand.cpp \
    commands/removecommand.cpp \
    commands/identitycommand.cpp \
    environment.cpp \
    commands/passwordchangecommand.cpp \
    commands/listresourcescommand.cpp \
    commands/removegroupcommand.cpp \
    commands/addgroupcommand.cpp \
    commands/listgroupscommand.cpp \
    permissionset.cpp \
    commands/addusercommand.cpp \
    commands/removeusercommand.cpp \
    commands/listuserscommand.cpp \
    commandregister.cpp \
    commands/chowncommand.cpp \
    commands/chmodcommand.cpp \
    commands/modgroupcommand.cpp

HEADERS += \
    user.h \
    group.h \
    resource.h \
    authenticator.h \
    securitysimulatorapplication.h \
    command.h \
    database.h \
    commands/touchcommand.h \
    commands/removecommand.h \
    commands/identitycommand.h \
    environment.h \
    commands/passwordchangecommand.h \
    commands/listresourcescommand.h \
    commands/removegroupcommand.h \
    commands/addgroupcommand.h \
    commands/listgroupscommand.h \
    permissionset.h \
    commands/addusercommand.h \
    commands/removeusercommand.h \
    commands/listuserscommand.h \
    commandregister.h \
    commands/chowncommand.h \
    commands/chmodcommand.h \
    commands/modgroupcommand.h
















































