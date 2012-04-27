package HW11;

/**
 * Represents a linked list.
 * 
 * @author Jake Petroules
 * @course CS-185-01
 * @filename LinkedList.java
 */
public class LinkedList
{
	/**
	 * Pointer to the beginning of the list.
	 */
	private NodeBase list;
	
	/**
	 * Initializes a new instance of the {@link LinkedList} class.
	 */
	public LinkedList()
	{
	}
	
	public void addFront(NodeBase node)
	{
		if (this.list == null)
		{
			this.list = node;
		}
		else
		{
			node.setNext(this.list);
			this.list = node;
		}
	}
	
	public void addEnd(NodeBase node)
	{
		if (this.list == null)
		{
			this.list = node;
		}
		else
		{
			NodeBase current = this.list;
			while (current.hasNext())
			{
				current = current.next();
			}
			
			current.setNext(node);
		}
	}
	
	public String toString()
	{
		if (this.list == null)
		{
			return "Empty linked list.\n";
		}
		else
		{
			String temp = "Start of Linked List\n";
			
			NodeBase current = this.list;
			temp += current;
			while (current.hasNext())
			{
				current = current.next();
				temp += current;
			}
			
			return temp + "End of Linked List\n";
		}
	}
}
