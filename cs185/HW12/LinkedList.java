package HW12;

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
	
	public NodeBase deleteFront()
	{
		if (this.list == null)
		{
			return null;
		}
		else
		{
			NodeBase front = this.list;
			this.list = this.list.next();
			front.setNext(null);
			return front;
		}
	}
	
	public NodeBase deleteEnd()
	{
		if (this.list == null)
		{
			return null;
		}
		else if (this.list.next() == null)
		{
			NodeBase node = this.list;
			this.list = null;
			return node;
		}
		else
		{
			NodeBase current = this.list;
			while (current.next().next() != null)
			{
				current = current.next();
			}
			
			NodeBase returnedNode = current.next();
			current.setNext(null);
			
			return returnedNode;
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
