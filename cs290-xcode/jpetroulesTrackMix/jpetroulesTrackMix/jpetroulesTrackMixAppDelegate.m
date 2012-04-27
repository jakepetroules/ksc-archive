//
//  jpetroulesTrackMixAppDelegate.m
//  jpetroulesTrackMix
//  CS290-01 Fall 2011
//
//  Created by Jake Petroules on 9/16/11.
//  Copyright 2011 Jake Petroules. All rights reserved.
//  This application writes a limerick to the console.
//

#import "jpetroulesTrackMixAppDelegate.h"
#import "Track.h"

@interface jpetroules1TrackMixAppDelegate (PrivateMethods)
- (void)updateUserInterface;
@end

@implementation jpetroules1TrackMixAppDelegate

@synthesize textField;
@synthesize slider;
@synthesize window;
@synthesize track;

- (void)dealloc
{
    [track release];
    [super dealloc];
}

- (void)awakeFromNib
{
    // Create the track object and synchronize the user interface
    Track *aTrack = [[Track alloc] init];
    [self setTrack: aTrack];
    [aTrack release];
    
    [self updateUserInterface];
}

- (IBAction)takeFloatValueForVolumeFrom:(id)sender
{
    // Get the new volume value from the object that sent it (either the slider or text field)
    float newValue = [sender floatValue];
    
    // Update our track object with the new volume
    [self.track setVolume: newValue];
    
    // Synchronize the user interface to our model
    [self updateUserInterface];
}

- (IBAction)mute:(id)sender
{
    // Set the volume to 0 and sync the UI
    [self.track setVolume:0.0];
    [self updateUserInterface];
}

- (void)updateUserInterface
{
    // Get the volume from our model object and update both the text field and slider
    float volume = [self.track volume];
    [self.textField setFloatValue:volume];
    [self.slider setFloatValue:volume];
}
@end
