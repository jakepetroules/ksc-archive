package OperatingSystemCollection;

import java.util.*;

/**
 * Formats data in a tabular format for console output or another fixed-width medium.
 * @author Jake Petroules
 * @course CS-185-01
 * @filename GridFormatter.java
 */
public final class GridFormatter
{
	/**
	 * The number of columns in each row of the table.
	 */
	private final int columnCount;
	
	/**
	 * An array of the headings for each column in the table.
	 */
	private Object[] header;
	
	/**
	 * A list of the rows in the table, where each row is an
	 * Object array, where each element in the array is a cell
	 * in the table.
	 */
	private List<Object[]> rows;
	
	/**
	 * The minimum number of spaces between each column.
	 */
	private int padding;
	
	/**
	 * The text to display in place of a null string in any cell.
	 */
	private String nullDisplayText;

	/**
	 * Whether to print upper case headers.
	 */
	private boolean upperCaseHeaders;
	
	/**
	 * Initializes a new instance of the {@link GridFormatter} class
	 * with the specified number of columns.
	 * @param columns The number of columns in the table.
	 */
	public GridFormatter(int columns)
	{
		if (columns <= 0)
		{
			throw new IllegalArgumentException("columns must be greater than 0.");
		}
		
		this.columnCount = columns;
		this.rows = new ArrayList<Object[]>();
		this.setPadding(2);
		this.setNullDisplayText("");
		this.setUpperCaseHeaders(true);
	}
	
	/**
	 * Initializes a new instance of the {@link GridFormatter} class
	 * with the specified headings.
	 * @param headers The headings for each column in the table.
	 */
	public GridFormatter(Object... headers)
	{
		this(headers.length);
		this.setHeader(headers);
	}
	
	/**
	 * Gets the number of columns in each row of the table.
	 * @return The number of columns in each row of the table.
	 */
	public int getColumnCount()
	{
		return this.columnCount;
	}
	
	/**
	 * Gets the minimum number of spaces between each column. The default is 2.
	 * @return The minimum number of spaces between each column.
	 */
	public int getPadding()
	{
		return this.padding;
	}
	
	/**
	 * Sets the minimum number of spaces between each column.
	 * @param padding The minimum number of spaces between each column.
	 */
	public void setPadding(int padding)
	{
		this.padding = padding;
	}
	
	/**
	 * Gets the text to display in place of a null string in any cell. The default is an empty string.
	 * @return The text to display in place of a null string in any cell.
	 */
	public String getNullDisplayText()
	{
		return this.nullDisplayText;
	}
	
	/**
	 * Sets the text to display in place of a null string in any cell.
	 * @param nullDisplayText The text to display in place of a null string in any cell.
	 */
	public void setNullDisplayText(String nullDisplayText)
	{
		this.nullDisplayText = nullDisplayText;
	}
	
	/**
	 * Gets a value indicating whether to print upper-case headers. The default is true.
	 * @return Whether to print upper-case headers.
	 */
	public boolean isUpperCaseHeaders()
	{
		return this.upperCaseHeaders;
	}
	
	/**
	 * Gets a value indicating whether to print upper-case headers.
	 * @param upperCaseHeaders Whether to print upper-case headers.
	 */
	public void setUpperCaseHeaders(boolean upperCaseHeaders)
	{
		this.upperCaseHeaders = upperCaseHeaders;
	}
	
	/**
	 * Gets the header of the table.
	 * @return The header of the table.
	 */
	public Object[] getHeader()
	{
		return this.header;
	}
	
	/**
	 * Sets the header of the table.
	 * @param args An array of objects representing each header in the table,
	 * from left to right. The number of elements in the array must be equal
	 * to the number of columns in the table.
	 */
	public void setHeader(Object... args)
	{
		if (args.length != this.getColumnCount())
		{
			throw new IllegalArgumentException("Length of argument list must be equal to the column count.");
		}
		
		for (int i = 0; i < args.length; i++)
		{
			if (args[i] == null || args[i].toString() == "")
			{
				throw new IllegalArgumentException("Header labels cannot be null or be the empty string.");
			}
		}
		
		this.header = args;
	}
	
