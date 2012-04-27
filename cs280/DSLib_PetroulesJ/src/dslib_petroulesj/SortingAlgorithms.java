package dslib_petroulesj;

import java.util.Arrays;
import java.util.Comparator;
import java.util.List;

/**
 * Provides access to various implementations of sorting algorithms.
 * @author Jake Petroules
 */
public class SortingAlgorithms
{
    /**
     * Enumerates various algorithms that may be used to sort lists.
     */
    public enum Algorithm
    {
        /**
         * Specified the 'straight' selection sort algorithm.
         */
        StraightSelectionSort,
        
        /**
         * Specifies the 'exchange' selection sort algorithm.
         */
        SelectionSort,

        /**
         * Specifies the quick sort algorithm.
         */
        QuickSort,

        /**
         * Specifies the bubble sort algorithm.
         */
        BubbleSort,

        /**
         * Specifies the merge sort algorithm.
         */
        MergeSort
    }

    /**
     * Prevents a default instance of {@link SortingAlgorithms} from being constructed.
     */
    private SortingAlgorithms()
    {
    }

    /**
     * Sorts a list of objects using the specified sorting algorithm.
     * @param <T> the type of objects to sort
     * @param list the list of objects to sort
     * @param algorithm the algorithm used to sort the list
     * @param comparator the comparator used to sort the objects in a particular order; specify
     * <c>null</c> to use the default comparator (equivalent to {@link Comparable.compareTo}).
     */
    public static <T extends Comparable<? super T>> void sort(List<T> list, Algorithm algorithm,
            Comparator<T> comparator)
    {
        // A list with less than 2 items needn't be sorted!
        if (list.size() < 2)
        {
            return;
        }

        // Use the default comparable if we were given a null one
        if (comparator == null)
        {
            comparator = SortingAlgorithms.<T>getDefaultComparator();
        }

        switch (algorithm)
        {
            case StraightSelectionSort:
                SortingAlgorithms.straightSelectionSort(list, comparator);
                break;
            case SelectionSort:
                SortingAlgorithms.selectionSort(list, comparator);
                break;
            case QuickSort:
                SortingAlgorithms.quickSort(list, comparator, 0, list.size() - 1);
                break;
            case BubbleSort:
                SortingAlgorithms.bubbleSort(list, comparator);
                break;
            case MergeSort:
                List<T> newList = new ArrayList<T>();
                for (int i = 0; i < list.size(); i++)
                {
                    newList.add(null);
                }

                SortingAlgorithms.mergeSort(list, comparator, newList, 0, list.size() - 1);
                list = newList;
                break;
            default:
                throw new IllegalArgumentException("Algorithm not recognized: " + algorithm);
        }
    }

    /**
     * Sorts an array of objects using the specified sorting algorithm.
     * @param <T> the type of objects to sort
     * @param array the array of objects to sort
     * @param algorithm the algorithm used to sort the list
     * @param comparator the comparator used to sort the objects in a particular order; specify
     * <c>null</c> to use the default comparator (equivalent to {@link Comparable.compareTo}).
     */
    public static <T extends Comparable<? super T>> void sort(T[] array, Algorithm algorithm,
            Comparator<T> comparator)
    {
        List<T> list = new ArrayList<T>(Arrays.asList(array));
        SortingAlgorithms.sort(list, algorithm, comparator);

        // Copy items back
        for (int i = 0; i < array.length; i++)
        {
            array[i] = list.get(i);
        }
    }

    private static <T> void straightSelectionSort(List<T> list, Comparator<T> comparator)
    {
        T lowPCI;
        int lowIndex = 0;
        List<T> sortedList = new ArrayList<T>();
        for (int i = 0; i < list.size(); i++)
        {
            sortedList.add(null);
        }

        for (int y = 0; y < list.size(); y++)
        {
            lowPCI = null;

            for (int x = 0; x < list.size(); x++)
            {
                if (lowPCI == null || (list.get(x) != null && comparator.compare(list.get(x), lowPCI) < 0))
                {
                    lowPCI = list.get(x);
                    lowIndex = x;
                }
            }

            sortedList.set(y, list.get(lowIndex));
            list.set(lowIndex, null);
        }

        list = sortedList;
    }

