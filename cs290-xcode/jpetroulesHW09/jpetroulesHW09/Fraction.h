//
//  Fraction.h
//  jpetroulesHW09
//
//  Created by Jake Petroules on 12/1/11.
//  Copyright (c) 2011 __MyCompanyName__. All rights reserved.
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