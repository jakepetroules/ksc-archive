package HW12;

/**
 * Represents a linked list node.
 * 
 * @author Jake Petroules
 * @course CS-185-01
 * @filename NodeBase.java
 */
public abstract class NodeBase
{
	/**
	 * The reference to the next node in the list.
	 */
	private NodeBase next;
	
	/**
	 * Initializes a new instance of the {@link NodeBase} class.
	 */
	protected NodeBase()
	{
	}

	/**
	 * Gets the reference to the next node in the list.
	 * @return The reference to the next node in the list.
	 */
	public NodeBase next()
	{
		return this.next;
	}

	/**
	 * Sets the reference to the next node in the list.
	 * @param next The reference to the next node in the list.
	 */
	public void setNext(NodeBase next)
	{
		this.next = next;
	}
	
	/**
	 * Gets a value indicating whether there is a next item in the list.
	 * @return A value indicating whether there is a next item in the list.
	 */
	public boolean hasNext()
	{
		return this.next != null;
	}
}
