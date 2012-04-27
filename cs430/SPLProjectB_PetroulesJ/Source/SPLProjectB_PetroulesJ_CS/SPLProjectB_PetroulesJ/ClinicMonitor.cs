using System;
using System.Collections.Generic;
using System.Linq;

public class ClinicMonitor
{
    private List<DoctorQueue> doctors = new List<DoctorQueue>();

    public static void Main(string[] args)
    {
        ClinicMonitor clinic = new ClinicMonitor();

        Console.WriteLine("> Welcome to Clinic Monitor.");
        Console.WriteLine("> Available commands:");
        Console.WriteLine("> check-queue - Check the status of the queue for a specified doctor");
        Console.WriteLine("> set-queue - Open or close the queue for a specified doctor");
        Console.WriteLine("> check-in - Check in a patient to the clinic");
        Console.WriteLine("> check-out - Check a patient out of the clinic");
        Console.WriteLine("> list-doctors - Lists the doctors employed at this clinic");
        Console.WriteLine("> list-queue - List the queue for a specified doctor");
        Console.WriteLine("> check-for-patient - Checks for the presence of a patient in a particular doctor's queue");
        Console.WriteLine("> switch-phys - Switch a patient to a different physician");
        Console.WriteLine("> reassign - Move all patients from one doctor to another");
        Console.WriteLine("> exit - Exit the application");
        String option = "";
        do
        {
            Console.Write("> Enter a command to run: ");

            option = Console.ReadLine();
            if (string.Equals(option, "check-queue", StringComparison.OrdinalIgnoreCase))
            {
                clinic.checkQueueState();
            }
            else if (string.Equals(option, "set-queue", StringComparison.OrdinalIgnoreCase))
            {
                clinic.setQueueState();
            }
            else if (string.Equals(option, "check-in", StringComparison.OrdinalIgnoreCase))
            {
                clinic.patientCheckIn();
            }
            else if (string.Equals(option, "check-out", StringComparison.OrdinalIgnoreCase))
            {
                clinic.patientCheckOut();
            }
            else if (string.Equals(option, "list-doctors", StringComparison.OrdinalIgnoreCase))
            {
                clinic.listDoctors();
            }
            else if (string.Equals(option, "list-queue", StringComparison.OrdinalIgnoreCase))
            {
                clinic.listQueueContents();
            }
            else if (string.Equals(option, "check-for-patient", StringComparison.OrdinalIgnoreCase))
            {
                clinic.checkForPatient();
            }
            else if (string.Equals(option, "switch-phys", StringComparison.OrdinalIgnoreCase))
            {
                clinic.switchPatientPhysician();
            }
            else if (string.Equals(option, "reassign", StringComparison.OrdinalIgnoreCase))
            {
                clinic.reassign();
            }
        }
        while (!string.IsNullOrWhiteSpace(option) && !string.Equals(option, "exit", StringComparison.OrdinalIgnoreCase));

        // Remove all the patients from all the doctors upon exit
        foreach (DoctorQueue doctor in clinic.doctors)
        {
            while (doctor.Count != 0)
            {
                doctor.Dequeue();
            }
        }
    }

    public ClinicMonitor()
    {
        this.doctors.Add(new DoctorQueue("Who"));
        this.doctors.Add(new DoctorQueue("Bruce Jones"));
        this.doctors.Add(new DoctorQueue("Lambert Cox"));
        this.doctors.Add(new DoctorQueue("Karen Jones"));
        this.doctors.Add(new DoctorQueue("Elvis Foster"));
        this.doctors.Add(new DoctorQueue("Santa Claus"));
    }

    public void checkQueueState()
    {
        string doctorName = InputHelper.getString("Enter the name of the doctor to check the queue for: ", "Please enter a name.");

        DoctorQueue doctor = this.findDoctor(doctorName);
        if (doctor != null)
        {
            Console.WriteLine("Dr. " + doctor.Name + " is " + (doctor.IsAvailable ? "" : "not") + " available.");
        }
        else
        {
            this.noDoctor(doctorName);
        }
    }

    public void setQueueState()
    {
        string doctorName = InputHelper.getString("Enter the name of the doctor to set the queue for: ", "Please enter a name.");

        DoctorQueue doctor = this.findDoctor(doctorName);
        if (doctor != null)
        {
            doctor.IsAvailable = InputHelper.getBoolean("Do you want to open or close the queue? ", "open", "close");
        }
        else
        {
            this.noDoctor(doctorName);
        }
    }

    public void patientCheckIn()
    {
        int id = InputHelper.getInteger("Enter the patient's ID number: ", "Please enter a valid ID number.");
        string name = InputHelper.getString("Enter the patient's name: ", "Please enter a name.");
        int telephoneNumber = InputHelper.getInteger("Enter the patient's telephone number: ", "Please enter a valid telephone number.");
        string doctorName = InputHelper.getString("Enter the name of the doctor the patient wishes to see: ", "Please enter a name.");

        ClinicPatient patient = new ClinicPatient(id, name, telephoneNumber);
        DoctorQueue doctor = this.findDoctor(doctorName);
        if (doctor != null)
        {
            if (doctor.IsAvailable)
            {
                doctor.Enqueue(patient);
            }
            else
            {
                Console.WriteLine("Dr." + doctor.Name + " is not available right now. " +
                        "The patient must try another doctor or cancel their appointment.");
            }
        }
        else
        {
            this.noDoctor(doctorName);
        }
    }

