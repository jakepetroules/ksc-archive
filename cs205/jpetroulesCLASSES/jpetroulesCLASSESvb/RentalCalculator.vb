Option Strict On
Option Explicit On

Public Class RentalCalculator
    ''' <summary>
    ''' Vermont has a 5% rooms and meals tax.
    ''' </summary>
    Public Shared Property TaxRate As Decimal = 0.05D

    ''' <summary>
    ''' Calculates the customer's total bill for the rental period with the unit and services selected.
    ''' </summary>
    ''' <param name="rentalPeriod">The period of rental.</param>
    ''' <param name="unit">The type of unit the customer will be staying in.</param>
    ''' <param name="services">The optional services the customer has selected.</param>
    ''' <returns>The customer's total bill in USD.</returns>
    Public Shared Function CalculateTotal(ByVal rentalPeriod As TimeSpan, ByVal unit As RentalUnit, ByVal services As OptionalServices) As Decimal
        ' Cost of the unit for the amount of days in the rental period
        Dim totalCost As Decimal = (RentalCalculator.WeeklyUnitPrice(unit) / 7) * rentalPeriod.Days

        ' If they're renting for 3 months or more, give them a 20% discount
        If rentalPeriod.Days >= 90 Then
            totalCost *= 0.8D
        End If

        totalCost += RentalCalculator.OptionalServicesCost(rentalPeriod, unit, services)

        Return totalCost * (1 + RentalCalculator.TaxRate)
    End Function

    ''' <summary>
    ''' Calculates the cost to rent the specified unit for one week.
    ''' </summary>
    ''' <param name="unit">The unit to rent.</param>
    Public Shared Function WeeklyUnitPrice(ByVal unit As RentalUnit) As Decimal
        Select Case unit
            Case RentalUnit.Studio
                Return 1000
            Case RentalUnit.TwoBedroomSuite
                Return 2000
            Case RentalUnit.ThreeBedroomSuite
                Return 3000
            Case RentalUnit.Penthouse
                Return 15000
            Case Else
                Return 0
        End Select
    End Function

    ''' <summary>
    ''' Calculates the cost of the specified optional services.
    ''' </summary>
    ''' <param name="rentalPeriod">The period of rental.</param>
    ''' <param name="unit">The type of unit the customer will be staying in.</param>
    ''' <param name="services">The optional services the customer has selected.</param>
    ''' <returns>The cost of the optional services in USD.</returns>
    Public Shared Function OptionalServicesCost(ByVal rentalPeriod As TimeSpan, ByVal unit As RentalUnit, ByVal services As OptionalServices) As Decimal
        Dim cost As Decimal = 0

        ' Maid service is $100/day
        If (services And OptionalServices.Maid) = OptionalServices.Maid Then
            cost += 100 * rentalPeriod.Days
        End If

        ' The penthouse has 4 bedrooms; the cost is $20/day per bedroom, so we multiply by 4 bedrooms
        ' if the penthouse was selected, otherwise just multiply by 1 bedroom
        If (services And OptionalServices.Linen) = OptionalServices.Linen Then
            cost += 20 * rentalPeriod.Days * If(unit = RentalUnit.Penthouse, 4, 1)
        End If

        ' Limo service is $75/day
        If (services And OptionalServices.Limo) = OptionalServices.Limo Then
            cost += 75 * rentalPeriod.Days
        End If

        Return cost
    End Function
End Class
