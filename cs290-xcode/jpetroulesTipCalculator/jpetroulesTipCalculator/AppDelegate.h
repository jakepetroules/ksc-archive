//
//  AppDelegate.h
//  jpetroulesTipCalculator
//
//  Created by Jake Petroules on 11/18/11.
//  Copyright (c) 2011 __MyCompanyName__. All rights reserved.
//

#import <Cocoa/Cocoa.h>

@interface AppDelegate : NSObject <NSApplicationDelegate>

@property (assign) IBOutlet NSWindow *window;
- (IBAction)calculate:(id)sender;
@property (assign) IBOutlet NSTextField *billTotal;
@property (assign) IBOutlet NSComboBox *tipPercentage;
@property (assign) IBOutlet NSPopUpButton *billSplit;
@property (assign) IBOutlet NSTextField *paymentDetails;

@end
