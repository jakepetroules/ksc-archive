package dsass05a_petroulesj;

import dslib_petroulesj.InputHelper;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;

/**
 *
 * @author Jake Petroules
 */
public class ClinicMonitor
{
    private ArrayList<DoctorQueue> doctors = new ArrayList<DoctorQueue>();

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws IOException
    {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        ClinicMonitor clinic = new ClinicMonitor();

        System.out.println("> Welcome to Clinic Monitor.");
        System.out.println("> Available commands:");
        System.out.println("> check-queue - Check the status of the queue for a specified doctor");
        System.out.println("> set-queue - Open or close the queue for a specified doctor");
        System.out.println("> check-in - Check in a patient to the clinic");
        System.out.println("> check-out - Check a patient out of the clinic");
        System.out.println("> list-doctors - Lists the doctors employed at this clinic");
        System.out.println("> list-queue - List the queue for a specified doctor");
        System.out.println("> check-for-patient - Checks for the presence of a patient in a particular doctor's queue");
        System.out.println("> switch-phys - Switch a patient to a different physician");
        System.out.println("> exit - Exit the application");
        String option = "";
        do
        {
            System.out.print("> Enter a command to run: ");

            option = reader.readLine();
            if (option.equalsIgnoreCase("check-queue"))
            {
                clinic.checkQueueState(reader);
            }
            else if (option.equalsIgnoreCase("set-queue"))
            {
                clinic.setQueueState(reader);
            }
            else if (option.equalsIgnoreCase("check-in"))
            {
                clinic.patientCheckIn(reader);
            }
            else if (option.equalsIgnoreCase("check-out"))
            {
                clinic.patientCheckOut(reader);
            }
            else if (option.equalsIgnoreCase("list-doctors"))
            {
                clinic.listDoctors();
            }
            else if (option.equalsIgnoreCase("list-queue"))
            {
                clinic.listQueueContents(reader);
            }
            else if (option.equalsIgnoreCase("check-for-patient"))
            {
                clinic.checkForPatient(reader);
            }
            else if (option.equalsIgnoreCase("switch-phys"))
            {
                clinic.switchPatientPhysician(reader);
            }
        }
        while (!option.equals("") && !option.equalsIgnoreCase("exit"));
    }
    
    public ClinicMonitor()
    {
        this.doctors.add(new DoctorQueue("Who"));
        this.doctors.add(new DoctorQueue("Bruce Jones"));
        this.doctors.add(new DoctorQueue("Lambert Cox"));
        this.doctors.add(new DoctorQueue("Karen Jones"));
        this.doctors.add(new DoctorQueue("Elvis Foster"));
        this.doctors.add(new DoctorQueue("Santa Claus"));
    }

    public void checkQueueState(BufferedReader reader) throws IOException
    {
        String doctorName = InputHelper.getString(reader, "Enter the name of the doctor to check the queue for: ", "Please enter a name.");

        DoctorQueue doctor = this.findDoctor(doctorName);
        if (doctor != null)
        {
            System.out.println("Dr. " + doctor.getName() + " is " + (doctor.isAvailable() ? "" : "not") + " available.");
        }
        else
        {
            this.noDoctor(doctorName);
        }
    }

    public void setQueueState(BufferedReader reader) throws IOException
    {
        String doctorName = InputHelper.getString(reader, "Enter the name of the doctor to set the queue for: ", "Please enter a name.");

        DoctorQueue doctor = this.findDoctor(doctorName);
        if (doctor != null)
        {
            doctor.setAvailable(InputHelper.getBoolean(reader, "Do you want to open or close the queue? ", "open", "close"));
        }
        else
        {
            this.noDoctor(doctorName);
        }
    }

    public void patientCheckIn(BufferedReader reader) throws IOException
    {
        int id = InputHelper.getInteger(reader, "Enter the patient's ID number: ", "Please enter a valid ID number.");
        String name = InputHelper.getString(reader, "Enter the patient's name: ", "Please enter a name.");
        int telephoneNumber = InputHelper.getInteger(reader, "Enter the patient's telephone number: ", "Please enter a valid telephone number.");
        String doctorName = InputHelper.getString(reader, "Enter the name of the doctor the patient wishes to see: ", "Please enter a name.");

        ClinicPatient patient = new ClinicPatient(id, name, telephoneNumber);
        DoctorQueue doctor = this.findDoctor(doctorName);
        if (doctor != null)
        {
            if (doctor.isAvailable())
            {
                doctor.add(patient);
            }
            else
            {
                System.out.println("Dr." + doctor.getName() + " is not available right now. " +
                        "The patient must try another doctor or cancel their appointment.");
            }
        }
        else
        {
            this.noDoctor(doctorName);
        }
    }

