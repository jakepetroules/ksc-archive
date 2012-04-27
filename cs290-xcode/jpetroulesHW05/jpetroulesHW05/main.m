//
//  main.m
//  jpetroulesHW05
//  CS290-01 Fall 2011
//
//  Created by Jake Petroules on 10/7/11.
//  Copyright 2011 Jake Petroules. All rights reserved.
//  This application prints the English names of numbers from 0 to 10.
//

#import <Foundation/Foundation.h>
#import "NumberNamer.h"

int main (int argc, const char * argv[])
{

    NSAutoreleasePool * pool = [[NSAutoreleasePool alloc] init];

    printf("Enter a number: ");
    int num;
    scanf("%d", &num);
    
    NSLog(@"%d is called %@", num, [NumberNamer numberToStringRepresentation: num]);

    [pool drain];
    return 0;
}

