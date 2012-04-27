package dsass03a_petroulesj;

/**
 * Represents a country and provides access to related demographic and financial data.
 * @author Jake Petroules
 */
public class Country implements Comparable<Country>
{
    /**
     * The name of the country.
     */
    private String name;

    /**
     * The number of persons who are citizens of the country.
     */
    private long population;

    /**
     * The country's gross national income (GNI).
     */
    private long grossNationalIncome;

    /**
     * Initializes a new instance of the {@link Country} class.
     */
    public Country()
    {
    }

    /**
     * Initializes a new instance of the {@link Country} class with the specified details.
     * @param name The name of the country.
     * @param population The number of persons who are citizens of the country.
     * @param grossNationalIncome The country's gross national income (GNI).
     */
    public Country(String name, long population, long grossNationalIncome)
    {
        this.name = name;
        this.population = population;
        this.grossNationalIncome = grossNationalIncome;
    }

    /**
     * Gets the name of the country.
     */
    public String getName()
    {
        return this.name;
    }

    /**
     * Sets the name of the country.
     */
    public void setName(String name)
    {
        this.name = name;
    }

    /**
     * Gets the number of persons who are citizens of the country.
     */
    public long getPopulation()
    {
        return this.population;
    }

    /**
     * Sets the number of persons who are citizens of the country.
     */
    public void setPopulation(long population)
    {
        this.population = population;
    }

    /**
     * Gets the country's gross national income (GNI).
     */
    public long getGrossNationalIncome()
    {
        return this.grossNationalIncome;
    }

    /**
     * Sets the country's gross national income (GNI).
     */
    public void setGrossNationalIncome(long grossNationalIncome)
    {
        this.grossNationalIncome = grossNationalIncome;
    }

    /**
     * Computes and returns the country's per capita income (PCI).
     * 
     * This value is equal to the GNI divided by the population.
     */
    public long getPerCapitaIncome()
    {
        return this.grossNationalIncome / this.population;
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public int compareTo(Country o)
    {
        // If both are null they're equal
        if (this.name == null && o.name == null)
        {
            return 0;
        }

        // If this exists and other does not, this goes after
        if (this.name != null && o.name == null)
        {
            return 1;
        }

        // If this does not exist and other does, this goes before
        if (this.name == null && o.name != null)
        {
            return -1;
        }
        
        return this.name.compareTo(o.name);
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public int hashCode()
    {
        int hash = 3;
        hash = 37 * hash + (this.name != null ? this.name.hashCode() : 0);
        hash = 37 * hash + (int) (this.population ^ (this.population >>> 32));
        hash = 37 * hash + (int) (this.grossNationalIncome ^ (this.grossNationalIncome >>> 32));
        return hash;
    }

    /**
     * Determines whether this {@link Country} is considered equivalent to {@link other}. The two
     * instances are considered equal if their name, population and GNI are equivalent.
     *
     * @see Object.equals
     */
    @Override
    public boolean equals(Object obj)
    {
        if (obj instanceof Country)
        {
            Country other = (Country)obj;

            return (this.name == null ? other.name == null : this.name.equals(other.name))
                && this.population == other.population
                && this.grossNationalIncome == other.grossNationalIncome;
        }

        return false;
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public Object clone()
    {
        return new Country(this.name, this.population, this.grossNationalIncome);
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public String toString()
    {
        return String.format("{%1$s, Population: %2$d, GNI: %3$d, PCI: %4$d}",
                this.name, this.population, this.grossNationalIncome, this.getPerCapitaIncome());
    }
}
