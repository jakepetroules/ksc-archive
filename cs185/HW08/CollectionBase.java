package HW08;

/**
 * Represents a generic collection.
 * @param <T> The type of the objects contained in the collection.
 * @author Jake Petroules
 * @course CS-185-01
 * @filename CollectionBase.java
 */
public abstract class CollectionBase<T>
{
	/**
	 * The default size of the internal array.
	 */
	public final int DEFAULT_CAPACITY = 40;
	
	/**
	 * The objects in the collection.
	 */
	private Object[] members;
	
	/**
	 * The number of objects in the collection.
	 */
	private int count;
	
	/**
	 * Initializes a new instance of the {@link CollectionBase} class with the default capacity.
	 */
	protected CollectionBase()
	{
		this.members = new Object[this.DEFAULT_CAPACITY];
	}
	
	/**
	 * Initializes a new instance of the {@link CollectionBase} class with the default capacity and members.
	 * @param array The array of objects to insert into the collection initially.
	 */
	protected CollectionBase(T[] array)
	{
		this.members = new Object[this.DEFAULT_CAPACITY];
		this.add(array);
	}
	
	/**
	 * Initializes a new instance of the {@link CollectionBase} class.
	 * @param capacity The default size of the internal array.
	 */
	protected CollectionBase(int capacity)
	{
		this.members = new Object[capacity];
	}
	
	/**
	 * Adds an object to the collection.
	 * @param object The object to add.
	 */
	public void add(T object)
	{
		this.members[count++] = object;
	}
	
	/**
	 * Adds an array of objects to the collection.
	 * @param objects The objects to add.
	 */
	public void add(T[] objects)
	{
		for (int i = 0; i < objects.length; i++)
		{
			this.add(objects[i]);
		}
	}
	
	/**
	 * Determines whether an object is contained in the collection.
	 * @param object The object to check.
	 * @return Whether {@link object} is contained in the collection.
	 */
	public boolean contains(T object)
	{
		return this.indexOf(object) > -1;
	}
	
	/**
	 * Returns the index of {@link object}.
	 * @param object The object to get the index of.
	 * @return The index of {@link object}; -1 if it is not in the collection.
	 */
	public int indexOf(T object)
	{
		for (int i = 0; i < this.members.length; i++)
		{
			if (this.members[i] == object)
			{
				return i;
			}
		}
		
		return -1;
	}
	
	/**
	 * Inserts {@link object} at the index specified by {@link index}.
	 * @param obect The object to insert.
	 * @param index The index to insert {@link object} at.
	 */
	public void insert(T object, int index)
	{
		if (index >= this.count)
		{
			throw new IndexOutOfBoundsException("index must be less than the number of elements in the collection.");
		}
		
		this.shiftDown(index);
		this.members[index] = object;
		this.count++;
	}
	
	/**
	 * Removes {@link object} from the collection.
	 * @param object The object to remove.
	 * @return The object that was removed.
	 */
	@SuppressWarnings("unchecked")
	public T remove(T object)
	{
		T removedOS = null;
		int index = this.indexOf(object);
		if (index == -1)
		{
			return removedOS;
		}
		else
		{
			removedOS = (T)this.members[index];
		}
		
		this.shiftUp(index);
		
		this.count--;
		return removedOS;
	}
	
	/**
	 * Removes the object at the specified index.
	 * @param index The index to remove the object at.
	 * @return The object that was removed.
	 */
	@SuppressWarnings("unchecked")
	public T removeAt(int index)
	{
		if (index >= this.count)
		{
			throw new IndexOutOfBoundsException("index must be less than the number of elements in the collection.");
		}
		
		return this.remove((T)this.members[index]);
	}
	
	/**
	 * Gets the element at the specified index.
	 * @param index The index to get the element at.
	 * @return The element at {@link index}.
	 */
	@SuppressWarnings("unchecked")
	public T get(int index)
	{
		if (index >= this.count)
		{
			throw new IndexOutOfBoundsException("index must be less than the number of elements in the collection.");
		}
		
		return (T)this.members[index];
	}
	
	/**
	 * Gets the number of objects in the collection.
	 * @return The number of objects in the collection.
	 */
	public int size()
	{
		return this.count;
	}
	
	/**
	 * Gets a value indicating whether the internal array is at capacity; that is, whether all elements in the array contain objects.
	 * @return Whether the array is at capacity.
	 */
	private boolean atCapacity()
	{
		return this.count == this.members.length;
	}
	
	/**
	 * Extends the size of the internal array by {@link DEFAULT_CAPACITY} elements.
	 */
	private void grow()
	{
		int newCount = this.members.length + this.DEFAULT_CAPACITY;
		Object[] membersLarger = new Object[newCount];
		for (int i = 0; i < this.count; i++)
		{
			membersLarger[i] = this.members[i];
		}
		
		this.members = membersLarger;
		this.count = newCount;
	}
	
	/**
	 * Shifts all elements in the internal array up by one, overwriting
	 * the element at {@link startingIndex} with its neighbor.
	 * @param startingIndex
	 */
	private void shiftUp(int startingIndex)
	{
		for (int i = startingIndex; i <= this.count; i++)
		{
			if (i == this.count)
			{
				this.members[i] = null;
				break;
			}
			else
			{
				this.members[i] = this.members[i + 1];
			}
		}
	}
	
	/**
	 * Shifts all elements in the internal array down by one, setting
	 * the element at {@link startingIndex} equal to <code>null</code>.
	 * @param startingIndex
	 */
	private void shiftDown(int startingIndex)
	{
		if (this.atCapacity())
		{
			this.grow();
		}
			
		for (int i = this.count; i > startingIndex; i--)
		{
			this.members[i] = this.members[i - 1];
		}
		
		this.members[startingIndex] = null;
	}
}
