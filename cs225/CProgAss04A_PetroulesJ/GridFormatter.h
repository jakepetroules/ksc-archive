/* 
 * File:   GridFormatter.h
 * Author: Jake Petroules
 *
 * Created on February 22, 2011, 11:21 AM
 */

#ifndef GRIDFORMATTER_H
#define	GRIDFORMATTER_H

#include <string>
#include <vector>

using namespace std;

/*
 * Formats data in a tabular format for console output or another fixed-width medium.
 */

class GridFormatter
{
public:
    GridFormatter(int columns);
    GridFormatter(const vector<string> headers);
    virtual ~GridFormatter();
    int columnCount() const;
    int padding() const;
    void setPadding(int padding);
    string nullDisplayText() const;
    void setNullDisplayText(string text);
    bool isUpperCaseHeaders() const;
    void setUpperCaseHeaders(bool upperCaseHeaders);
    const vector<string> header() const;
    void setHeader(const vector<string> headers);
    void addRow(const vector<string> data);
    string toString() const;
private:
    void appendWithPadding(string &builder, string data, int maxFieldLength) const;

    /*
     * The number of columns in each row of the table.
     */
    int m_columnCount;

    /*
     * An list of the headings for each column in the table.
     */
    vector<string> m_header;

    /*
     * A list of the rows in the table, where each row is an
     * Object array, where each element in the array is a cell
     * in the table.
     */
    vector< vector<string> > m_rows;

    /*
     * The minimum number of spaces between each column.
     */
    int m_padding;

    /*
     * The text to display in place of a null string in any cell.
     */
    string m_nullDisplayText;

    /*
     * Whether to print upper case headers.
     */
    bool m_upperCaseHeaders;
};

#endif	/* GRIDFORMATTER_H */

