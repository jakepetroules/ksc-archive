package dsass09b_petroulesj;

/**
 * Represents an alumni, or graduated student.
 * @author Jake Petroules
 */
public class Alumni extends Student
{
    private String employer;
    private String jobTitle;

    public Alumni(int id)
    {
        super(id);
    }

    /**
     * @return the employer
     */
    public String getEmployer()
    {
        return employer;
    }

    /**
     * @param employer the employer to set
     */
    public void setEmployer(String employer)
    {
        this.employer = employer;
    }

    /**
     * @return the jobTitle
     */
    public String getJobTitle()
    {
        return jobTitle;
    }

    /**
     * @param jobTitle the jobTitle to set
     */
    public void setJobTitle(String jobTitle)
    {
        this.jobTitle = jobTitle;
    }

    @Override
    public String toString()
    {
        return super.toString() + " and works for " + this.employer + " as a " + this.jobTitle;
    }
}
