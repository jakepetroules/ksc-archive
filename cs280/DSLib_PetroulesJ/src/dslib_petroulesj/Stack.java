package dslib_petroulesj;

import java.util.EmptyStackException;

/**
 * Provides equivalent functionality to the standard {@link java.util.Stack{E}} class.
 *
 * This class is written in such a way (implements the same interfaces) that it could be a drop-in
 * replacement for {@link java.util.Stack{E}} since this class is pointless as it already exists
 * in the standard library.
 *
 * @author Jake Petroules
 */
public class Stack<E> extends ArrayList<E>
{
    /**
     * use serialVersionUID from JDK 1.0.2 for interoperability
     */
    private static final long serialVersionUID = 1224463164541339165L + 7742;

    /**
     * Creates an empty Stack.
     */
    public Stack()
    {
    }

    /**
     * @see java.util.Stack#push
     */
    public E push(E item)
    {
	this.add(item);
	return item;
    }

    /**
     * @see java.util.Stack#pop
     */
    public synchronized E pop()
    {
	E obj;
	int len = this.size();

	obj = this.peek();
	this.remove(len - 1);

	return obj;
    }

    /**
     * @see java.util.Stack#peek
     */
    public synchronized E peek()
    {
	int len = this.size();
	if (len == 0)
        {
	    throw new EmptyStackException();
        }

	return this.get(len - 1);
    }

    /**
     * @see java.util.Stack#empty
     */
    public boolean empty()
    {
	return this.size() == 0;
    }

    /**
     * @see java.util.Stack#search
     */
    public synchronized int search(Object o)
    {
	int i = this.lastIndexOf(o);

	if (i >= 0)
        {
	    return this.size() - i;
	}

	return -1;
    }
}
