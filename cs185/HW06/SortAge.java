package HW06;

/**
 * Represents an object sortable to other objects by age.
 * @author Jake Petroules
 * @course CS-185-01
 * @filename SortAge.java
 */
public interface SortAge
{
	/**
	 * Compares the ages represented by two {@link SortAge} objects.
	 * @param other The other {@link SortAge} to compare to.
	 * @return The value 0 if the age represented by the argument is
	 * equal to the age represented by this {@link SortAge}; a value
	 * less than 0 if the age of this {@link SortAge} is less than the
	 * age represented by the argument; and a value greater than 0 if
	 * the age of this {@link SortAge} is greater than the age
	 * represented by the argument.
	 */
	public int compareAge(SortAge other);
	
	/**
	 * Gets the age.
	 * @return The age.
	 */
	public int getAge(); 
}
