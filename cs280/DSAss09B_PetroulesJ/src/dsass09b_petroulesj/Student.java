package dsass09b_petroulesj;

/**
 * Represents a student.
 * @author Jake Petroules
 */
public class Student extends Person
{
    private String major;

    public Student(int id)
    {
        super(id);
    }

    /**
     * @return the major
     */
    public String getMajor()
    {
        return major;
    }

    /**
     * @param major the major to set
     */
    public void setMajor(String major)
    {
        this.major = major;
    }

    @Override
    public String toString()
    {
        return super.toString() + " and is a " + this.major + " major";
    }
}
