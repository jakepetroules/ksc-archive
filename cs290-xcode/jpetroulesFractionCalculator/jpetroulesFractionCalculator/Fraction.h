//
//  Fraction.h
//  jpetroulesFractionCalculator
//
//  Created by Jake Petroules on 10/19/11.
//  Copyright 2011 Jake Petroules. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface Fraction : NSObject
{
    int numerator;
    int denominator;
}

@property int numerator, denominator;

- (void) print;
- (NSString*) toString;
- (void) setTo: (int) n over: (int) d;
- (Fraction*) add: (Fraction*) fraction;
- (Fraction*) subtract: (Fraction*) fraction;
- (Fraction*) multiply: (Fraction*) fraction;
- (Fraction*) divide: (Fraction*) fraction;
- (double) convertToNum;
- (void) reduce;

@end