    public void patientCheckOut()
    {
        string patientName = InputHelper.getString("Enter the patient's name: ", "Please enter a name.");
        ClinicPatient patient = this.findPatient(patientName);
        DoctorQueue doctor = this.findPatientDoctor(patient);
        if (patient != null)
        {
            doctor.Remove(patient);
        }
        else
        {
            this.noPatient(patientName);
        }
    }

    public void listDoctors()
    {
        Console.WriteLine("There are " + this.doctors.Count + " doctors employed at this clinic.");
        foreach (DoctorQueue doctor in this.doctors)
        {
            Console.WriteLine(doctor.Name);
        }
    }

    public void listQueueContents()
    {
        string doctorName = InputHelper.getString("Enter the name of the physician to list the queue of: ", "Please enter a name.");
        DoctorQueue doctor = this.findDoctor(doctorName);
        if (doctor != null)
        {
            Console.WriteLine("There are " + (doctor.Count > 0 ? doctor.Count.ToString() : "no") + " patients in Dr. " + doctorName + "'s queue.");

            foreach (var patient in doctor)
            {
                Console.WriteLine(patient.Name);
            }
        }
        else
        {
            this.noDoctor(doctorName);
        }
    }

    public void checkForPatient()
    {
        string doctorName = InputHelper.getString("Enter the name of the physician to check the queue of: ", "Please enter a name.");
        string patientName = InputHelper.getString("Enter the name of the patient to find in the queue: ", "Please enter a name.");
        ClinicPatient patient = this.findPatient(patientName);
        DoctorQueue realDoctor = this.findPatientDoctor(patient);
        DoctorQueue proposedDoctor = this.findDoctor(doctorName);
        if (proposedDoctor != null)
        {
            if (patient != null)
            {
                Console.WriteLine(patientName + " is " + (realDoctor == proposedDoctor ? "" : "not") + " in Dr. " + doctorName + "'s queue.");
            }
            else
            {
                this.noPatient(patientName);
            }
        }
        else
        {
            this.noDoctor(doctorName);
        }
    }

    public void switchPatientPhysician()
    {
        string patientName = InputHelper.getString("Enter the name of the patient to switch the physician of: ", "Please enter a name.");
        ClinicPatient patient = this.findPatient(patientName);
        DoctorQueue currentDoctor = this.findPatientDoctor(patient);
        if (patient != null)
        {
            String newDoctorName = InputHelper.getString("Enter the name of the physician to switch the patient to: ", "Please enter a name.");
            DoctorQueue newDoctor = this.findDoctor(newDoctorName);
            if (newDoctor != null)
            {
                currentDoctor.Dequeue(/*patient*/);
                newDoctor.Enqueue(patient);
            }
            else
            {
                this.noDoctor(newDoctorName);
            }
        }
        else
        {
            this.noPatient(patientName);
        }
    }

    public void reassign()
    {
        string doctorFromName = InputHelper.getString("Enter the name of the doctor to reassign the patients from: ");
        DoctorQueue doctorFrom = this.findDoctor(doctorFromName);
        if (doctorFrom != null)
        {
            string doctorToName = InputHelper.getString("Enter the name of the target doctor: ");
            DoctorQueue doctorTo = this.findDoctor(doctorToName);
            if (doctorTo != null)
            {
                if (doctorTo.IsAvailable)
                {
                    while (doctorFrom.Count() != 0)
                    {
                        doctorTo.Enqueue(doctorFrom.Dequeue());
                    }
                }
                else
                {
                    Console.WriteLine("Dr." + doctorTo.Name + " is not available right now.");
                }
            }
            else
            {
                this.noDoctor(doctorToName);
            }
        }
        else
        {
            this.noDoctor(doctorFromName);
        }
    }

    /// <summary>
    /// Returns the queue for the doctor with the specified name.
    /// </summary>
    /// <param name="name">The name of the doctor whose queue to find.</param>
    public DoctorQueue findDoctor(string name)
    {
        foreach (DoctorQueue doctor in this.doctors)
        {
            if (string.Equals(doctor.Name, name, StringComparison.OrdinalIgnoreCase))
            {
                return doctor;
            }
        }

        return null;
    }

    /// <summary>
    /// Finds a patient's doctor.
    /// </summary>
    /// <param name="patient">The patient to find the doctor of.</param>
    public DoctorQueue findPatientDoctor(ClinicPatient patient)
    {
        foreach (DoctorQueue doctor in this.doctors)
        {
            if (doctor.Contains(patient))
            {
                return doctor;
            }
        }

        return null;
    }

    /// <summary>
    /// Finds a patient by their name.
    /// </summary>
    /// <param name="name">The name of the patient to find.</param>
    public ClinicPatient findPatient(String name)
    {
        foreach (var doctor in this.doctors)
        {
            foreach (var patient in doctor)
            {
                if (string.Equals(patient.Name, name, StringComparison.OrdinalIgnoreCase))
                {
                    return patient;
                }
            }
        }

        return null;
    }

    private void noPatient(string patientName)
    {
        Console.WriteLine("No patient by the name " + patientName + " has checked in to this clinic.");
    }

    private void noDoctor(string doctorName)
    {
        Console.WriteLine("No doctor by the name " + doctorName + " is employed at this clinic.");
    }
}