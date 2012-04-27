package dsass03b_petroulesj;

import dslib_petroulesj.LinkedList;
import dslib_petroulesj.SortingAlgorithms;
import java.util.Collection;
import java.util.Comparator;

/**
 * Represents a list of countries.
 * @author Jake Petroules
 */
public class CountryCollection extends LinkedList<Country>
{
    /**
     * Constructs an empty list with an initial capacity of ten.
     */
    public CountryCollection()
    {
        super();
    }

    /**
     * Constructs a list containing the elements of the specified collection, in the order they are
     * returned by the collection's iterator.
     * @param c the collection whose elements are to be placed into this list
     * @throws NullPointerException if the specified collection is null
     */
    public CountryCollection(Collection<? extends Country> c)
    {
        super(c);
    }

    /**
     * Gets the country with the lowest per capita income (PCI).
     *
     * @return This method is guaranteed to return a reference to a Country unless there are no
     * items in the list. If there is more than one country with the same PCI and both happen to be
     * the lowest, the item that appears first in the list will be returned.
     */
    public Country getLowestPCICountry()
    {
        Country lowest = null;

        for (int i = 0; i < this.size(); i++)
        {
            Country current = this.get(i);

            if (current != null && (lowest == null || current.getPerCapitaIncome() < lowest.getPerCapitaIncome()))
            {
                lowest = current;
            }
        }

        return lowest;
    }

    /**
     * Gets the country with the highest per capita income (PCI).
     *
     * @return This method is guaranteed to return a reference to a Country unless there are no
     * items in the list. If there is more than one country with the same PCI and both happen to be
     * the highest, the item that appears first in the list will be returned.
     */
    public Country getHighestPCICountry()
    {
        Country highest = null;

        for (int i = 0; i < this.size(); i++)
        {
            Country current = this.get(i);

            if (current != null && (highest == null || current.getPerCapitaIncome() > highest.getPerCapitaIncome()))
            {
                highest = current;
            }
        }

        return highest;
    }

    /**
     * Gets the average per capita income (PCI) of all countries in the list.
     *
     * @return If there are no countries in the list, this method returns 0.
     */
    public long getAveragePerCapitaIncome()
    {
        // Exit if we've got no countries, otherwise we'll divide by 0 down below
        if (this.size() == 0)
        {
            return 0;
        }

        // Sum up the PCIs...
        int countCountries = 0;
        long sumPCI = 0;
        for (int i = 0; i < this.size(); i++)
        {
            Country current = this.get(i);
            
            // Count countries manually as size() wouldn't account for null values
            if (current != null)
            {
                sumPCI += current.getPerCapitaIncome();
                countCountries++;
            }
        }

        return sumPCI / countCountries;
    }

    /**
     * Gets the standard deviation of the per capita income (PCI) of the countries in this list.
     *
     * @return If there are no countries in the list, this method returns 0.
     */
    public long getStandardDeviation()
    {
        long averagePCI = this.getAveragePerCapitaIncome();

        // Exit if we've got no countries or the average PCI is 0 (which is logically impossible
        // since a country making no money would immediately collapse, but this is a computer
        // program), otherwise we'll divide by 0 down below
        if (this.size() == 0 || averagePCI == 0)
        {
            return 0;
        }

        // Sum up the deviations from the mean
        int countCountries = 0;
        long sumDeviations = 0;
        for (int i = 0; i < this.size(); i++)
        {
            Country current = this.get(i);

            // Count countries manually as size() wouldn't account for null values
            if (current != null)
            {
                sumDeviations += Math.pow(current.getPerCapitaIncome() - averagePCI, 2);
                countCountries++;
            }
        }

        return (long)Math.sqrt(sumDeviations / countCountries);
    }

    /**
     * Sorts the list of countries by per capita income.
     */
    public void sortByPerCapitaIncome()
    {
        SortingAlgorithms.sort(this, SortingAlgorithms.Algorithm.QuickSort,
            new Comparator<Country>()
            {
                public int compare(Country a, Country b)
                {
                    if (a.getPerCapitaIncome() == b.getPerCapitaIncome())
                    {
                        return 0;
                    }

                    return a.getPerCapitaIncome() < b.getPerCapitaIncome() ? -1 : 1;
                }
            });
    }

    /**
     * Searches for and returns the index of the first occurrence of the country with the specified
     * name. The name is matched case insensitively.
     * @param name the name of the country to find
     */
    public int indexOf(String name)
    {
        for (int i = 0; i < this.size(); i++)
        {
            if (this.get(i).getName().equalsIgnoreCase(name))
            {
                return i;
            }
        }

        return -1;
    }

    /**
     * Fills the list with data from the 25 most populated countries in the world.
     *
     * Note that any existing items in the list will be removed.
     *
     * Sources:
     * http://en.wikipedia.org/wiki/List_of_countries_by_population and
     * http://en.wikipedia.org/wiki/List_of_countries_by_GDP_(PPP)
     */
    public void fillWithData()
    {
        this.clear();

        final long MILLION = 1000000;

        this.add(new Country("China", 1339490000, 8765240 * MILLION));
        this.add(new Country("India", 1187640000, 3526124 * MILLION));
        this.add(new Country("United States", 310249000, 14256275 * MILLION));
        this.add(new Country("Indonesia", 237556363, 962471 * MILLION));
        this.add(new Country("Brazil", 193510000, 2013186 * MILLION));

        this.add(new Country("Pakistan", 170541000, 439558 * MILLION));
        this.add(new Country("Bangladesh", 164425000, 224889 * MILLION));
        this.add(new Country("Nigeria", 158259000, 315401 * MILLION));
        this.add(new Country("Russia", 141927297, 2109551 * MILLION));
        this.add(new Country("Japan", 127390000, 4159432 * MILLION));

        this.add(new Country("Mexico", 108396211, 1465726 * MILLION));
        this.add(new Country("Philippines", 94013200, 320384 * MILLION));
        this.add(new Country("Vietnam", 85846997, 240364 * MILLION));
        this.add(new Country("Germany", 81802257, 2806266 * MILLION));
        this.add(new Country("Ethiopia", 79221000, 70995 * MILLION));

        this.add(new Country("Egypt", 79029000, 442640 * MILLION));
        this.add(new Country("Iran", 75078000, 827858 * MILLION));
        this.add(new Country("Turkey", 72561312, 880061 * MILLION));
        this.add(new Country("Democratic Republic of the Congo", 67827000, 20639 * MILLION));
        this.add(new Country("Thailand", 67070000, 546095 * MILLION));

        this.add(new Country("France", 65447374, 2108228 * MILLION));
        this.add(new Country("United Kingdom", 62008049, 2139400 * MILLION));
        this.add(new Country("Italy", 60402499, 1740123 * MILLION));
        this.add(new Country("Myanmar (Burma)", 50496000, 68203 * MILLION));
        this.add(new Country("South Africa", 49991300, 492684 * MILLION));
    }
}
