package dsass07b_petroulesj;

import dslib_petroulesj.BinarySearchTree;
import dslib_petroulesj.ArrayList;
import dslib_petroulesj.InputHelper;
import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

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

        BinarySearchTree<Student> studentTree = new BinarySearchTree<Student>();
        BinarySearchTree<Alumni> alumniTree = new BinarySearchTree<Alumni>();
        BinarySearchTree<Employee> employeeTree = new BinarySearchTree<Employee>();
        int tree = -1;

        System.out.println("Available commands:");
        System.out.println("r - Check the working tree");
        System.out.println("w - Switch the working tree");
        System.out.println("---");
        System.out.println("a - Add a person to the working tree");
        System.out.println("d - Remove a person from the working tree");
        System.out.println("m - Modify a person's info in the working tree");
        System.out.println("s - Search for a person in the working tree");
        System.out.println("l - List the people in the working tree in order by ID");
        System.out.println("c - Clear the working tree");
        System.out.println("q - Quit the program");

        BufferedReader scanner = new BufferedReader(new InputStreamReader(System.in));
        String input;
        do
        {
            System.out.println("What do you want to do? ");
            input = scanner.readLine();

            if (input.equals("r"))
            {
                switch (tree)
                {
                    case 0:
                        System.out.println("Currently working with the STUDENTS tree.");
                        break;
                    case 1:
                        System.out.println("Currently working with the ALUMNI tree.");
                        break;
                    case 2:
                        System.out.println("Currently working with the EMPLOYEE tree.");
                        break;
                    default:
                        printSelectTreeMessage();
                        break;
                }
            }
            else if (input.equals("w"))
            {
                System.out.println("0: Students tree");
                System.out.println("1: Alumni tree");
                System.out.println("2: Employee tree");
                tree = InputHelper.getIntegerInRange(reader, "Select a tree to work with: ", 0, 2);
            }
            else if (input.equals("a"))
            {
                switch (tree)
                {
                    case 0:
                        studentTree.add(enterStudentRecord());
                        break;
                    case 1:
                        alumniTree.add(enterAlumniRecord());
                        break;
                    case 2:
                        employeeTree.add(enterEmployeeRecord());
                        break;
                    default:
                        printSelectTreeMessage();
                        break;
                }
            }
            else if (input.equals("d"))
            {
                int id = InputHelper.getInteger(reader, "Please enter the ID of the person to remove: ", "Please enter a valid integer.");
                switch (tree)
                {
                    case 0:
                        studentTree.remove(new Student(id));
                        break;
                    case 1:
                        alumniTree.remove(new Alumni(id));
                        break;
                    case 2:
                        employeeTree.remove(new Employee(id));
                        break;
                    default:
                        printSelectTreeMessage();
                        break;
                }
            }
            else if (input.equals("m"))
            {
                int id = InputHelper.getInteger(reader, "Please enter the ID of the person to modify: ", "Please enter a valid integer.");
                switch (tree)
                {
                    case 0:
                        studentTree.remove(new Student(id));
                        studentTree.add(enterStudentRecord(id));
                        break;
                    case 1:
                        alumniTree.remove(new Alumni(id));
                        alumniTree.add(enterAlumniRecord(id));
                        break;
                    case 2:
                        employeeTree.remove(new Employee(id));
                        employeeTree.add(enterEmployeeRecord(id));
                        break;
                    default:
                        printSelectTreeMessage();
                        break;
                }
            }
            else if (input.equals("s"))
            {
                int id = InputHelper.getInteger(reader, "Please enter the ID of the person to search for: ", "Please enter a valid integer.");
                switch (tree)
                {
                    case 0:
                        Student student = studentTree.get(new Student(id));
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
                        Alumni alumni = alumniTree.get(new Alumni(id));
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
                        Employee employee = employeeTree.get(new Employee(id));
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
                        printSelectTreeMessage();
                        break;
                }
            }
            else if (input.equals("l"))
            {
                switch (tree)
                {
                    case 0:
                        ArrayList<Student> students = studentTree.inorder();
                        for (Student s : students)
                        {
                            System.out.println(s);
                        }

                        break;
                    case 1:
                        ArrayList<Alumni> alumni = alumniTree.inorder();
                        for (Alumni a : alumni)
                        {
                            System.out.println(a);
                        }

                        break;
                    case 2:
                        ArrayList<Employee> employees = employeeTree.inorder();
                        for (Employee e : employees)
                        {
                            System.out.println(e);
                        }

                        break;
                    default:
                        printSelectTreeMessage();
                        break;
                }
            }
            else if (input.equals("c"))
            {
                switch (tree)
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
                        printSelectTreeMessage();
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

    static void printSelectTreeMessage()
    {
        System.out.println("Not currently working with any tree. Use the 'w' command to select one.");
    }
}
