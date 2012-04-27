//
//  Fraction.m
//  jpetroulesHW09
//
//  Created by Jake Petroules on 12/1/11.
//  Copyright (c) 2011 __MyCompanyName__. All rights reserved.
//

#import "Fraction.h"

@implementation Fraction

@synthesize numerator, denominator;

- (id)init
{
    self = [super init];
    if (self) {
        // Initialization code here.
    }
    
    return self;
}

- (void) print
{
    NSLog(@"%@", [self toString]);
}

- (NSString*) toString
{
    if (denominator == 1)
    {
        return [NSString stringWithFormat: @"%i", numerator];
    }
    
    return [NSString stringWithFormat: @"%i/%i", numerator, denominator];
}

- (void) setTo: (int) n over: (int) d
{
    numerator = n;
    denominator = d;
}

- (Fraction*) add: (Fraction*) fraction
{
    Fraction *result = [[Fraction alloc] init];
    
    result.numerator = numerator * fraction.denominator + denominator * fraction.numerator;
    result.denominator = denominator * fraction.denominator;
    [result reduce];
    return result;
}

- (Fraction*) subtract: (Fraction*)fraction
{
    Fraction *result = [[Fraction alloc] init];
    
    result.numerator = numerator * fraction.denominator - denominator * fraction.numerator;
    result.denominator = denominator * fraction.denominator;
    [result reduce];
    return result;
}

- (Fraction*) multiply: (Fraction*) fraction
{
    Fraction *result = [[Fraction alloc] init];
    
    result.numerator = numerator * fraction.numerator;
    result.denominator = denominator * fraction.denominator;
    [result reduce];
    return result;
}

- (Fraction*) divide: (Fraction*) fraction
{
    Fraction *result = [[Fraction alloc] init];
    
    result.numerator = numerator * fraction.denominator;
    result.denominator = denominator * fraction.numerator;
    [result reduce];
    return result;
}

- (double) convertToNum
{
    return numerator / (double)denominator;
}

- (void) reduce
{
    int reducedNumerator = numerator;
    int reducedDenominator = denominator;
    int temp;
    
    while (reducedDenominator != 0)
    {
        temp = reducedNumerator % reducedDenominator;
        reducedNumerator = reducedDenominator;
        reducedDenominator = temp;
    }
    
    numerator /= reducedNumerator;
    denominator /= reducedNumerator;
}

@end