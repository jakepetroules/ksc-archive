package dsass07b_petroulesj;

import java.text.SimpleDateFormat;
import java.util.Date;

/**
 * Represents a person.
 * @author Jake Petroules
 */
public abstract class Person implements Comparable<Person>
{
    private final int id;
    private String firstName;
    private String lastName;
    private Date birthDate;
    private Gender gender;
    private int telephoneNumber;

    public Person(int id)
    {
        this.id = id;
    }

    public int getId()
    {
        return this.id;
    }

    public String getFirstName()
    {
        return this.firstName;
    }

    public void setFirstName(String firstName)
    {
        this.firstName = firstName;
    }

    public String getLastName()
    {
        return this.lastName;
    }

    public void setLastName(String lastName)
    {
        this.lastName = lastName;
    }

    public Date getBirthDate()
    {
        return this.birthDate;
    }

    public void setBirthDate(Date birthDate)
    {
        this.birthDate = birthDate;
    }

    public Gender getGender()
    {
        return this.gender;
    }

    public void setGender(Gender gender)
    {
        this.gender = gender;
    }

    public int getTelephoneNumber()
    {
        return this.telephoneNumber;
    }

    public void setTelephoneNumber(int telephoneNumber)
    {
        this.telephoneNumber = telephoneNumber;
    }

    public int compareTo(Person person)
    {
        if (this.id < person.id)
        {
            return -1;
        }
        else if (this.id > person.id)
        {
            return 1;
        }

        return 0;
    }

    @Override
    public String toString()
    {
        SimpleDateFormat sf = new SimpleDateFormat("yyyy-MM-dd");
        return this.id + ": " + this.lastName + ", " + this.firstName + ", born " +
                (this.birthDate != null ? sf.format(this.birthDate) : "unknown") + " is a " + this.gender + " and has the telephone number " +
                this.telephoneNumber;
    }
}