    /**
     * Sorts a list using selection sort.
     * @param <T> the type of objects to sort
     * @param list the list to sort
     * @param comparator the comparator used to sort the objects in a particular order; specify
     * <c>null</c> to use the default comparator (equivalent to {@link Comparable.compareTo}).
     */
    private static <T> void selectionSort(List<T> list, Comparator<T> comparator)
    {
        int min;

        for (int i = 0; i < list.size() - 1; i++)
        {
            min = i;

            for (int j = i + 1; j < list.size(); j++)
            {
                if (comparator.compare(list.get(j), list.get(min)) < 0)
                {
                    min = j;
                }
            }

            // Swap the values
            T temp = list.get(min);
            list.set(min, list.get(i));
            list.set(i, temp);
        }
    }

    /**
     * Performs the actual work of the quick sort algorithm.
     * @param <T> the type of objects to sort
     * @param list the list to sort
     * @param comparator the comparator used to sort the objects in a particular order; specify
     * <c>null</c> to use the default comparator (equivalent to {@link Comparable.compareTo}).
     * @param left0 lower index of the current partition (0 initially)
     * @param right0 upper index of the current partition (list length minus 1 initially)
     */
    private static <T> void quickSort(List<T> array, Comparator<T> comparator, int left0, int right0)
    {
        int left = left0;
        int right = right0 + 1;
        T pivot = array.get(left0);
        T temp;

        do
        {
            do
            {
                left++;
            }
            while (left <= right0 && comparator.compare(array.get(left), pivot) < 0);

            do
            {
                right--;
            }
            while (comparator.compare(array.get(right), pivot) > 0);

            if (left < right)
            {
                temp = array.get(left);
                array.set(left, array.get(right));
                array.set(right, temp);
            }
        }
        while (left <= right);

        temp = array.get(left0);
        array.set(left0, array.get(right));
        array.set(right, temp);

        if (left0 < right)
        {
            SortingAlgorithms.quickSort(array, comparator, left0, right);
        }

        if (left < right0)
        {
            SortingAlgorithms.quickSort(array, comparator, left, right0);
        }
    }

    private static <T> void bubbleSort(List<T> list, Comparator<T> comparator)
    {
        for (int i = 0; i < list.size(); i++)
        {
            for (int j = list.size() - 1; j > i; j--)
            {
                if (comparator.compare(list.get(j - 1), list.get(j)) > 0)
                {
                    // Swap the values
                    T temp = list.get(j - 1);
                    list.set(j - 1, list.get(j));
                    list.set(j, temp);
                }
            }
        }
    }

    private static <T> void mergeSort(List<T> list, Comparator<T> comparator, List<T> newList, int left, int right)
    {
        if (left < right)
        {
            int center = (left + right ) / 2;
            mergeSort(list, comparator, newList, left, center);
            mergeSort(list, comparator, newList, center + 1, right);
            mergeSortInternal(list, comparator, newList, left, center + 1, right);
        }
    }

    private static <T> void mergeSortInternal(List<T> list, Comparator<T> comparator, List<T> newList, int leftPos, int rightPos, int rightEnd)
    {
        int leftEnd = rightPos - 1;
        int tmpPos = leftPos;
        int numElements = rightEnd - leftPos + 1;

        // Main loop
        while (leftPos <= leftEnd && rightPos <= rightEnd)
        {
            if (comparator.compare(list.get(leftPos), list.get(rightPos)) <= 0)
            {
                newList.set(tmpPos++, list.get(leftPos++));
            }
            else
            {
                newList.set(tmpPos++, list.get(rightPos++));
            }
        }

        // Copy rest of first half
        while (leftPos <= leftEnd)
        {
            newList.set(tmpPos++, list.get(leftPos++));
        }

        // Copy rest of right half
        while (rightPos <= rightEnd)
        {
            newList.set(tmpPos++, list.get(rightPos++));
        }

        // Copy tmpArray back
        for (int i = 0; i < numElements; i++, rightEnd--)
        {
            list.set(rightEnd, newList.get(rightEnd));
        }
    }

    /**
     * Gets a default {@link Comparator} for objects extending the {@link Comparable} class.
     * @param <T> the type of object to compare
     */
    private static <T extends Comparable<? super T>> Comparator<T> getDefaultComparator()
    {
        return new Comparator<T>()
        {
            public int compare(T a, T b)
            {
                return a.compareTo(b);
            }
        };
    }
}
