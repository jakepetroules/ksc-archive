//
//  AppDelegate.m
//  jpetroulesHW10
//
//  Created by Jake Petroules on 12/5/11.
//  Copyright (c) 2011 __MyCompanyName__. All rights reserved.
//

#import "AppDelegate.h"

@implementation AppDelegate

@synthesize window = _window;
@synthesize sequenceLength = _sequenceLength;
@synthesize output = _output;

- (void)dealloc
{
    [super dealloc];
}

- (void)applicationDidFinishLaunching:(NSNotification *)aNotification
{
    // Insert code here to initialize your application
}

- (BOOL)applicationShouldTerminateAfterLastWindowClosed:(NSApplication *)sender
{
    return YES;
}

- (IBAction)calculate:(id)sender
{
    long long count = [_sequenceLength intValue];
    [_sequenceLength setStringValue: [NSString stringWithFormat: @"%i", count]];
    
    long long sequence[count];
    sequence[0] = 0;
    sequence[1] = 1;
    
    NSString *output = @"0\n1\n";
    for (long long i = 2; i < count; i++)
    {
        sequence[i] = sequence[i - 2] + sequence[i - 1];
        
        output = [output stringByAppendingFormat: @"%i\n", sequence[i]];
    }
    
    [_output setStringValue: output];
}

- (IBAction)reset:(id)sender
{
    [_output setStringValue: @""];
}

@end
