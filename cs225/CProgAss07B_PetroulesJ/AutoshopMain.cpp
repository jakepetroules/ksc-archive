#include <cstdlib>
#include <vector>
#include <iostream>
#include <limits>
#include "Salesman.h"
#include "SalesLog.h"

using namespace std;

bool findSalesman(int id, const vector<Salesman*> &salesmen);
bool findSalesLog(int id, const vector<SalesLog*> &salesLogs);

int main(int argc, char** argv)
{
    vector<Salesman*> salesmen;
    vector<SalesLog*> salesLogs;

    do
    {
        cout << "Welcome to Autoshop" << endl;
        cout << "Enter an option to continue: " << endl;
        cout << "(1) Add salesman" << endl;
        cout << "(2) Add sales log" << endl;
        cout << "(3) Find salesman" << endl;
        cout << "(4) Find sales log" << endl;
        cout << "(5) Find salesman profile" << endl;
        cout << "(6) Analyze total sales" << endl;
        cout << "(0) Exit" << endl;
        int choice;
        cin >> choice;
        switch (choice)
        {
            case 1:
                salesmen.push_back(Salesman::input());
                break;
            case 2:
                salesLogs.push_back(SalesLog::input());
                break;
            case 3:
            {
                cout << "Enter salesman ID: ";
                int id;
                cin >> id;
                if (!findSalesman(id, salesmen))
                {
                    cout << "Salesman not found" << endl;
                }

                break;
            }
            case 4:
            {
                cout << "Enter salesman ID: ";
                int id;
                cin >> id;
                if (!findSalesLog(id, salesLogs))
                {
                    cout << "Sales log not found" << endl;
                }

                break;
            }
            case 5:
            {
                cout << "Enter salesman ID: ";
                int id;
                cin >> id;
                if (!findSalesman(id, salesmen))
                {
                    cout << "Salesman not found" << endl;
                }

                if (!findSalesLog(id, salesLogs))
                {
                    cout << "Sales log not found" << endl;
                }

                break;
            }
            case 6:
            {
                SalesLog log;
                for (vector<SalesLog*>::iterator i = salesLogs.begin(); i != salesLogs.end(); i++)
                {
                    log = log + **i;
                }

                // Print total sales by auto category
                cout << log.toString() << endl;

                long long totalSales = 0;
                for (int i = 0; i < SalesLog::Count; i++)
                {
                    totalSales += log.salesVolume(static_cast<SalesLog::Manufacturer>(i));
                }

                // Print total sales
                cout << "Total sales: $" << totalSales << endl;
                cout << "Average sales: $" << totalSales / SalesLog::Count << endl;

                // Lowest sale
                long long lowestSale = numeric_limits<long long>::max();
                for (int i = 0; i < SalesLog::Count; i++)
                {
                    long long sale = log.salesVolume(static_cast<SalesLog::Manufacturer>(i));
                    if (sale < lowestSale)
                    {
                        lowestSale = sale;
                    }
                }

                cout << "Lowest sales: $" << lowestSale << endl;

                // Highest sale
                long long highestSale = numeric_limits<long long>::min();
                for (int i = 0; i < SalesLog::Count; i++)
                {
                    long long sale = log.salesVolume(static_cast<SalesLog::Manufacturer>(i));
                    if (sale > highestSale)
                    {
                        highestSale = sale;
                    }
                }

                cout << "Highest sales: $" << highestSale << endl;

                break;
            }
            default:
                return 0;
        }
    }
    while (true);
}

bool findSalesman(int id, const vector<Salesman*> &salesmen)
{
    for (vector<Salesman*>::const_iterator i = salesmen.begin(); i != salesmen.end(); i++)
    {
        if ((*i)->id() == id)
        {
            cout << (*i)->toString() << endl;
            return true;
        }
    }

    return false;
}

bool findSalesLog(int id, const vector<SalesLog*> &salesLogs)
{
    for (vector<SalesLog*>::const_iterator i = salesLogs.begin(); i != salesLogs.end(); i++)
    {
        if ((*i)->salesmanId() == id)
        {
            cout << (*i)->toString() << endl;
            return true;
        }
    }

    return false;
}