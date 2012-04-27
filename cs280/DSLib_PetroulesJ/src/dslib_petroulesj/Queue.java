package dslib_petroulesj;

import java.util.Collection;
import java.util.Iterator;
import java.util.NoSuchElementException;

/**
 * Provides equivalent functionality to the standard {@link java.util.Queue{E}} class.
 *
 * This class is written in such a way (implements the same interfaces) that it could be a drop-in
 * replacement for {@link java.util.Queue{E}} since this class is pointless as it already exists
 * in the standard library.
 *
 * @author Jake Petroules
 */
public class Queue<T> implements java.util.Queue<T>
{
    private ArrayList<T> elements;

    /**
     * Initializes a new instance of the {@link Queue} class.
     */
    public Queue()
    {
        this.elements = new ArrayList<T>();
    }

    /**
     * {@inheritDoc}
     */
    public boolean add(T e)
    {
        this.elements.add(e);
        return true;
    }

    /**
     * {@inheritDoc}
     */
    public boolean offer(T e)
    {
        return this.add(e);
    }

    /**
     * {@inheritDoc}
     */
    public T remove()
    {
        if (this.elements.isEmpty())
        {
            throw new NoSuchElementException();
        }

        return this.elements.remove(0);
    }

    /**
     * {@inheritDoc}
     */
    public T poll()
    {
        try
        {
            return this.remove();
        }
        catch (NoSuchElementException ex)
        {
            return null;
        }
    }

    /**
     * {@inheritDoc}
     */
    public T element()
    {
        try
        {
            return this.peek();
        }
        catch (NoSuchElementException ex)
        {
            return null;
        }
    }

    /**
     * {@inheritDoc}
     */
    public T peek()
    {
        if (this.elements.isEmpty())
        {
            throw new NoSuchElementException();
        }

        return this.elements.get(0);
    }

    /**
     * {@inheritDoc}
     */
    public int size()
    {
        return this.elements.size();
    }

    /**
     * {@inheritDoc}
     */
    public boolean isEmpty()
    {
        return this.elements.isEmpty();
    }

    /**
     * {@inheritDoc}
     */
    public boolean contains(Object o)
    {
        for (int i = 0; i < this.elements.size(); i++)
        {
            if (this.elements.get(i) == o)
            {
                return true;
            }
        }

        return false;
    }

    /**
     * {@inheritDoc}
     */
    public Iterator<T> iterator()
    {
        throw new UnsupportedOperationException("Not supported yet.");
    }

    /**
     * {@inheritDoc}
     */
    public Object[] toArray()
    {
        return this.elements.toArray();
    }

    /**
     * {@inheritDoc}
     */
    public <T> T[] toArray(T[] a)
    {
        return this.elements.toArray(a);
    }

    /**
     * {@inheritDoc}
     */
    public boolean remove(Object o)
    {
        return this.elements.remove(o);
    }

    /**
     * {@inheritDoc}
     */
    public boolean containsAll(Collection<?> c)
    {
        return this.elements.containsAll(c);
    }

    /**
     * {@inheritDoc}
     */
    public boolean addAll(Collection<? extends T> c)
    {
        throw new UnsupportedOperationException("Not supported yet.");
    }

    /**
     * {@inheritDoc}
     */
    public boolean removeAll(Collection<?> c)
    {
        throw new UnsupportedOperationException("Not supported yet.");
    }

    /**
     * {@inheritDoc}
     */
    public boolean retainAll(Collection<?> c)
    {
        throw new UnsupportedOperationException("Not supported yet.");
    }

    /**
     * {@inheritDoc}
     */
    public void clear()
    {
        this.elements.clear();
    }
}
