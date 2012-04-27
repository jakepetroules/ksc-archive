package HW02;

/**
 * This program creates some bank accounts and requests various services.
 * 
 * @author Jake Petroules
 * @course CS-185-01
 * @filename HW02.java
 */
public class HW02
{
	public static void main(String[] args)
	{
		System.out.println("This program creates some bank accounts and requests various services.");

		Account[] accounts = new Account[5];
		accounts[0] = new Account("Ted Murphy", 72354, 102.56);
		accounts[1] = new Account("Jane Smith", 69713, 40.00);
		accounts[2] = new Account("Edward Demsey", 93757, 759.32);
		accounts[3] = new Account("Jake Petroules", 20110, 2010);
		accounts[4] = new Account("Mike Hanrahan", 101252, 0);

		double petroulesBalance = accounts[3].deposit(2300);
		System.out.println("Petroules balance after deposit: " + petroulesBalance);

		double hanrahanBalance = accounts[4].deposit(5200);
		System.out.println("Hanrahan balance after deposit: " + hanrahanBalance);

		double petroulesNewBalance = accounts[3].withdraw(2300, 1.50);
		System.out.println("Petroules balance after withdrawal: " + petroulesNewBalance);

		accounts[0].deposit(25.85);

		double smithBalance = accounts[1].deposit(500.00);
		System.out.println("Smith balance after deposit: " + smithBalance);

		System.out.println("Smith balance after withdrawal: " + accounts[1].withdraw(430.75, 1.50));

		// Print all 5 accounts before interest is added
		printAccounts(accounts);

		// Add interest to all accounts and print details again
		calculateInterest(accounts);
		System.out.println("Balances after interest:");
		printAccounts(accounts);
	}

	/**
	 * Calculates interest for the accounts.
	 * @param accounts The accounts to calculate interest for.
	 */
	private static void calculateInterest(Account[] accounts)
	{
		for (int i = 0; i < accounts.length; i++)
		{
			accounts[i].addInterest();
		}
	}

	/**
	 * Prints the accounts.
	 * @param accounts The accounts to print.
	 */
	private static void printAccounts(Account[] accounts)
	{
		for (int i = 0; i < accounts.length; i++)
		{
			System.out.println(accounts[i]);
		}
	}
}
