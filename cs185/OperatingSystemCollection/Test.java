package OperatingSystemCollection;

public class Test
{
	private static OperatingSystemCollection coll = new OperatingSystemCollection(); 
	
	public static void main(String[] args)
	{
		populate();
		validateSize(7);
		print();
		
		OperatingSystem os = new OperatingSystem(); 
		
		coll.insert(os, 0);
		validateSize(8);
		print();
		
		OperatingSystem os2 = coll.remove(os);
		if (os != os2)
		{
			System.out.println("Removed OS must match the argument to remove().");
			throw new IllegalArgumentException();
		}
		
		validateSize(7);
		print();
		
		coll.removeAt(coll.size() - 1);
		validateSize(6);
		print();
	}
	
	public static void print()
	{
		System.out.println(coll);
	}
	
	public static void populate()
	{
		OperatingSystem sys1 = new OperatingSystem("Microsoft", "Windows", "6", "Vista");
		OperatingSystem sys2 = new OperatingSystem("Apple", "Macintosh", "10.5", "Leopard");
		OperatingSystem sys3 = new OperatingSystem("Microsoft", "Windows", "5", "XP");
		OperatingSystem sys4 = new OperatingSystem();
		OperatingSystem sys5 = new OperatingSystem("Petroules Enterprises", "Pneumonoultramicroscopicsilicovolcanoconiosis", "1", "Dihydrogen Monoxide");
		
		coll.add(sys1);
		coll.add(sys2);
		coll.add(sys3);
		coll.add(sys4);
		coll.add("Apple", "Macintosh", "10.6", "Snow Leopard");
		coll.add("Canonical", "Ubuntu Linux", "9.1", "Karmic Koala");
		coll.add(sys5);
	}
	
	public static void validateSize(int size)
	{
		if (coll.size() != size)
		{
			System.out.println("Incorrect collection size. Expected " + size + ", got " + coll.size() + ".");
			throw new IllegalArgumentException();
		}
	}
}
