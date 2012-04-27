package dslib_petroulesj;

import java.io.Serializable;
import java.util.AbstractList;
import java.util.Arrays;
import java.util.Collection;
import java.util.ConcurrentModificationException;
import java.util.Iterator;
import java.util.List;
import java.util.ListIterator;
import java.util.RandomAccess;

/**
 * Provides equivalent functionality to the standard {@link java.util.ArrayList{E}} class.
 *
 * This class is written in such a way (implements the same interfaces) that it could be a drop-in
 * replacement for {@link java.util.ArrayList{E}} since this class is pointless as it already exists
 * in the standard library.
 * 
 * @author Jake Petroules
 */
public class ArrayList<E> extends AbstractList<E> implements List<E>, RandomAccess, Cloneable, Serializable
{
    private static final long serialVersionUID = 8683452581122892189L + 7742;

    /**
     * The array buffer into which the elements of the ArrayList are stored.
     * The capacity of the ArrayList is the length of this array buffer.
     */
    private transient Object[] elementData;

    /**
     * The size of the ArrayList (the number of elements it contains).
     */
    private int size;

    /**
     * Constructs an empty list with an initial capacity of ten.
     */
    public ArrayList()
    {
        this(10);
    }

    /**
     * Constructs an empty list with the specified initial capacity.
     * @param initialCapacity the initial capacity of the list
     * @exception IllegalArgumentException if the specified initial capacity is negative
     */
    public ArrayList(int initialCapacity)
    {
        if (initialCapacity < 0)
        {
            throw new IllegalArgumentException("Illegal Capacity: " + initialCapacity);
        }

        this.elementData = new Object[initialCapacity];
    }

    /**
     * Constructs a list containing the elements of the specified collection, in the order they are
     * returned by the collection's iterator.
     * @param c the collection whose elements are to be placed into this list
     * @throws NullPointerException if the specified collection is null
     */
    public ArrayList(Collection<? extends E> c)
    {
        this.elementData = c.toArray();
        this.size = this.elementData.length;

        // Collection.toArray() doesn't always return an Object array; see
        // http://bugs.sun.com/bugdatabase/view_bug.do?bug_id=6260652
        if (this.elementData.getClass() != Object[].class)
        {
	    this.elementData = Arrays.copyOf(this.elementData, this.size, Object[].class);
        }
    }

    /**
     * Increases the capacity of this {@link ArrayList} instance, if necessary, to ensure that it
     * can hold at least the number of elements specified by the minimum capacity argument.
     * @param minCapacity the desired minimum capacity
     */
    public void ensureCapacity(int minCapacity)
    {
        this.modCount++;
	int oldCapacity = this.elementData.length;
	if (minCapacity > oldCapacity)
        {
	    Object[] oldData = this.elementData;
	    int newCapacity = ((oldCapacity * 3) / 2) + 1;
    	    if (newCapacity < minCapacity)
            {
		newCapacity = minCapacity;
            }
            
            this.elementData = Arrays.copyOf(this.elementData, newCapacity);
	}
    }