	/**
	 * Adds a row to the table.
	 * @param args An array of objects representing each cell/field in the row,
	 * from left to right. The number of elements in the array must be equal
	 * to the number of columns in the table.
	 */
	public void addRow(Object... args)
	{
		if (args.length != this.getColumnCount())
		{
			throw new IllegalArgumentException("Length of argument list must be equal to the column count.");
		}
		
		this.rows.add(args);
	}
	
	/**
	 * Returns the data contained in the {@link GridFormatter}
	 * as a table formatted for display in the console or
	 * another fixed-width medium.
	 */
	public String toString()
	{
		// Create an array to store the longest lengths of each column
		int[] maxColumnLengths = new int[this.getColumnCount()];
		
		// We'll initialize this array with the header lengths,
		// if there is a header. We need two arrays so we can
		// later determine how many tabs to print after each
		// header label
		if (this.getHeader() != null)
		{
			for (int i = 0; i < this.getColumnCount(); i++)
			{
				int headerLength = this.getHeader()[i].toString().length() + this.getPadding();
				maxColumnLengths[i] = headerLength;
			}
		}
		
		// Loop through each row in the table to determine
		// the maximum length for each column
		for (int i = 0; i < this.rows.size(); i++)
		{
			// Loop through each column in the table, determining
			// whether to update the max for each one
			for (int j = 0; j < this.getColumnCount(); j++)
			{
				// Get the row we're working with
				Object[] row = this.rows.get(i);
				
				// Get the column data length - initially it's zero,
				// and if we determine that is is not null, we get
				// its length and set that
				int columnDataLength = this.getNullDisplayText().length() + this.getPadding();
				if (row[j] != null)
				{
					columnDataLength = row[j].toString().length() + this.getPadding();
				}
				
				// If the column data in this row is longer than the
				// current maximum corresponding column length, replace it
				if (columnDataLength > maxColumnLengths[j])
				{
					maxColumnLengths[j] = columnDataLength;
				}
			}
		}
		
		// Now that we've determined the maximum lengths required
		// for each column, we can begin printing the table, but
		// first we should determine the max length of any row
		int sumOfColumnLengths = 0;
		for (int i = 0; i < maxColumnLengths.length; i++)
		{
			sumOfColumnLengths += maxColumnLengths[i];
		}
		
		// We use StringBuilder instead of String because it is
		// much, much faster when continually adding data and
		// to make it even more efficient we will multiply the
		// number of rows in the formatter, by the sum of the
		// column lengths (max length of any row) so that we only
		// ever make one allocation of StringBuilder's internal
		// character array for maximum efficiency
		StringBuilder returnData = new StringBuilder(this.rows.size() * sumOfColumnLengths);
		
		// Start with the header
		for (int i = 0; i < this.getColumnCount(); i++)
		{
			Object header = this.getHeader()[i];
			if (this.isUpperCaseHeaders())
			{
				header = header.toString().toUpperCase();
			}
			
			this.appendWithPadding(returnData, header, maxColumnLengths[i]);
		}
		
		// Add a newline after the header
		returnData.append("\n");
		
		for (int i = 0; i < this.rows.size(); i++)
		{
			for (int j = 0; j < this.getColumnCount(); j++)
			{
				this.appendWithPadding(returnData, this.rows.get(i)[j], maxColumnLengths[j]);
			}
			
			// Add a newline after each row
			returnData.append("\n");
		}
		
		return returnData.toString();
	}
	
	/**
	 * Adds an object's string representation to the end of a {@link StringBuilder}, additionally appending
	 * {@code ceiling((maxFieldLength - dataLength) / 4)} tab characters.
	 * @param builder The {@link StringBuilder} to add the data to.
	 * @param data The data to add to {@link builder}.
	 * @param maxFieldLength The desired character length of the field to add.
	 */
	private void appendWithPadding(StringBuilder builder, Object data, int maxFieldLength)
	{
		// Add the data to the field if it's not null,
		// because we don't actually want "null" printed
		if (data != null)
		{
			builder.append(data);
		}
		else
		{
			builder.append(this.getNullDisplayText());
		}
		
		// Determine the number of spaces we'd need
		int spaces = maxFieldLength - (data != null ? data : this.getNullDisplayText()).toString().length();
		
		// Append all the spaces
		for (int i = 0; i < spaces; i++)
		{
			builder.append(" ");
		}
	}
}
