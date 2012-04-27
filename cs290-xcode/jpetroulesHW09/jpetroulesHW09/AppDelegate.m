//
//  AppDelegate.m
//  jpetroulesHW09
//
//  Created by Jake Petroules on 11/30/11.
//  Copyright (c) 2011 __MyCompanyName__. All rights reserved.
//

#import "AppDelegate.h"
#import "Fraction.h"

@implementation AppDelegate
@synthesize plusToolbarButton = _plusToolbarButton;
@synthesize minusToolbarButton = _minusToolbarButton;
@synthesize timesToolbarButton = _timesToolbarButton;
@synthesize divideToolbarButton = _divideToolbarButton;
@synthesize toolbar = _toolbar;
@synthesize plusMenuItem = _plusMenuItem;
@synthesize minusMenuItem = _minusMenuItem;
@synthesize timesMenuItem = _timesMenuItem;
@synthesize divideMenuItem = _divideMenuItem;
@synthesize numerator1 = _numerator1;
@synthesize denominator1 = _denominator1;
@synthesize numerator2 = _numerator2;
@synthesize denominator2 = _denominator2;
@synthesize resultNumerator = _resultNumerator;
@synthesize resultDenominator = _resultDenominator;
@synthesize operator = _operator;
@synthesize window = _window;

- (void)dealloc
{
    [super dealloc];
}

- (void)applicationDidFinishLaunching:(NSNotification *)aNotification
{
    [self setCurrentOperator: '+'];
}

- (BOOL)applicationShouldTerminateAfterLastWindowClosed:(NSApplication *)theApplication
{
    return YES;
}

- (IBAction)calculate:(id)sender
{
    // Create Fraction objects from the values in the text boxes
    Fraction *fraction1 = [[Fraction alloc] init];
    [fraction1 setTo: [_numerator1 intValue] over: [_denominator1 intValue]];
    
    Fraction *fraction2 = [[Fraction alloc] init];
    [fraction2 setTo: [_numerator2 intValue] over: [_denominator2 intValue]];
    
    // Invalid inputs will be taken as "0", so set the text boxes back to what we got so they
    // represent the value that was actually read
    [_numerator1 setStringValue: [NSString stringWithFormat: @"%i", [fraction1 numerator]]];
    [_denominator1 setStringValue: [NSString stringWithFormat: @"%i", [fraction1 denominator]]];
    [_numerator2 setStringValue: [NSString stringWithFormat: @"%i", [fraction2 numerator]]];
    [_denominator2 setStringValue: [NSString stringWithFormat: @"%i", [fraction2 denominator]]];
    
    // Only calculate if denominators are not 0
    if ([fraction1 denominator] != 0 && [fraction2 denominator] != 0)
    {
        Fraction *result = nil;
        
        // Calculate the result based on the selected operator
        switch ([self currentOperator])
        {
            case '+':
                result = [fraction1 add: fraction2];
                break;
            case '-':
                result = [fraction1 subtract: fraction2];
                break;
            case '*':
                result = [fraction1 multiply: fraction2];
                break;
            case '/':
                result = [fraction1 divide: fraction2];
                break;
        }
        
        // Display the resulting fraction in the output text boxes
        if (result)
        {
            [_resultNumerator setStringValue: [NSString stringWithFormat: @"%i", [result numerator]]];
            [_resultDenominator setStringValue: [NSString stringWithFormat: @"%i", [result denominator]]];
        }
    }
    else
    {
        // One or both denominators were 0, so the result is undefined
        [_resultNumerator setStringValue: @"undefined"];
        [_resultDenominator setStringValue: @"undefined"];
    }
}

- (IBAction)changeOperator:(id)sender
{
    if (sender == _operator)
    {
        [self setCurrentOperator: [[_operator titleOfSelectedItem] characterAtIndex: 0]];
    }
    else if (sender == _plusMenuItem || sender == _plusToolbarButton)
    {
        [self setCurrentOperator: '+'];
    }
    else if (sender == _minusMenuItem || sender == _minusToolbarButton)
    {
        [self setCurrentOperator: '-'];
    }
    else if (sender == _timesMenuItem || sender == _timesToolbarButton)
    {
        [self setCurrentOperator: '*'];
    }
    else if (sender == _divideMenuItem || sender == _divideToolbarButton)
    {
        [self setCurrentOperator: '/'];
    }
    
    [self calculate: nil];
}

- (char)currentOperator
{
    return [[_operator titleOfSelectedItem] characterAtIndex: 0];
}

- (void)setCurrentOperator: (char) operator
{
    [_plusMenuItem setState: NSOffState];
    [_minusMenuItem setState: NSOffState];
    [_timesMenuItem setState: NSOffState];
    [_divideMenuItem setState: NSOffState];
    
    id menuItem = nil;
    id toolbarItem = nil;
    int index = -1;
    
    switch (operator)
    {
        case '+':
            menuItem = _plusMenuItem;
            toolbarItem = _plusToolbarButton;
            index = 0;
            break;
        case '-':
            menuItem = _minusMenuItem;
            toolbarItem = _minusToolbarButton;
            index = 1;
            break;
        case '*':
            menuItem = _timesMenuItem;
            toolbarItem = _timesToolbarButton;
            index = 2;
            break;
        case '/':
            menuItem = _divideMenuItem;
            toolbarItem = _divideToolbarButton;
            index = 3;
            break;
    }
    
    
    [menuItem setState: NSOnState];
    [_toolbar setSelectedItemIdentifier: [toolbarItem itemIdentifier]];
    [_operator selectItemAtIndex: index];
}

@end