    public void patientCheckOut(BufferedReader reader) throws IOException
    {
        String patientName = InputHelper.getString(reader, "Enter the patient's name: ", "Please enter a name.");
        ClinicPatient patient = this.findPatient(patientName);
        DoctorQueue doctor = this.findPatientDoctor(patient);
        if (patient != null)
        {
            doctor.remove(patient);
        }
        else
        {
            this.noPatient(patientName);
        }
    }

    public void listDoctors()
    {
        System.out.println("There are " + this.doctors.size() + " doctors employed at this clinic.");
        for (DoctorQueue doctor : this.doctors)
        {
            System.out.println(doctor.getName());
        }
    }

    public void listQueueContents(BufferedReader reader) throws IOException
    {
        String doctorName = InputHelper.getString(reader, "Enter the name of the physician to list the queue of: ", "Please enter a name.");
        DoctorQueue doctor = this.findDoctor(doctorName);
        if (doctor != null)
        {
            Object[] patients = doctor.toArray();

            System.out.println("There are " + (patients.length > 0 ? patients.length : "no") + " patients in Dr. " + doctorName + "'s queue.");

            for (int i = 0; i < patients.length; i++)
            {
                System.out.println(((ClinicPatient)patients[i]).getName());
            }
        }
        else
        {
            this.noDoctor(doctorName);
        }
    }

    public void checkForPatient(BufferedReader reader) throws IOException
    {
        String doctorName = InputHelper.getString(reader, "Enter the name of the physician to check the queue of: ", "Please enter a name.");
        String patientName = InputHelper.getString(reader, "Enter the name of the patient to find in the queue: ", "Please enter a name.");
        ClinicPatient patient = this.findPatient(patientName);
        DoctorQueue realDoctor = this.findPatientDoctor(patient);
        DoctorQueue proposedDoctor = this.findDoctor(doctorName);
        if (proposedDoctor != null)
        {
            if (patient != null)
            {
                System.out.println(patientName + " is " + (realDoctor == proposedDoctor ? "" : "not") + " in Dr. " + doctorName + "'s queue.");
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

    public void switchPatientPhysician(BufferedReader reader) throws IOException
    {
        String patientName = InputHelper.getString(reader, "Enter the name of the patient to switch the physician of: ", "Please enter a name.");
        ClinicPatient patient = this.findPatient(patientName);
        DoctorQueue currentDoctor = this.findPatientDoctor(patient);
        if (patient != null)
        {
            String newDoctorName = InputHelper.getString(reader, "Enter the name of the physician to switch the patient to: ", "Please enter a name.");
            DoctorQueue newDoctor = this.findDoctor(newDoctorName);
            if (newDoctor != null)
            {
                currentDoctor.remove(patient);
                newDoctor.add(patient);
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

    /**
     * Returns the queue for the doctor with the specified name.
     * @param name The name of the doctor whose queue to find.
     */
    public DoctorQueue findDoctor(String name)
    {
        for (DoctorQueue doctor : this.doctors)
        {
            if (doctor.getName().equalsIgnoreCase(name))
            {
                return doctor;
            }
        }

        return null;
    }

    /**
     * Finds a patient's doctor.
     * @param patient The patient to find the doctor of.
     */
    public DoctorQueue findPatientDoctor(ClinicPatient patient)
    {
        for (DoctorQueue doctor : this.doctors)
        {
            if (doctor.contains(patient))
            {
                return doctor;
            }
        }

        return null;
    }

    /**
     * Finds a patient by their name.
     * @param name The name of the patient to find.
     */
    public ClinicPatient findPatient(String name)
    {
        for (DoctorQueue doctor : this.doctors)
        {
            Object[] patients = doctor.toArray();
            for (int i = 0; i < patients.length; i++)
            {
                ClinicPatient patient = (ClinicPatient)patients[i];
                if (patient.getName().equalsIgnoreCase(name))
                {
                    return patient;
                }
            }
        }

        return null;
    }

    private void noPatient(String patientName)
    {
        System.out.println("No patient by the name " + patientName + " has checked in to this clinic.");
    }

    private void noDoctor(String doctorName)
    {
        System.out.println("No doctor by the name " + doctorName + " is employed at this clinic.");
    }
}
