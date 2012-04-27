package HW07;

/**
 * Contains methods for performing a selection sort.
 * @author Jake Petroules
 * @course CS-185-01
 * @filename Sorting.java
 */
public class Sorting
{
	/**
	 * Sorts the specified array of objects using the selection sort algorithm.
	 * @param <T> The type of objects to sort.
	 * @param list The array of objects to sort.
	 */
	public static <T extends Comparable<? super T>> void selectionsort(T[] list)
	{
		int min;
		
		for (int i = 0; i < list.length - 1; i++)
		{
			min = i;
			
			for (int j = i + 1; j < list.length; j++)
			{
				if (list[j].compareTo(list[min]) < 0)
				{
					min = j;
				}
			}
			
			// Swap the values
			T temp = list[min];
			list[min] = list[i];
			list[i] = temp;
		}
	}
}
