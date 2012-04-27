using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jpetroulesCONDOcs
{
    public static class RentalCalculator
    {
        /// <summary>
        /// Vermont has a 5% rooms and meals tax.
        /// </summary>
        public static decimal TaxRate
        {
            get { return 0.05m; }
        }

        /// <summary>
        /// Calculates the customer's total bill for the rental period with the unit and services selected.
        /// </summary>
        /// <param name="rentalPeriod">The period of rental.</param>
        /// <param name="unit">The type of unit the customer will be staying in.</param>
        /// <param name="services">The optional services the customer has selected.</param>
        /// <returns>The customer's total bill in USD.</returns>
        public static decimal CalculateTotal(TimeSpan rentalPeriod, RentalUnit unit, OptionalServices services)
        {
            // Cost of the unit for the amount of days in the rental period
            decimal totalCost = (RentalCalculator.WeeklyUnitPrice(unit) / 7) * rentalPeriod.Days;

            // If they're renting for 3 months or more, give them a 20% discount
            if (rentalPeriod.Days >= 90)
            {
                totalCost *= 0.8m;
            }

            totalCost += RentalCalculator.OptionalServicesCost(rentalPeriod, unit, services);

            return totalCost * (1 + RentalCalculator.TaxRate);
        }

        /// <summary>
        /// Calculates the cost to rent the specified unit for one week.
        /// </summary>
        /// <param name="unit">The unit to rent.</param>
        public static decimal WeeklyUnitPrice(RentalUnit unit)
        {
            switch (unit)
            {
                case RentalUnit.Studio:
                    return 1000;
                case RentalUnit.TwoBedroomSuite:
                    return 2000;
                case RentalUnit.ThreeBedroomSuite:
                    return 3000;
                case RentalUnit.Penthouse:
                    return 15000;
                default:
                    return 0;
            }
        }

        /// <summary>
        /// Calculates the cost of the specified optional services.
        /// </summary>
        /// <param name="rentalPeriod">The period of rental.</param>
        /// <param name="unit">The type of unit the customer will be staying in.</param>
        /// <param name="services">The optional services the customer has selected.</param>
        /// <returns>The cost of the optional services in USD.</returns>
        public static decimal OptionalServicesCost(TimeSpan rentalPeriod, RentalUnit unit, OptionalServices services)
        {
            decimal cost = 0;

            // Maid service is $100/day
            if ((services & OptionalServices.Maid) == OptionalServices.Maid)
            {
                cost += 100 * rentalPeriod.Days;
            }

            // The penthouse has 4 bedrooms; the cost is $20/day per bedroom, so we multiply by 4 bedrooms
            // if the penthouse was selected, otherwise just multiply by 1 bedroom
            if ((services & OptionalServices.Linen) == OptionalServices.Linen)
            {
                cost += 20 * rentalPeriod.Days * (unit == RentalUnit.Penthouse ? 4 : 1);
            }

            // Limo service is $75/day
            if ((services & OptionalServices.Limo) == OptionalServices.Limo)
            {
                cost += 75 * rentalPeriod.Days;
            }

            return cost;
        }
    }
}
