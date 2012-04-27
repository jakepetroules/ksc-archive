/// <summary>
/// Represents a patient in a medical complex.
/// </summary>
public class ClinicPatient
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClinicPatient"/> class.
    /// </summary>
    /// <param name="id">The patient's ID number.</param>
    /// <param name="name">The patient's name.</param>
    /// <param name="telephoneNumber">The patient's telephone number.</param>
    public ClinicPatient(int id, string name, int telephoneNumber)
    {
        this.ID = id;
        this.Name = name;
        this.TelephoneNumber = telephoneNumber;
    }

    /// <summary>
    /// Gets or sets the patient's ID number.
    /// </summary>
    public int ID
    {
        get;
        set;
    }

    /// <summary>
    /// Gets or sets the patient's name.
    /// </summary>
    public string Name
    {
        get;
        set;
    }

    /// <summary>
    /// Gets or sets the patient's telephone number.
    /// </summary>
    public int TelephoneNumber
    {
        get;
        set;
    }
}