package splprojectb_petroulesj;

import java.util.LinkedList;

/**
 *
 * @author Jake Petroules
 */
public class DoctorQueue extends LinkedList<ClinicPatient>
{
    private String name;

    private boolean available;

    public DoctorQueue(String name)
    {
        this.name = name;
    }

    public String getName()
    {
        return this.name;
    }

    public void setName(String name)
    {
        this.name = name;
    }

    public boolean isAvailable()
    {
        return this.available;
    }

    public void setAvailable(boolean available)
    {
        this.available = available;
    }
}