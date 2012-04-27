package dsass09b_petroulesj;

import dslib_petroulesj.InputHelper;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Collection;
import java.util.HashMap;

/**
 *
 * @author Jake Petroules
 */
public class Main
{
    private static BufferedReader reader;

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) throws IOException
    {
        reader = new BufferedReader(new InputStreamReader(System.in));

        // Note that java.util.Hashtable is deprecated thus I am using its
        // replacement, HashMap, instead
        HashMap<Integer, Student> studentTree = new HashMap<Integer, Student>();
        HashMap<Integer, Alumni> alumniTree = new HashMap<Integer, Alumni>();
        HashMap<Integer, Employee> employeeTree = new HashMap<Integer, Employee>();
        int hashTable = -1;

        System.out.println("Available commands:");
        System.out.println("r - Check the working hash table");
        System.out.println("w - Switch the working hash table");
        System.out.println("---");
        System.out.println("a - Add a person to the working hash table");
        System.out.println("d - Remove a person from the working hash table");
        System.out.println("m - Modify a person's info in the working hash table");
        System.out.println("s - Search for a person in the working hash table");
        System.out.println("l - List the people in the working hash table in order by ID");
        System.out.println("c - Clear the working hash table");
        System.out.println("q - Quit the program");

        BufferedReader scanner = new BufferedReader(new InputStreamReader(System.in));
        String input;
        do
        {
            System.out.println("What do you want to do? ");
            input = scanner.readLine();

            if (input.equals("r"))
            {
                switch (hashTable)
                {
                    case 0:
                        System.out.println("Currently working with the STUDENTS hash table.");
                        break;
                    case 1:
                        System.out.println("Currently working with the ALUMNI hash table.");
                        break;
                    case 2:
                        System.out.println("Currently working with the EMPLOYEE hash table.");
                        break;
                    default:
                        printSelectHashTableMessage();
                        break;
                }
            }
            else if (input.equals("w"))
            {
                System.out.println("0: Students hash table");
                System.out.println("1: Alumni hash table");
                System.out.println("2: Employee hash table");
                hashTable = InputHelper.getIntegerInRange(reader, "Select a hash table to work with: ", 0, 2);
            }
            else if (input.equals("a"))
            {
                switch (hashTable)
                {
                    case 0:
                        Student student = enterStudentRecord();
                        studentTree.put(student.getId(), student);
                        break;
                    case 1:
                        Alumni alumni = enterAlumniRecord();
                        alumniTree.put(alumni.getId(), alumni);
                        break;
                    case 2:
                        Employee employee = enterEmployeeRecord();
                        employeeTree.put(employee.getId(), employee);
                        break;
                    default:
                        printSelectHashTableMessage();
                        break;
                }
            }
            else if (input.equals("d"))
            {
                int id = InputHelper.getInteger(reader, "Please enter the ID of the person to remove: ", "Please enter a valid integer.");
                switch (hashTable)
                {
                    case 0:
                        studentTree.remove(id);
                        break;
                    case 1:
                        alumniTree.remove(id);
                        break;
                    case 2:
                        employeeTree.remove(id);
                        break;
                    default:
                        printSelectHashTableMessage();
                        break;
                }
            }
            else if (input.equals("m"))
            {
                int id = InputHelper.getInteger(reader, "Please enter the ID of the person to modify: ", "Please enter a valid integer.");
                switch (hashTable)
                {
                    case 0:
                        studentTree.remove(id);
                        studentTree.put(id, enterStudentRecord(id));
                        break;
                    case 1:
                        alumniTree.remove(id);
                        alumniTree.put(id, enterAlumniRecord(id));
                        break;
                    case 2:
                        employeeTree.remove(id);
                        employeeTree.put(id, enterEmployeeRecord(id));
                        break;
                    default:
                        printSelectHashTableMessage();
                        break;
                }
            }
            else if (input.equals("s"))
            {
                int id = InputHelper.getInteger(reader, "Please enter the ID of the person to search for: ", "Please enter a valid integer.");
                switch (hashTable)
                {
                    case 0:
                        Student student = studentTree.get(id);
                        if (student != null)
                        {
                            System.out.println(student);
                        }
                        else
                        {
                            System.out.println("Student not found.");
                        }

                        break;
                    case 1:
                        Alumni alumni = alumniTree.get(id);
                        if (alumni != null)
                        {
                            System.out.println(alumni);
                        }
                        else
                        {
                            System.out.println("Alumni not found.");
                        }

                        break;
                    case 2:
                        Employee employee = employeeTree.get(id);
                        if (employee != null)
                        {
                            System.out.println(employee);
                        }
                        else
                        {
                            System.out.println("Employee not found.");
                        }

                        break;
                    default:
                        printSelectHashTableMessage();
                        break;
                }
            }
            else if (input.equals("l"))
            {
                switch (hashTable)
                {
                    case 0:
                        Collection<Student> students = studentTree.values();
                        for (Student s : students)
                        {
                            System.out.println(s);
                        }

                        break;
                    case 1:
                        Collection<Alumni> alumni = alumniTree.values();
                        for (Alumni a : alumni)
                        {
                            System.out.println(a);
                        }

                        break;
                    case 2:
                        Collection<Employee> employees = employeeTree.values();
                        for (Employee e : employees)
                        {
                            System.out.println(e);
                        }

                        break;
                    default:
                        printSelectHashTableMessage();
                        break;
                }
            }
            else if (input.equals("c"))
            {
                switch (hashTable)
                {
                    case 0:
                        studentTree.clear();
                        break;
                    case 1:
                        alumniTree.clear();
                        break;
                    case 2:
                        employeeTree.clear();
                        break;
                    default:
                        printSelectHashTableMessage();
                        break;
                }
            }
        }
        while (!input.equals("q"));
    }

    public static Student enterStudentRecord() throws IOException
    {
        return enterStudentRecord(getPersonId());
    }

    public static Student enterStudentRecord(int id) throws IOException
    {
        Student student = new Student(id);
        enterPersonRecord(student);

        student.setMajor(InputHelper.getString(reader, "Enter the student's major: "));
        return student;
    }

    public static Alumni enterAlumniRecord() throws IOException
    {
        return enterAlumniRecord(getPersonId());
    }

    public static Alumni enterAlumniRecord(int id) throws IOException
    {
        Alumni alumni = new Alumni(id);
        enterPersonRecord(alumni);

        alumni.setEmployer(InputHelper.getString(reader, "Enter the alumni's employer: "));
        alumni.setJobTitle(InputHelper.getString(reader, "Enter the alumni's job title: "));
        return alumni;
    }

    public static Employee enterEmployeeRecord() throws IOException
    {
        return enterEmployeeRecord(getPersonId());
    }

    public static Employee enterEmployeeRecord(int id) throws IOException
    {
        Employee employee = new Employee(id);
        enterPersonRecord(employee);

        employee.setDepartment(InputHelper.getString(reader, "Enter the employee's department: "));
        employee.setAreaOfSpecialization(InputHelper.getString(reader, "Enter the employee's area of specialization: "));
        employee.setEmployer(InputHelper.getString(reader, "Enter the employee's employer: "));
        employee.setJobTitle(InputHelper.getString(reader, "Enter the employee's job title: "));
        return employee;
    }

    public static void enterPersonRecord(Person person) throws IOException
    {
        person.setFirstName(InputHelper.getString(reader, "Enter the person's first name: "));
        person.setLastName(InputHelper.getString(reader, "Enter the person's last name: "));
        person.setBirthDate(InputHelper.getDate(reader, "Enter the person's birth date: "));
        person.setGender(InputHelper.getBoolean(reader, "Enter the person's gender: ", "male", "female") ? Gender.Male : Gender.Female);
        person.setTelephoneNumber(InputHelper.getInteger(reader, "Enter the person's telephone number: ", "Please enter a valid telephone number."));
    }

    public static int getPersonId() throws IOException
    {
        return InputHelper.getInteger(reader,
                "Enter the person's ID number: ", "Please enter a valid integer.");
    }

    static void printSelectHashTableMessage()
    {
        System.out.println("Not currently working with any hash table. Use the 'w' command to select one.");
    }
}
