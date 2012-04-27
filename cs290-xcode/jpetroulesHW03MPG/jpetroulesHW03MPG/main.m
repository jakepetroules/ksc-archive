//
//  main.m
//  jpetroulesHW03MPG
//  CS290-01 Fall 2011
//
//  Created by Jake Petroules on 9/22/11.
//  Copyright 2011 Jake Petroules. All rights reserved.
//  This application is an MPG calculator.
//

#import <Foundation/Foundation.h>
#import "Fraction.h"

int main (int argc, const char * argv[])
{
    NSAutoreleasePool * pool = [[NSAutoreleasePool alloc] init];

    // Create a new Fraction object
    Fraction *fraction = [[Fraction alloc] init];
    
    // Set the fraction's properties
    [fraction setMiles: 578];
    [fraction setGallons: 33];
    
    // Display the MPG value
    [fraction print];
    [fraction release];

    [pool drain];
    return 0;
}

