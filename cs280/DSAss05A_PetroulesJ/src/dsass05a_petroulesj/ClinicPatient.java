package dsass05a_petroulesj;

/**
 * Represents a patient in a medical complex.
 * @author Jake Petroules
 */
public class ClinicPatient
{
    /**
     * The patient's ID number.
     */
    private int id;

    /**
     * The patient's name.
     */
    private String name;

    /**
     * The patient's telephone number.
     */
    private int telephoneNumber;

    /**
     * Initializes a new instance of the {@link ClinicPatient} class.
     * @param id The patient's ID number.
     * @param name The patient's name.
     * @param telephoneNumber The patient's telephone number.
     */
    public ClinicPatient(int id, String name, int telephoneNumber)
    {
        this.id = id;
        this.name = name;
        this.telephoneNumber = telephoneNumber;
    }

    /**
     * Gets the patient's ID number.
     */
    public int getId()
    {
        return this.id;
    }

    /**
     * Sets the patient's ID number.
     */
    public void setId(int id)
    {
        this.id = id;
    }

    /**
     * Gets the patient's name.
     */
    public String getName()
    {
        return this.name;
    }

    /**
     * Sets the patient's name.
     */
    public void setName(String name)
    {
        this.name = name;
    }

    /**
     * Gets the patient's telephone number.
     */
    public int getTelephoneNumber()
    {
        return this.telephoneNumber;
    }

    /**
     * Sets the patient's telephone number.
     */
    public void setTelephoneNumber(int telephoneNumber)
    {
        this.telephoneNumber = telephoneNumber;
    }
}
