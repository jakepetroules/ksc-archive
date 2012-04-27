#include "SalesLog.h"
#include <iostream>
#include <sstream>

SalesLog::SalesLog()
    : m_salesmanId(-1)
{
    for (int i = 0; i < Count; i++)
    {
        this->m_unitsSold[i] = 0;
    }
}

SalesLog::SalesLog(const SalesLog& orig)
{
    this->m_salesmanId = orig.m_salesmanId;
    this->m_salesPeriod = orig.m_salesPeriod;
    for (int i = 0; i < Count; i++)
    {
        this->m_unitsSold[i] = orig.m_unitsSold[i];
    }
}

SalesLog::~SalesLog()
{
}

SalesLog* SalesLog::input()
{
    cout << "Enter the salesman's ID number: ";
    int id;
    cin >> id;

    cout << "Enter the sales period (YYYY): ";
    int year;
    cin >> year;

    cout << "Enter the sales period (MM): ";
    int month;
    cin >> month;

    SalesLog *log = new SalesLog();
    log->m_salesmanId = id;
    log->m_salesPeriod.year = year;
    log->m_salesPeriod.month = month;

    for (int i = 0; i < Count; i++)
    {
        cout << "Enter the number of " << manufacturerName(static_cast<Manufacturer>(i)) << " units sold: ";
        int units;
        cin >> units;
        log->m_unitsSold[i] = units;
    }

    return log;
}

int SalesLog::carPrice(Manufacturer manufacturer)
{
    switch (manufacturer)
    {
        case Honda:
            return 30000;
        case Toyota:
            return 33000;
        case Chrysler:
            return 32000;
        case Volvo:
            return 35000;
        default:
            return 0;
    }
}

string SalesLog::manufacturerName(Manufacturer manufacturer)
{
    switch (manufacturer)
    {
        case Honda:
            return "Honda";
        case Toyota:
            return "Toyota";
        case Chrysler:
            return "Chrysler";
        case Volvo:
            return "Volvo";
        default:
            return "";
    }
}

int SalesLog::salesmanId() const
{
    return this->m_salesmanId;
}

void SalesLog::setSalesmanId(int salesmanId)
{
    this->m_salesmanId = salesmanId;
}

void SalesLog::resetSalesmanId()
{
    this->m_salesmanId = -1;
}

int SalesLog::unitsSold(Manufacturer manufacturer) const
{
    return this->m_unitsSold[manufacturer];
}

int SalesLog::salesVolume(Manufacturer manufacturer) const
{
    return this->carPrice(manufacturer) * this->unitsSold(manufacturer);
}

string SalesLog::idAndPeriod() const
{
    stringstream out;
    out << "ID: " << this->m_salesmanId << ", Period: " << this->m_salesPeriod.year << "-" << this->m_salesPeriod.month << endl;
    return out.str();
}

string SalesLog::toString() const
{
    stringstream out;
    out << "ID: " << this->m_salesmanId << endl;
    out << "Sales period: " << this->m_salesPeriod.year << "-" << this->m_salesPeriod.month << endl;
    for (int i = 0; i < Count; i++)
    {
        out << manufacturerName(static_cast<Manufacturer>(i))
            << " units sold: "
            << this->m_unitsSold[i]
            << " at "
            << carPrice(static_cast<Manufacturer>(i))
            << " each for a total of $"
            << this->salesVolume(static_cast<Manufacturer>(i))
            << endl;
    }

    return out.str();
}

SalesLog operator+(const SalesLog &salesLog1, const SalesLog &salesLog2)
{
    SalesLog result;

    for (int i = 0; i < SalesLog::Count; i++)
    {
        result.m_unitsSold[i] = salesLog1.m_unitsSold[i] + salesLog2.m_unitsSold[i];
    }

    return result;
}

SalesLog SalesLog::operator=(SalesLog salesLog)
{
    this->m_salesmanId = salesLog.m_salesmanId;
    this->m_salesPeriod = salesLog.m_salesPeriod;

    for (int i = 0; i < Count; i++)
    {
        this->m_unitsSold[i] = salesLog.m_unitsSold[i];
    }

    return *this;
}

SalesLog SalesLog::operator<(SalesLog salesLog)
{
    long long sales1 = 0;
    long long sales2 = 0;
    for (int i = 0; i < Count; i++)
    {
        sales1 += this->salesVolume(static_cast<Manufacturer>(i));
        sales2 += salesLog.salesVolume(static_cast<Manufacturer>(i));
    }

    return (sales1 < sales2) ? *this : salesLog;
}

SalesLog SalesLog::operator>(SalesLog salesLog)
{
    long long sales1 = 0;
    long long sales2 = 0;
    for (int i = 0; i < Count; i++)
    {
        sales1 += this->salesVolume(static_cast<Manufacturer>(i));
        sales2 += salesLog.salesVolume(static_cast<Manufacturer>(i));
    }

    return (sales1 > sales2) ? *this : salesLog;
}
