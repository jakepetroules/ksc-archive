//
//  controller.h
//  mpgCalc
//
//  Created by Jake Petroules _ on 4/7/10.
//  Copyright 2010 __MyCompanyName__. All rights reserved.
//

#import <Foundation/Foundation.h>


@interface controller : NSObject {

	IBOutlet UITextField* distanceTraveledField;
	IBOutlet UITextField* fuelUsedField;
	IBOutlet UITextField* fuelEfficiencyField;
}

- (IBAction)calculateFuelEfficiency:(id)sender;

@end
