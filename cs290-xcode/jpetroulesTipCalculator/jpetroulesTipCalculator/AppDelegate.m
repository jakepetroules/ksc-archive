//
//  AppDelegate.m
//  jpetroulesTipCalculator
//
//  Created by Jake Petroules on 11/18/11.
//  Copyright (c) 2011 __MyCompanyName__. All rights reserved.
//

#import "AppDelegate.h"

@implementation AppDelegate
@synthesize billTotal = _billTotal;
@synthesize tipPercentage = _tipPercentage;
@synthesize billSplit = _billSplit;
@synthesize paymentDetails = _paymentDetails;

@synthesize window = _window;

- (void)dealloc
{
    [super dealloc];
}

- (void)applicationDidFinishLaunching:(NSNotification *)aNotification
{
    // Insert code here to initialize your application
}

- (IBAction)calculate:(id)sender {
    float bill = [_billTotal floatValue];
    float percentage = [[[_tipPercentage stringValue] stringByReplacingOccurrencesOfString: @"%" withString: @""] intValue];
    int billSplit = [[[[_billSplit selectedItem] title] substringToIndex: 1] intValue];
    float totalBill = bill + (bill * (percentage / 100));
    float chargeEach = totalBill / (float)billSplit;
    
    NSNumberFormatter *currencyStyle = [[NSNumberFormatter alloc] init];
    [currencyStyle setNumberStyle: NSNumberFormatterCurrencyStyle];
    [currencyStyle setMinimumFractionDigits: 2];
    
    if (billSplit > 1)
    {
        [_paymentDetails setStringValue: [NSString stringWithFormat: @"The total bill is %@, each person pays %@", [currencyStyle stringFromNumber: [NSNumber numberWithInteger: totalBill]], [currencyStyle stringFromNumber: [NSNumber numberWithInteger: chargeEach]]]];
    }
    else
    {
        [_paymentDetails setStringValue: [NSString stringWithFormat: @"The total bill is %@", [currencyStyle stringFromNumber: [NSNumber numberWithInteger: totalBill]]]];
    }
}
@end
