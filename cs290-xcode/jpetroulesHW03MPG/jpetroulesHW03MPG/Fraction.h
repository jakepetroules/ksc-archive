//
//  Fraction.h
//  jpetroulesHW03MPG
//  CS290-01 Fall 2011
//
//  Created by Jake Petroules on 9/22/11.
//  Copyright 2011 Jake Petroules. All rights reserved.
//  This application is an MPG calculator.
//

#import <Foundation/Foundation.h>

@interface Fraction : NSObject
{
@private
    int m_miles;
    int m_gallons;
}

- (void)print;
- (int)miles;
- (void)setMiles: (int)miles;
- (int)gallons;
- (void)setGallons: (int)gallons;

@end
