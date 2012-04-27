#ifndef SALESLOG_H
#define	SALESLOG_H

#include <string>

using namespace std;

struct AccountingPeriod
{
    int year;
    int month;

    AccountingPeriod() : year(0), month(0)
    {
    }
};

class SalesLog
{
public:
    enum Manufacturer
    {
        Honda,
        Toyota,
        Chrysler,
        Volvo,
        Count
    };
    
    SalesLog();
    SalesLog(const SalesLog& orig);
    virtual ~SalesLog();
    static SalesLog* input();
    static int carPrice(Manufacturer manufacturer);
    static string manufacturerName(Manufacturer manufacturer);
    int salesmanId() const;
    void setSalesmanId(int salesmanId);
    void resetSalesmanId();
    int unitsSold(Manufacturer manufacturer) const;
    int salesVolume(Manufacturer manufacturer) const;
    string idAndPeriod() const;
    string toString() const;
    friend SalesLog operator+(const SalesLog &salesLog1, const SalesLog &salesLog2);
    SalesLog operator=(SalesLog salesLog);
    SalesLog operator<(SalesLog salesLog);
    SalesLog operator>(SalesLog salesLog);

private:
    int m_salesmanId;
    AccountingPeriod m_salesPeriod;
    int m_unitsSold[Count];
};

#endif	/* SALESLOG_H */

