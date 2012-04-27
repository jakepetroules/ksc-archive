//
//  Fraction.m
//  jpetroulesHW03MPG
//  CS290-01 Fall 2011
//
//  Created by Jake Petroules on 9/22/11.
//  Copyright 2011 Jake Petroules. All rights reserved.
//  This application is an MPG calculator.
//

#import "Fraction.h"

@implementation Fraction

- (id)init
{
    self = [super init];
    if (self) {
        // Initialization code here.
    }
    
    return self;
}

- (void)print
{
    NSLog(@"Your vehicle gets %d M.P.G.", self.miles / self.gallons);
}

- (int)miles
{
    return self->m_miles;
}

- (void)setMiles: (int)miles
{
    self->m_miles = miles;
}

- (int)gallons
{
    return self->m_gallons;
}

- (void)setGallons: (int)gallons
{
    self->m_gallons = gallons;
}

@end
