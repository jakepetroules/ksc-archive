package dslib_petroulesj;

import java.io.Serializable;
import java.util.AbstractSequentialList;
import java.util.Collection;
import java.util.ConcurrentModificationException;
import java.util.Deque;
import java.util.Iterator;
import java.util.List;
import java.util.ListIterator;
import java.util.NoSuchElementException;

/**
 * Provides equivalent functionality to the standard {@link java.util.LinkedList{E}} class.
 *
 * This class is written in such a way (implements the same interfaces) that it could be a drop-in
 * replacement for {@link java.util.LinkedList{E}} since this class is pointless as it already exists
 * in the standard library.
 *
 * @author Jake Petroules
 */
public class LinkedList<E> extends AbstractSequentialList<E> implements List<E>, Deque<E>, Cloneable, Serializable
{
    private transient Entry<E> header = new Entry<E>(null, null, null);
    private transient int size = 0;

    /**
     * Constructs an empty list.
     */
    public LinkedList()
    {
        this.header.next = this.header;
        this.header.previous = this.header;
    }

    /**
     * Constructs a list containing the elements of the specified
     * collection, in the order they are returned by the collection's
     * iterator.
     *
     * @param  c the collection whose elements are to be placed into this list
     * @throws NullPointerException if the specified collection is null
     */
    public LinkedList(Collection<? extends E> c)
    {
        this();
        this.addAll(c);
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public ListIterator<E> listIterator(int index)
    {
        return new ListItr(index);
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public int size()
    {
        return this.size;
    }

    /**
     * {@inheritDoc}
     */
    public void addFirst(E e)
    {
        this.addBefore(e, this.header.next);
    }

    /**
     * {@inheritDoc}
     */
    public void addLast(E e)
    {
        this.addBefore(e, this.header);
    }

    /**
     * {@inheritDoc}
     */
    public boolean offerFirst(E e)
    {
        this.addFirst(e);
        return true;
    }

    /**
     * {@inheritDoc}
     */
    public boolean offerLast(E e)
    {
        this.addLast(e);
        return true;
    }

    /**
     * {@inheritDoc}
     */
    public E removeFirst()
    {
        return this.remove(this.header.next);
    }

    /**
     * {@inheritDoc}
     */
    public E removeLast()
    {
        return this.remove(this.header.previous);
    }

    /**
     * {@inheritDoc}
     */
    public E pollFirst()
    {
        if (this.size == 0)
        {
            return null;
        }

        return this.removeFirst();
    }

    /**
     * {@inheritDoc}
     */
    public E pollLast()
    {
        if (this.size == 0)
        {
            return null;
        }

        return this.removeLast();
    }

    /**
     * {@inheritDoc}
     */
    public E getFirst()
    {
        if (this.size == 0)
        {
            throw new NoSuchElementException();
        }

	return this.header.next.element;
    }

    /**
     * {@inheritDoc}
     */
    public E getLast()
    {
        if (this.size == 0)
        {
	    throw new NoSuchElementException();
        }

	return this.header.previous.element;
    }

    /**
     * {@inheritDoc}
     */
    public E peekFirst()
    {
        if (this.size == 0)
        {
            return null;
        }

        return this.getFirst();
    }

    /**
     * {@inheritDoc}
     */
    public E peekLast()
    {
        if (this.size == 0)
        {
            return null;
        }

        return this.getLast();
    }

    /**
     * {@inheritDoc}
     */
    public boolean removeFirstOccurrence(Object o)
    {
        return this.remove(o);
    }

    /**
     * {@inheritDoc}
     */
    public boolean removeLastOccurrence(Object o)
    {
        if (o == null)
        {
            for (Entry<E> e = this.header.previous; e != this.header; e = e.previous)
            {
                if (e.element == null)
                {
                    this.remove(e);
                    return true;
                }
            }
        }
        else
        {
            for (Entry<E> e = this.header.previous; e != this.header; e = e.previous)
            {
                if (o.equals(e.element))
                {
                    this.remove(e);
                    return true;
                }
            }
        }

        return false;
    }

    /**
     * {@inheritDoc}
     */
    public boolean offer(E e)
    {
        return this.add(e);
    }

    /**
     * {@inheritDoc}
     */
    public E remove()
    {
        return this.removeFirst();
    }

    /**
     * {@inheritDoc}
     */
    public E poll()
    {
        if (this.size == 0)
        {
            return null;
        }

        return this.removeFirst();
    }

    /**
     * {@inheritDoc}
     */
    public E element()
    {
        return this.getFirst();
    }

    /**
     * {@inheritDoc}
     */
    public E peek()
    {
        if (this.size == 0)
        {
            return null;
        }

        return this.getFirst();
    }

    /**
     * {@inheritDoc}
     */
    public void push(E e)
    {
        this.addFirst(e);
    }

    /**
     * {@inheritDoc}
     */
    public E pop()
    {
        return this.removeFirst();
    }

    /**
     * {@inheritDoc}
     */
    public Iterator<E> descendingIterator()
    {
        return new DescendingIterator();
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public boolean contains(Object o)
    {
        return this.indexOf(o) != -1;
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public boolean add(E e)
    {
	this.addBefore(e, this.header);
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
            for (Entry<E> e = this.header.next; e != this.header; e = e.next)
            {
                if (e.element == null)
                {
                    this.remove(e);
                    return true;
                }
            }
        }
        else
        {
            for (Entry<E> e = this.header.next; e != this.header; e = e.next)
            {
                if (o.equals(e.element))
                {
                    this.remove(e);
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
    public boolean addAll(Collection<? extends E> c)
    {
        return this.addAll(this.size, c);
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public boolean addAll(int index, Collection<? extends E> c)
    {
        if (index < 0 || index > this.size)
        {
            throw new IndexOutOfBoundsException("Index: " + index + ", Size: " + this.size);
        }

        Object[] a = c.toArray();
        int numNew = a.length;
        if (numNew == 0)
        {
            return false;
        }

	this.modCount++;

        Entry<E> successor = (index == this.size ? this.header : entry(index));
        Entry<E> predecessor = successor.previous;
	for (int i=0; i<numNew; i++)
        {
            Entry<E> e = new Entry<E>((E)a[i], successor, predecessor);
            predecessor.next = e;
            predecessor = e;
        }

        successor.previous = predecessor;

        this.size += numNew;
        return true;
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public void clear()
    {
        Entry<E> e = this.header.next;
        while (e != this.header)
        {
            Entry<E> next = e.next;
            e.next = e.previous = null;
            e.element = null;
            e = next;
        }

        this.header.next = this.header;
        this.header.previous = this.header;
        this.size = 0;
	this.modCount++;
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public E get(int index)
    {
        return this.entry(index).element;
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public E set(int index, E element)
    {
        Entry<E> e = this.entry(index);
        E oldVal = e.element;
        e.element = element;
        return oldVal;
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public void add(int index, E element)
    {
        this.addBefore(element, (index == this.size ? this.header : this.entry(index)));
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public E remove(int index)
    {
        return this.remove(this.entry(index));
    }

    /**
     * Returns the indexed entry.
     */
    private Entry<E> entry(int index)
    {
        if (index < 0 || index >= this.size)
        {
            throw new IndexOutOfBoundsException("Index: " + index + ", Size: " + this.size);
        }

        Entry<E> e = this.header;
        if (index < (this.size >> 1))
        {
            for (int i = 0; i <= index; i++)
            {
                e = e.next;
            }
        }
        else
        {
            for (int i = this.size; i > index; i--)
            {
                e = e.previous;
            }
        }

        return e;
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public int indexOf(Object o)
    {
        int index = 0;
        if (o == null)
        {
            for (Entry e = this.header.next; e != this.header; e = e.next)
            {
                if (e.element == null)
                {
                    return index;
                }

                index++;
            }
        }
        else
        {
            for (Entry e = this.header.next; e != this.header; e = e.next)
            {
                if (o.equals(e.element))
                {
                    return index;
                }

                index++;
            }
        }

        return -1;
    }

    /**
     * {@inheritDoc}
     */
    public int lastIndexOf(Object o)
    {
        int index = this.size;
        if (o == null)
        {
            for (Entry e = this.header.previous; e != this.header; e = e.previous)
            {
                index--;
                if (e.element == null)
                {
                    return index;
                }
            }
        }
        else
        {
            for (Entry e = this.header.previous; e != this.header; e = e.previous)
            {
                index--;
                if (o.equals(e.element))
                {
                    return index;
                }
            }
        }

        return -1;
    }

    private class ListItr implements ListIterator<E>
    {
	private Entry<E> lastReturned = LinkedList.this.header;
	private Entry<E> next;
	private int nextIndex;
	private int expectedModCount = LinkedList.this.modCount;

	ListItr(int index)
        {
	    if (index < 0 || index > LinkedList.this.size)
            {
		throw new IndexOutOfBoundsException("Index: " + index + ", Size: " + LinkedList.this.size);
            }

	    if (index < (LinkedList.this.size >> 1))
            {
		this.next = LinkedList.this.header.next;
		for (this.nextIndex = 0; this.nextIndex < index; this.nextIndex++)
                {
		    this.next = this.next.next;
                }
	    }
            else
            {
		this.next = LinkedList.this.header;
		for (this.nextIndex = LinkedList.this.size; this.nextIndex > index; this.nextIndex--)
                {
		    this.next = this.next.previous;
                }
	    }
	}

	public boolean hasNext()
        {
	    return this.nextIndex != LinkedList.this.size;
	}

	public E next()
        {
	    this.checkForComodification();
	    if (this.nextIndex == LinkedList.this.size)
            {
		throw new NoSuchElementException();
            }

	    this.lastReturned = this.next;
	    this.next = this.next.next;
	    this.nextIndex++;
	    return this.lastReturned.element;
	}

	public boolean hasPrevious()
        {
	    return this.nextIndex != 0;
	}

	public E previous()
        {
	    if (this.nextIndex == 0)
            {
		throw new NoSuchElementException();
            }

	    this.lastReturned = this.next.previous;
            this.next = this.next.previous;
	    this.nextIndex--;
	    this.checkForComodification();
	    return lastReturned.element;
	}

	public int nextIndex()
        {
	    return this.nextIndex;
	}

	public int previousIndex()
        {
	    return this.nextIndex - 1;
	}

	public void remove()
        {
            this.checkForComodification();
            Entry<E> lastNext = this.lastReturned.next;
            try
            {
                LinkedList.this.remove(this.lastReturned);
            }
            catch (NoSuchElementException e)
            {
                throw new IllegalStateException();
            }

	    if (this.next == this.lastReturned)
            {
                this.next = lastNext;
            }
            else
            {
		this.nextIndex--;
            }

	    this.lastReturned = LinkedList.this.header;
	    this.expectedModCount++;
	}

	public void set(E e)
        {
	    if (this.lastReturned == LinkedList.this.header)
            {
		throw new IllegalStateException();
            }

	    this.checkForComodification();
	    this.lastReturned.element = e;
	}

	public void add(E e)
        {
	    this.checkForComodification();
	    this.lastReturned = LinkedList.this.header;
	    LinkedList.this.addBefore(e, this.next);
	    this.nextIndex++;
	    this.expectedModCount++;
	}

	final void checkForComodification()
        {
	    if (LinkedList.this.modCount != this.expectedModCount)
		throw new ConcurrentModificationException();
	}
    }

    private static class Entry<E>
    {
	E element;
	Entry<E> next;
	Entry<E> previous;

	Entry(E element, Entry<E> next, Entry<E> previous)
        {
	    this.element = element;
	    this.next = next;
	    this.previous = previous;
	}
    }

    private Entry<E> addBefore(E e, Entry<E> entry)
    {
	Entry<E> newEntry = new Entry<E>(e, entry, entry.previous);
	newEntry.previous.next = newEntry;
	newEntry.next.previous = newEntry;
	this.size++;
	this.modCount++;
	return newEntry;
    }

    private E remove(Entry<E> e)
    {
	if (e == this.header)
        {
	    throw new NoSuchElementException();
        }

        E result = e.element;
	e.previous.next = e.next;
	e.next.previous = e.previous;
        e.next = e.previous = null;
        e.element = null;
	this.size--;
	this.modCount++;
        return result;
    }

    /**
     * Adapter to provide descending iterators via ListItr.previous
     */
    private class DescendingIterator implements Iterator
    {
        final ListItr itr = new ListItr(LinkedList.this.size());

	public boolean hasNext()
        {
	    return this.itr.hasPrevious();
	}

	public E next()
        {
            return this.itr.previous();
        }

	public void remove()
        {
            this.itr.remove();
        }
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public Object clone()
    {
        LinkedList<E> clone = null;
	try
        {
	    clone = (LinkedList<E>)super.clone();
	}
        catch (CloneNotSupportedException e)
        {
	    throw new InternalError();
	}

        // Put clone into "virgin" state
        clone.header = new Entry<E>(null, null, null);
        clone.header.next = clone.header.previous = clone.header;
        clone.size = 0;
        clone.modCount = 0;

        // Initialize clone with our elements
        for (Entry<E> e = this.header.next; e != this.header; e = e.next)
        {
            clone.add(e.element);
        }

        return clone;
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public Object[] toArray()
    {
	Object[] result = new Object[this.size];
        int i = 0;
        for (Entry<E> e = this.header.next; e != this.header; e = e.next)
        {
            result[i++] = e.element;
        }

	return result;
    }

    /**
     * {@inheritDoc}
     */
    @Override
    public <T> T[] toArray(T[] a)
    {
        if (a.length < this.size)
        {
            a = (T[])java.lang.reflect.Array.newInstance(a.getClass().getComponentType(), this.size);
        }

        int i = 0;
	Object[] result = a;
        for (Entry<E> e = this.header.next; e != this.header; e = e.next)
        {
            result[i++] = e.element;
        }

        if (a.length > this.size)
        {
            a[size] = null;
        }

        return a;
    }

    private static final long serialVersionUID = 876323262645176354L + 7742;

    /**
     * Save the state of this <tt>LinkedList</tt> instance to a stream (that
     * is, serialize it).
     *
     * @serialData The size of the list (the number of elements it
     *             contains) is emitted (int), followed by all of its
     *             elements (each an Object) in the proper order.
     */
    private void writeObject(java.io.ObjectOutputStream s) throws java.io.IOException
    {
	// Write out any hidden serialization magic
	s.defaultWriteObject();

        // Write out size
        s.writeInt(this.size);

	// Write out all elements in the proper order.
        for (Entry e = this.header.next; e != this.header; e = e.next)
        {
            s.writeObject(e.element);
        }
    }

    /**
     * Reconstitute this <tt>LinkedList</tt> instance from a stream (that is deserialize it).
     */
    private void readObject(java.io.ObjectInputStream s) throws java.io.IOException, ClassNotFoundException
    {
	// Read in any hidden serialization magic
	s.defaultReadObject();

        // Read in size
        int size = s.readInt();

        // Initialize header
        this.header = new Entry<E>(null, null, null);
        this.header.next = this.header;
        this.header.previous = this.header;

	// Read in all elements in the proper order.
	for (int i=0; i<size; i++)
        {
            this.addBefore((E)s.readObject(), this.header);
        }
    }
}
