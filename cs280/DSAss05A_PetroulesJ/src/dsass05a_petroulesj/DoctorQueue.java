package dsass05a_petroulesj;

import dslib_petroulesj.Queue;

/**
 *
 * @author Jake Petroules
 */
public class DoctorQueue extends Queue<ClinicPatient>
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
