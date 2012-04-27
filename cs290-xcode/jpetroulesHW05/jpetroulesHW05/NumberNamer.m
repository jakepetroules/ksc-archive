//
//  NumberNamer.m
//  jpetroulesHW05
//  CS290-01 Fall 2011
//
//  Created by Jake Petroules on 10/7/11.
//  Copyright 2011 Jake Petroules. All rights reserved.
//  This application prints the English names of numbers from 0 to 10.
//

#import "NumberNamer.h"

@implementation NumberNamer

+(NSString*)numberToStringRepresentation:(int)number
{
    switch (number)
    {
        case 0:
            return @"zero";
        case 1:
            return @"one";
        case 2:
            return @"two";
        case 3:
            return @"three";
        case 4:
            return @"four";
        case 5:
            return @"five";
        case 6:
            return @"six";
        case 7:
            return @"seven";
        case 8:
            return @"eight";
        case 9:
            return @"nine";
        case 10:
            return @"ten";
        default:
            return @"only 0-10 supported";
    }
}

@end
