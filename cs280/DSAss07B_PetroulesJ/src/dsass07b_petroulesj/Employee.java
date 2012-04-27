package dsass07b_petroulesj;

/**
 * Represents an employee.
 * @author Jake Petroules
 */
public class Employee extends Person
{
    private String department;
    private String areaOfSpecialization;
    private String employer;
    private String jobTitle;

    public Employee(int id)
    {
        super(id);
    }

    /**
     * @return the department
     */
    public String getDepartment()
    {
        return department;
    }

    /**
     * @param department the department to set
     */
    public void setDepartment(String department)
    {
        this.department = department;
    }

    /**
     * @return the areaOfSpecialization
     */
    public String getAreaOfSpecialization()
    {
        return areaOfSpecialization;
    }

    /**
     * @param areaOfSpecialization the areaOfSpecialization to set
     */
    public void setAreaOfSpecialization(String areaOfSpecialization)
    {
        this.areaOfSpecialization = areaOfSpecialization;
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
        return super.toString() + " and works for " + this.employer + " as a " + this.jobTitle +
                ", in the " + this.department + " department, specializing in " + this.areaOfSpecialization;
    }
}
