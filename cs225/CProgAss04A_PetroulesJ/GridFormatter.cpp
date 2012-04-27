/* 
 * File:   GridFormatter.cpp
 * Author: Jake Petroules
 * 
 * Created on February 22, 2011, 11:21 AM
 */

#include "GridFormatter.h"
#include <cstdarg>
#include <algorithm>
#include <cctype>

GridFormatter::GridFormatter(int columns)
    : m_columnCount(columns), m_padding(2), m_nullDisplayText(""), m_upperCaseHeaders(true)
{
    if (columns <= 0)
    {
        // columns must be greater than 0.
        throw new exception();
    }
}

GridFormatter::GridFormatter(const vector<string> headers)
    : m_columnCount(headers.size()), m_padding(2), m_nullDisplayText(""), m_upperCaseHeaders(true)
{
    if (this->m_columnCount <= 0)
    {
        // columns must be greater than 0.
        throw new exception();
    }
    
    this->setHeader(headers);
}

GridFormatter::~GridFormatter()
{
}

int GridFormatter::columnCount() const
{
    return this->m_columnCount;
}

int GridFormatter::padding() const
{
    return this->m_padding;
}

void GridFormatter::setPadding(int padding)
{
    this->m_padding = padding;
}

string GridFormatter::nullDisplayText() const
{
    return this->m_nullDisplayText;
}

void GridFormatter::setNullDisplayText(string text)
{
    this->m_nullDisplayText = text;
}

bool GridFormatter::isUpperCaseHeaders() const
{
    return this->m_upperCaseHeaders;
}

void GridFormatter::setUpperCaseHeaders(bool upperCaseHeaders)
{
    this->m_upperCaseHeaders = upperCaseHeaders;
}

const vector<string> GridFormatter::header() const
{
    return this->m_header;
}

void GridFormatter::setHeader(const vector<string> headers)
{
    if (headers.size() != this->columnCount())
    {
        // Length of argument list must be equal to the column count.
        throw new exception();
    }

    for (int i = 0; i < headers.size(); i++)
    {
        if (headers.at(i) == "")
        {
            // Header labels cannot be null or be the empty string.
            throw new exception();
        }
    }

    this->m_header = headers;
}

void GridFormatter::addRow(const vector<string> data)
{
    if (data.size() != this->columnCount())
    {
        // Length of argument list must be equal to the column count.
        throw new exception();
    }

    this->m_rows.push_back(data);
}

string GridFormatter::toString() const
{
    // Create an array to store the longest lengths of each column
    int maxColumnLengths[this->columnCount()];

    // We'll initialize this array with the header lengths,
    // if there is a header. We need two arrays so we can
    // later determine how many tabs to print after each
    // header label
    if (this->header().size() > 0)
    {
        for (int i = 0; i < this->columnCount(); i++)
        {
            int headerLength = this->header()[i].length() + this->padding();
            maxColumnLengths[i] = headerLength;
        }
    }

    // Loop through each row in the table to determine
    // the maximum length for each column
    for (int i = 0; i < this->m_rows.size(); i++)
    {
        // Loop through each column in the table, determining
        // whether to update the max for each one
        for (int j = 0; j < this->columnCount(); j++)
        {
            // Get the row we're working with
            vector<string> row = this->m_rows.at(i);

            // Get the column data length - initially it's zero,
            // and if we determine that is is not null, we get
            // its length and set that
            int columnDataLength = this->nullDisplayText().length() + this->padding();
            if (row.at(j) != "")
            {
                columnDataLength = row[j].length() + this->padding();
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
    for (int i = 0; i < this->columnCount(); i++)
    {
        sumOfColumnLengths += maxColumnLengths[i];
    }

    string returnData;

    // Start with the header
    for (int i = 0; i < this->columnCount(); i++)
    {
        string currentHeader = this->header()[i];
        if (this->isUpperCaseHeaders())
        {
            std::transform(currentHeader.begin(), currentHeader.end(), currentHeader.begin(), (int(*)(int)) std::toupper);
        }

        this->appendWithPadding(returnData, currentHeader, maxColumnLengths[i]);
    }

    // Add a newline after the header
    returnData.append("\n");

    for (int i = 0; i < this->m_rows.size(); i++)
    {
        for (int j = 0; j < this->columnCount(); j++)
        {
            this->appendWithPadding(returnData, this->m_rows.at(i)[j], maxColumnLengths[j]);
        }

        // Add a newline after each row
        returnData.append("\n");
    }

    return returnData;
}

void GridFormatter::appendWithPadding(string &builder, string data, int maxFieldLength) const
{
    // Add the data to the field if it's not null,
    // because we don't actually want "null" printed
    if (data != "")
    {
        builder.append(data);
    }
    else
    {
        builder.append(this->nullDisplayText());
    }

    // Determine the number of spaces we'd need
    string x = (data != "" ? data : this->nullDisplayText());
    int spaces = maxFieldLength - x.length();

    // Append all the spaces
    for (int i = 0; i < spaces; i++)
    {
        builder.append(" ");
    }
}