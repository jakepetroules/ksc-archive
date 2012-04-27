//
//  AppDelegate.h
//  jpetroulesHW09
//
//  Created by Jake Petroules on 11/30/11.
//  Copyright (c) 2011 __MyCompanyName__. All rights reserved.
//

#import <Cocoa/Cocoa.h>

@interface AppDelegate : NSObject <NSApplicationDelegate>

@property (assign) IBOutlet NSWindow *window;
@property (assign) IBOutlet NSTextField *numerator1;
@property (assign) IBOutlet NSTextField *denominator1;
@property (assign) IBOutlet NSPopUpButton *operator;
@property (assign) IBOutlet NSTextField *numerator2;
@property (assign) IBOutlet NSTextField *denominator2;
@property (assign) IBOutlet NSTextField *resultNumerator;
@property (assign) IBOutlet NSTextField *resultDenominator;
- (IBAction)calculate:(id)sender;
- (IBAction)changeOperator:(id)sender;
@property (assign) IBOutlet NSMenuItem *plusMenuItem;
@property (assign) IBOutlet NSMenuItem *minusMenuItem;
@property (assign) IBOutlet NSMenuItem *timesMenuItem;
@property (assign) IBOutlet NSMenuItem *divideMenuItem;
- (char)currentOperator;
- (void)setCurrentOperator: (char) operator;
@property (assign) IBOutlet NSToolbarItem *plusToolbarButton;
@property (assign) IBOutlet NSToolbarItem *minusToolbarButton;
@property (assign) IBOutlet NSToolbarItem *timesToolbarButton;
@property (assign) IBOutlet NSToolbarItem *divideToolbarButton;
@property (assign) IBOutlet NSToolbar *toolbar;

@end
