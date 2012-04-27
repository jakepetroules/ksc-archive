//
//  main.m
//  jpetroulesCalculator
//  CS290-01 Fall 2011
//
//  Created by Jake Petroules on 10/7/11.
//  Copyright 2011 Jake Petroules. All rights reserved.
//  This application implements the functions of a desk calculator.
//

#import <Foundation/Foundation.h>
#import "Calculator.h"

int main (int argc, const char * argv[])
{
    NSAutoreleasePool * pool = [[NSAutoreleasePool alloc] init];

    // Test our calculator by trying all the operations
    Calculator *calculator = [[Calculator alloc] init];
    [calculator setAccumulator: 100];
    [calculator add: 200];
    [calculator divide: 15];
    [calculator subtract: 10];
    [calculator multiply: 5];
    
    [calculator changeSign];
    [calculator reciprocal];
    [calculator xSquared];
    
    [calculator memoryAdd: 20];
    [calculator multiply: 30];
    [calculator memorySubtract: 4];
    [calculator xSquared];
    [calculator memoryRecall];
    [calculator divide: 3];
    [calculator memoryStore];
    [calculator reciprocal];
    [calculator memoryClear];
    
    // Print out the final value
    NSLog(@"The result is %g", [calculator accumulator]);

    [pool drain];
    return 0;
}

