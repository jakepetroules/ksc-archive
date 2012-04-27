//
//  main.m
//  jpetroulesFractionCalculator
//
//  Created by Jake Petroules on 10/19/11.
//  Copyright 2011 Jake Petroules. All rights reserved.
//

#import <Foundation/Foundation.h>
#import "Fraction.h"

int main (int argc, const char * argv[])
{
    NSAutoreleasePool * pool = [[NSAutoreleasePool alloc] init];

    Fraction *fraction1 = [[Fraction alloc] init];
    [fraction1 setTo: 1 over: 2];
    
    Fraction *fraction2 = [[Fraction alloc] init];
    [fraction2 setTo: 1 over: 4];
    
    // Print the result of fraction1 + fraction2
    Fraction *additionResult = [fraction1 add: fraction2];
    NSLog(@"\n%@ + %@ = %@", [fraction1 toString], [fraction2 toString], [additionResult toString]);

    Fraction *frac48 = [[Fraction alloc] init];
    [frac48 setTo: 4 over: 8];
    
    Fraction *subtractionResult = [additionResult subtract: frac48];
    NSLog(@"\n%@ - %@ = %@", [additionResult toString], [frac48 toString], [subtractionResult toString]);
    
    Fraction *multiplicationResult = [fraction1 multiply: fraction1];
    NSLog(@"\n%@ * %@ = %@", [fraction1 toString], [fraction1 toString], [multiplicationResult toString]);
    
    Fraction *divisionResult = [fraction1 divide: fraction2];
    NSLog(@"\n%@ / %@ = %@", [fraction1 toString], [fraction2 toString], [divisionResult toString]);
    
    [pool drain];
    return 0;
}

