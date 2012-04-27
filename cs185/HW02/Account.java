package HW02;

import java.text.NumberFormat;

/**
 * Represents a bank account with basic services such as deposit and withdraw.
 * 
 * @author Jake Petroules
 * @course CS-185-01
 * @filename Account.java
 */
public class Account
{
	/**
	 * The interest rate - 3.5%.
	 */
	private final double RATE = 0.035;

	/**
	 * The account number.
	 */
	private long acctNumber;

	/**
	 * The account balance.
	 */
	private double balance;

	/**
	 * The name of the account holder.
	 */
	private String name;

	/**
	 * Sets up the account by defining its owner, account number, and initial balance.
	 * @param owner The name of the account holder.
	 * @param account The account number.
	 * @param initial The initial account balance.
	 */
	public Account(String owner, long account, double initial)
	{
		this.name = owner;
		this.acctNumber = account;
		this.balance = initial;
	}

	/**
	 * Deposits the specified amount into the account and returns the new balance.
	 * @param amount The amount to deposit.
	 * @return The new balance.
	 */
	public double deposit(double amount)
	{
		return this.balance += amount;
	}

	/**
	 * Withdraws the specified amount from the account, applies the fee and returns the new balance.
	 * @param amount The amount to withdraw.
	 * @param fee The withdrawal fee.
	 * @return The new balance.
	 */
	public double withdraw(double amount, double fee)
	{
		return this.balance = this.balance - amount - fee;
	}

	/**
	 * Adds interest to the account and returns the new balance.
	 * @return The new balance.
	 */
	public double addInterest()
	{
		return this.balance += (this.balance * this.RATE);
	}

	/**
	 * Returns the current balance of the account.
	 * @return The current balance of the account.
	 */
	public double getBalance()
	{
		return this.balance;
	}

	/**
	 * Returns a one-line description of the account as a string.
	 * @return A string representation of the account.
	 */
	public String toString()
	{
		NumberFormat fmt = NumberFormat.getCurrencyInstance();
		NumberFormat acctNumFormat = NumberFormat.getIntegerInstance();
		acctNumFormat.setMinimumIntegerDigits(6);
		acctNumFormat.setGroupingUsed(false);

		return acctNumFormat.format(this.acctNumber) + "\t" + this.name + "\t" + fmt.format(this.balance);
	}
}
