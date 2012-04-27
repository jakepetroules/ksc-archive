//
//  controller.m
//  mpgCalc
//
//  Created by Jake Petroules _ on 4/7/10.
//  Copyright 2010 __MyCompanyName__. All rights reserved.
//

#import "controller.h"


@implementation controller

- (void)awakeFromNib
{
	[distanceTraveledField becomeFirstResponder];
}

- (IBAction)calculateFuelEfficiency:(id)sender;
{
	static BOOL toggle = YES;
	
	if (toggle)
	{
		toggle = NO;
		
		NSString* distanceTraveledFieldText = distanceTraveledField.text;
		float distTraveled = [distanceTraveledFieldText floatValue];
		
		NSString* fuelUsedFieldText = fuelUsedField.text;
		float fuelUsed = [fuelUsedFieldText floatValue];
		
		fuelEfficiencyField.text = [NSString stringWithFormat:@"%.02f", distTraveled / fuelUsed];
	}
	else
	{
		toggle = YES;
	}
}

@end
