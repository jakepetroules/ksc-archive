//
//  Calculator.m
//  jpetroulesCalculator
//  CS290-01 Fall 2011
//
//  Created by Jake Petroules on 10/7/11.
//  Copyright 2011 Jake Petroules. All rights reserved.
//  This application implements the functions of a desk calculator.
//

#import "Calculator.h"

@implementation Calculator

- (id)init
{
    self = [super init];
    if (self) {
        accumulator = 0;
        memory = 0;
    }
    
    return self;
}

-(void) setAccumulator:(double)value
{
    accumulator = value;
    NSLog(@"Accumulator set to %g", accumulator);
}

-(void) clear
{
    accumulator = 0;
    NSLog(@"Accumulator cleared");
}

-(double) accumulator
{
    return accumulator;
}

-(double) add:(double)value
{
    accumulator += value;
    NSLog(@"%g added to accumulator, new value %g", value, accumulator);
    return accumulator;
}

-(double) subtract:(double)value
{
    accumulator -= value;
    NSLog(@"%g subtracted from accumulator, new value %g", value, accumulator);
    return accumulator;
}

-(double) multiply:(double)value
{
    accumulator *= value;
    NSLog(@"%g multiplied by accumulator, new value %g", value, accumulator);
    return accumulator;
}

-(double) divide:(double)value
{
    accumulator /= value;
    NSLog(@"%g divided by accumulator, new value %g", value, accumulator);
    return accumulator;
}

-(double) changeSign
{
    accumulator = -accumulator;
    NSLog(@"Sign of accumulator changed, new value %g", accumulator);
    return accumulator;
}

-(double) reciprocal
{
    accumulator = 1 / accumulator;
    NSLog(@"accumulator set to its reciprocal, new value %g", accumulator);
    return accumulator;
}

-(double) xSquared
{
    accumulator = accumulator * accumulator;
    NSLog(@"accumulator squared, new value %g", accumulator);
    return accumulator;
}

-(double) memoryClear
{
    memory = 0;
    NSLog(@"Memory cleared");
    return accumulator;
}

-(double) memoryStore
{
    memory = accumulator;
    NSLog(@"Accumulator stored in memory, new value %g", memory);
    return accumulator;
}

-(double) memoryRecall
{
    accumulator = memory;
    NSLog(@"Accumulator value recalled from memory, new value %g", accumulator);
    return accumulator;
}

-(double) memoryAdd:(double)value
{
    memory += value;
    NSLog(@"%g added to memory, new value %g", value, memory);
    return [self memoryRecall];
}

-(double) memorySubtract:(double)value
{
    memory -= value;
    NSLog(@"%g subtracted from memory, new value %g", value, memory);
    return [self memoryRecall];
}

@end
