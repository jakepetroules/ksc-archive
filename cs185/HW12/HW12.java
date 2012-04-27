package HW12;

import java.io.*;
import java.util.*;

/**
 * Demonstrates linked lists.
 * 
 * @author Jake Petroules
 * @course CS-185-01
 * @filename HW12.java
 */
public class HW12
{
	public static void main(String[] args) throws IOException
	{
		LinkedList list = new LinkedList();
		
		Scanner scan = new Scanner(new File("HW12in.txt"));
		FileOutputStream out = new FileOutputStream("HW12out.txt");
		PrintWriter writer = new PrintWriter(out);
		writer.println("Linked List Program Report - CS185-1 - HW12\n");
		writer.println(list);
		
		while (scan.hasNextLine())
		{
			int code = scan.nextInt();
			NodeBase node = new PersonNode(scan.next(), scan.nextInt());
			
			if (code == 1)
			{
				list.addFront(node);
				writer.println("The following was added to the beginning of the linked list: " + node);
			}
			else if (code == 2)
			{
				list.addEnd(node);
				writer.println("The following was added to the end of the linked list: " + node);
			}
			else if (code == 3)
			{
				NodeBase deletedNode = list.deleteFront();
				writer.println("The following was deleted from the beginning of the linked list: " + deletedNode);
			}
			else if (code == 4)
			{
				NodeBase deletedNode = list.deleteEnd();
				writer.println("The following was deleted from the end of the linked list: " + deletedNode);
			}
			
			writer.println(list);
		}
		
		scan.close();
		writer.close();
	}
}
