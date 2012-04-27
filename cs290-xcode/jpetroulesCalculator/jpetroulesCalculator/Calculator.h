//
//  Calculator.h
//  jpetroulesCalculator
//  CS290-01 Fall 2011
//
//  Created by Jake Petroules on 10/7/11.
//  Copyright 2011 Jake Petroules. All rights reserved.
//  This application implements the functions of a desk calculator.
//

#import <Foundation/Foundation.h>

@interface Calculator : NSObject
{
    double accumulator;
    double memory;
}

-(void) setAccumulator: (double)value;
-(void) clear;
-(double) accumulator;

-(double) add: (double)value;
-(double) subtract: (double)value;
-(double) multiply: (double)value;
-(double) divide: (double)value;

-(double) changeSign;
-(double) reciprocal;
-(double) xSquared;

-(double) memoryClear;
-(double) memoryStore;
-(double) memoryRecall;
-(double) memoryAdd: (double) value;
-(double) memorySubtract: (double) value;

@end
