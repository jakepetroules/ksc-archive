package dsass06b_petroulesj;

import dslib_petroulesj.SortingAlgorithms;
import dslib_petroulesj.SortingAlgorithms.Algorithm;
import java.io.BufferedReader;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.InputStreamReader;

public class SortSimulator
{
    public static void main(String[] args) throws IOException
    {
        CountryCollection countryList = new CountryCollection();

        System.out.println("Welcome to sort timer. Available commands:");
        System.out.println("a - Add a country to the list");
        System.out.println("r - Load a country list from a file (hint: try 'data.txt', it has 35000 elements so it'll be easier to compare timings)");
        System.out.println("s - Save the current country list to a file");
        System.out.println("l - Perform sort analysis");
        System.out.println("d - Display the list");
        System.out.println("c - Clear the list");
        System.out.println("q - Quit the program");

        BufferedReader scanner = new BufferedReader(new InputStreamReader(System.in));
        String input;
        do
        {
            System.out.println("What do you want to do? ");
            input = scanner.readLine();

            if (input.equals("a"))
            {
                System.out.print("Enter name: ");
                String name = scanner.readLine();
                System.out.print("Enter population: ");
                long population = Long.parseLong(scanner.readLine());
                System.out.print("Enter GNI: ");
                long gni = Long.parseLong(scanner.readLine());

                countryList.add(new Country(name, population, gni));
            }
            else if (input.equals("r"))
            {
                System.out.print("Enter the name of the file: ");
                countryList = loadFile(scanner.readLine());
            }
            else if (input.equals("s"))
            {
                System.out.print("Enter the name of the file: ");
                saveFile(scanner.readLine(), countryList);
            }
            else if (input.equals("l"))
            {
                System.out.println("Sorting " + countryList.size() + "-element list...");
                long sssTime = timeSort(countryList, Algorithm.StraightSelectionSort);
                long essTime = timeSort(countryList, Algorithm.SelectionSort);
                long qsTime = timeSort(countryList, Algorithm.QuickSort);
                long bsTime = timeSort(countryList, Algorithm.BubbleSort);
                long msTime = timeSort(countryList, Algorithm.MergeSort);

                System.out.println(sssTime + " ms - straight selection sort");
                System.out.println(essTime + " ms - exchange selection sort");
                System.out.println(qsTime + " ms - quick sort");
                System.out.println(bsTime + " ms - bubble sort");
                System.out.println(msTime + " ms - merge sort");
            }
            else if (input.equals("d"))
            {
                for (int i = 0; i < countryList.size(); i++)
                {
                    Country country = countryList.get(i);
                    System.out.println(country.getName() + "\t" + country.getPopulation() + "\t" + country.getGrossNationalIncome());
                }
            }
            else if (input.equals("c"))
            {
                countryList.clear();
            }
        }
        while (!input.equals("q"));
    }

    public static CountryCollection loadFile(String fileName) throws IOException
    {
        CountryCollection collection = new CountryCollection();
        BufferedReader scanner = new BufferedReader(new FileReader(fileName));
        String s;
        while ((s = scanner.readLine()) != null)
        {
            collection.add(new Country(s, Long.parseLong(scanner.readLine()), Long.parseLong(scanner.readLine())));
        }

        scanner.close();

        return collection;
    }

    public static void saveFile(String fileName, CountryCollection collection) throws IOException
    {
        FileWriter writer = new FileWriter(fileName);
        for (int i = 0; i < collection.size(); i++)
        {
            Country country = collection.get(i);
            writer.write(country.getName() + "\n");
            writer.write(country.getPopulation() + "\n");
            writer.write(country.getGrossNationalIncome() + "\n");
        }

        writer.close();
    }

    /**
     * Sorts a clone of the specified list using the specified algorithm and returns the number of
     * milliseconds the execution took to complete.
     * @param countryList The list to sort.
     * @param algorithm The algorithm to sort with.
     * @return
     */
    public static long timeSort(CountryCollection countryList, Algorithm algorithm)
    {
        long start = System.currentTimeMillis();
        SortingAlgorithms.sort(new CountryCollection(countryList), algorithm, null);
        return System.currentTimeMillis() - start;
    }
}
