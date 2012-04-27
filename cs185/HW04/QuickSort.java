package HW04;

/**
 * Contains methods for sorting arrays using the quicksort algorithm.
 * @author Jake Petroules
 * @course CS-185-01
 * @filename QuickSort.java
 */
public class QuickSort
{
	/**
	 * Sorts the specified array in nondecreasing order using the quicksort algorithm.
	 * @param <T> The type of the array to sort.
	 * @param array The array to sort.
	 */
	public static <T extends Comparable<? super T>> void quicksort(T[] array)
	{
		quicksort(array, 0, array.length - 1);
	}

	/**
	 * Performs the actual work of the quicksort algorithm.
	 * @param <T> The type of the array to sort.
	 * @param array The array to sort.
	 * @param left0 The lower index of the current partition.
	 * @param right0 The upper index of the current partition.
	 */
	private static <T extends Comparable<? super T>> void quicksort(T[] array, int left0, int right0)
	{
		int left = left0;
		int right = right0 + 1;
		T pivot = array[left0];
		T temp;

		do
		{
			do
			{
				left++;
			}
			while (left <= right0 && array[left].compareTo(pivot) < 0);

			do
			{
				right--;
			}
			while (array[right].compareTo(pivot) > 0);

			if (left < right)
			{
				temp = array[left];
				array[left] = array[right];
				array[right] = temp;
			}
		}
		while (left <= right);

		temp = array[left0];
		array[left0] = array[right];
		array[right] = temp;

		if (left0 < right)
		{
			quicksort(array, left0, right);
		}
		
		if (left < right0)
		{
			quicksort(array, left, right0);
		}
	}
}
