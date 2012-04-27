using System.Collections.Generic;
using System.Linq;

public class DoctorQueue : Queue<ClinicPatient>
{
    public DoctorQueue(string name)
    {
        this.Name = name;
    }

    public string Name
    {
        get;
        set;
    }

    public bool IsAvailable
    {
        get;
        set;
    }

    public void Remove(ClinicPatient patient)
    {
        List<ClinicPatient> list = this.ToList();
        this.Clear();
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] != patient)
            {
                this.Enqueue(list[i]);
            }
        }
    }
}