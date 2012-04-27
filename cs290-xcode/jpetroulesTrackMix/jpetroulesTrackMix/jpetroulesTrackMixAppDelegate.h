//
//  jpetroulesTrackMixAppDelegate.h
//  jpetroulesTrackMix
//  CS290-01 Fall 2011
//
//  Created by Jake Petroules on 9/16/11.
//  Copyright 2011 Jake Petroules. All rights reserved.
//  This application writes a limerick to the console.
//

#import <Cocoa/Cocoa.h>

@class Track;

@interface jpetroules1TrackMixAppDelegate : NSObject <NSApplicationDelegate> {
    NSWindow *window;
    NSTextField *textField;
    NSSlider *slider;
}

@property (assign) IBOutlet NSTextField *textField;
@property (assign) IBOutlet NSSlider *slider;
@property (assign) IBOutlet NSWindow *window;
@property (retain) Track *track;

- (IBAction)takeFloatValueForVolumeFrom:(id)sender;
- (IBAction)mute:(id)sender;

@end
