//
//  AppDelegate.h
//  jpetroulesHW10
//
//  Created by Jake Petroules on 12/5/11.
//  Copyright (c) 2011 __MyCompanyName__. All rights reserved.
//

#import <Cocoa/Cocoa.h>

@interface AppDelegate : NSObject <NSApplicationDelegate>

@property (assign) IBOutlet NSWindow *window;
@property (assign) IBOutlet NSTextField *sequenceLength;
@property (assign) IBOutlet NSTextField *output;
- (IBAction)calculate:(id)sender;
- (IBAction)reset:(id)sender;

@end
