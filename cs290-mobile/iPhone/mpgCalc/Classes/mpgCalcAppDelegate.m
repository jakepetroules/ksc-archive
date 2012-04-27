//
//  mpgCalcAppDelegate.m
//  mpgCalc
//
//  Created by Jake Petroules _ on 4/7/10.
//  Copyright __MyCompanyName__ 2010. All rights reserved.
//

#import "mpgCalcAppDelegate.h"

@implementation mpgCalcAppDelegate

@synthesize window;


- (BOOL)application:(UIApplication *)application didFinishLaunchingWithOptions:(NSDictionary *)launchOptions {    

    // Override point for customization after application launch
	
    [window makeKeyAndVisible];
	
	return YES;
}


- (void)dealloc {
    [window release];
    [super dealloc];
}


@end