    /**
     * {@inheritDoc}
     */
    public int size()
    {
        return this.size;
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public boolean isEmpty()
    {
        return this.size == 0;
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public boolean contains(Object o)
    {
        return this.indexOf(o) > -1;
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public Object[] toArray()
    {
        return Arrays.copyOf(this.elementData, this.size);
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public <T> T[] toArray(T[] a)
    {
        if (a.length < this.size)
        {
            return (T[])Arrays.copyOf(this.elementData, this.size, a.getClass());
        }

	System.arraycopy(this.elementData, 0, a, 0, this.size);
        if (a.length > this.size)
        {
            a[this.size] = null;
        }

        return a;
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public boolean add(E e)
    {
        // Increments modCount!!
        this.ensureCapacity(this.size + 1);
        this.elementData[this.size++] = e;
        return true;
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public boolean remove(Object o)
    {
        if (o == null)
        {
            for (int i = 0; i < this.size; i++)
            {
		if (this.elementData[i] == null)
                {
		    this.fastRemove(i);
		    return true;
		}
            }
	}
        else
        {
	    for (int i = 0; i < this.size; i++)
            {
                // o will never be null here, elementData[i] could be
		if (o.equals(this.elementData[i]))
                {
		    this.fastRemove(i);
		    return true;
		}
            }
        }

	return false;
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public boolean containsAll(Collection<?> c)
    {
        throw new UnsupportedOperationException("Not supported yet.");
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public boolean addAll(Collection<? extends E> c)
    {
        Object[] a = c.toArray();
        int numNew = a.length;

        // Increments modCount
	this.ensureCapacity(this.size + numNew);

        System.arraycopy(a, 0, this.elementData, this.size, numNew);
        this.size += numNew;
	return numNew != 0;
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public boolean addAll(int index, Collection<? extends E> c)
    {
        if (index > this.size || index < 0)
        {
	    throw new IndexOutOfBoundsException("Index: " + index + ", Size: " + this.size);
        }

	Object[] a = c.toArray();
	int numNew = a.length;

        // Increments modCount
	this.ensureCapacity(this.size + numNew);

	int numMoved = this.size - index;
	if (numMoved > 0)
        {
	    System.arraycopy(this.elementData, index, this.elementData, index + numNew, numMoved);
        }

        System.arraycopy(a, 0, this.elementData, index, numNew);
	this.size += numNew;
	return numNew != 0;
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public boolean removeAll(Collection<?> c)
    {
        throw new UnsupportedOperationException("Not supported yet.");
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public boolean retainAll(Collection<?> c)
    {
        throw new UnsupportedOperationException("Not supported yet.");
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public void clear()
    {
        this.modCount++;
        
	for (int i = 0; i < this.size; i++)
        {
	    this.elementData[i] = null;
        }

	this.size = 0;
    }

    /**
     * {@inheritDoc}
     */
    public E get(int index)
    {
        this.rangeCheck(index);
	return (E)this.elementData[index];
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public E set(int index, E element)
    {
        this.rangeCheck(index);
	E oldValue = (E)this.elementData[index];
	this.elementData[index] = element;
	return oldValue;
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public void add(int index, E element)
    {
        if (index > this.size || index < 0)
        {
	    throw new IndexOutOfBoundsException("Index: " + index + ", Size: " + this.size);
        }

        // Increments modCount!!
	this.ensureCapacity(this.size + 1);
	System.arraycopy(this.elementData, index, this.elementData, index + 1, this.size - index);
	this.elementData[index] = element;
	this.size++;
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public E remove(int index)
    {
        this.rangeCheck(index);

        this.modCount++;
	E oldValue = (E)this.elementData[index];

	int numMoved = (this.size - index) - 1;
	if (numMoved > 0)
        {
	    System.arraycopy(this.elementData, index + 1, this.elementData, index, numMoved);
        }

	this.elementData[--this.size] = null;

	return oldValue;
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public int indexOf(Object o)
    {
        if (o == null)
        {
	    for (int i = 0; i < this.size; i++)
            {
		if (this.elementData[i] == null)
                {
		    return i;
                }
            }
	}
        else
        {
	    for (int i = 0; i < this.size; i++)
            {
                // o will never be null here, elementData[i] could be
		if (o.equals(this.elementData[i]))
                {
		    return i;
                }
            }
	}

	return -1;
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public int lastIndexOf(Object o)
    {
        if (o == null)
        {
	    for (int i = this.size - 1; i >= 0; i--)
            {
		if (this.elementData[i] == null)
                {
		    return i;
                }
            }
	}
        else
        {
	    for (int i = this.size - 1; i >= 0; i--)
            {
		if (o.equals(this.elementData[i]))
                {
		    return i;
                }
            }
	}

	return -1;
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public ListIterator<E> listIterator()
    {
        throw new UnsupportedOperationException("Not supported yet.");
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public ListIterator<E> listIterator(int index)
    {
        throw new UnsupportedOperationException("Not supported yet.");
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public List<E> subList(int fromIndex, int toIndex)
    {
        throw new UnsupportedOperationException("Not supported yet.");
    }

    /**
     * Removes the element at the specified index.
     * This method skips bounds checking and does not return the value removed.
     */
    private void fastRemove(int index)
    {
        this.modCount++;
        int numMoved = (this.size - index) - 1;
        if (numMoved > 0)
        {
            System.arraycopy(this.elementData, index + 1, this.elementData, index, numMoved);
        }

        this.elementData[--this.size] = null;
    }

    /**
     * Checks if the given index is in range. If not, throws an appropriate runtime exception. This
     * method does *not* check if the index is negative: It is always used immediately prior to an
     * array access, which throws an ArrayIndexOutOfBoundsException if index is negative.
     */
    private void rangeCheck(int index)
    {
	if (index >= this.size)
        {
	    throw new IndexOutOfBoundsException("Index: " + index + ", Size: " + this.size);
        }
    }

    /**
     * Trims the capacity of this <tt>ArrayList</tt> instance to be the
     * list's current size.  An application can use this operation to minimize
     * the storage of an <tt>ArrayList</tt> instance.
     */
    public void trimToSize()
    {
	this.modCount++;
	int oldCapacity = this.elementData.length;
	if (this.size < oldCapacity)
        {
            this.elementData = Arrays.copyOf(this.elementData, this.size);
	}
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public Object clone()
    {
	try
        {
	    ArrayList<E> v = (ArrayList<E>)super.clone();
	    v.elementData = Arrays.copyOf(this.elementData, this.size);
	    v.modCount = 0;
	    return v;
	}
        catch (CloneNotSupportedException e)
        {
	    // this shouldn't happen, since we are Cloneable
	    throw new InternalError();
	}
    }

    /**
     * {@inheritDoc}
     */
    @Override
    protected void removeRange(int fromIndex, int toIndex)
    {
	this.modCount++;
	int numMoved = this.size - toIndex;
        System.arraycopy(this.elementData, toIndex, this.elementData, fromIndex, numMoved);

	// Let gc do its work
	int newSize = this.size - (toIndex - fromIndex);
	while (this.size != newSize)
        {
	    this.elementData[--this.size] = null;
        }
    }

    /**
     * Save the state of the <tt>ArrayList</tt> instance to a stream (that
     * is, serialize it).
     *
     * @serialData The length of the array backing the <tt>ArrayList</tt>
     *             instance is emitted (int), followed by all of its elements
     *             (each an <tt>Object</tt>) in the proper order.
     */
    private void writeObject(java.io.ObjectOutputStream s) throws java.io.IOException
    {
	// Write out element count, and any hidden stuff
	int expectedModCount = this.modCount;
	s.defaultWriteObject();

        // Write out array length
        s.writeInt(this.elementData.length);

	// Write out all elements in the proper order.
	for (int i = 0; i < this.size; i++)
        {
            s.writeObject(this.elementData[i]);
        }

	if (this.modCount != expectedModCount)
        {
            throw new ConcurrentModificationException();
        }

    }

    /**
     * Reconstitute the <tt>ArrayList</tt> instance from a stream (that is,
     * deserialize it).
     */
    private void readObject(java.io.ObjectInputStream s) throws java.io.IOException, ClassNotFoundException
    {
	// Read in size, and any hidden stuff
	s.defaultReadObject();

        // Read in array length and allocate array
        int arrayLength = s.readInt();
        Object[] a = this.elementData = new Object[arrayLength];

	// Read in all elements in the proper order.
	for (int i = 0; i < this.size; i++)
        {
            a[i] = s.readObject();
        }
    }
}
