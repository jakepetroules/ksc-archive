//
//  main.m
//  jpetroulesHW01_Limerick
//  CS290-01 Fall 2011
//
//  Created by Jake Petroules on 9/3/11.
//  Copyright 2011 Jake Petroules. All rights reserved.
//  This application writes a limerick to the console.
//

#import <Foundation/Foundation.h>

int main (int argc, const char * argv[])
{
    NSAutoreleasePool * pool = [[NSAutoreleasePool alloc] init];

    // Write the limerick text to the console
    // Taken from: http://www.cs4fn.org/limericks/limerickcomp7.php
    NSLog(@"A computer found floating in space\nHad belonged to a programming ace\nWho'd exploited the Earth\nFor all it was worth,\nDestroying the whole human race.\n- Bob Evans");

    [pool drain];
    return 0;
}

