//
//  AdvancedSearch.h
//  MAL Library
//
//  Created by 天々座理世 on 2017/03/29.
//  Copyright © 2017年 Atelier Shiori. All rights reserved.
//

#import <Cocoa/Cocoa.h>
@class MainWindow;
@class NSTextFieldNumber;
@interface AdvancedSearch : NSViewController{
    IBOutlet MainWindow * mw;
    IBOutlet NSPopover * popover;
}
@property (strong) IBOutlet NSTokenField *genretokenfield;
@property (strong) IBOutlet NSButton *exclude;
@property (strong) IBOutlet NSDatePicker *startdate;
@property (strong) IBOutlet NSDatePicker *enddate;
@property (strong) IBOutlet NSTextFieldNumber *minscore;
@property (strong) IBOutlet NSButton *usestartdate;
@property (strong) IBOutlet NSButton *useenddate;
@property (strong) IBOutlet NSPopUpButton *airstatus;
@property (strong) IBOutlet NSPopUpButton *rating;
@property (strong) IBOutlet NSMenu *animestatusmenu;
@property (strong) IBOutlet NSMenu *mangastatusmenu;

@property (strong) IBOutlet NSSearchField *searchfield;
- (IBAction)performadvancedsearch:(id)sender;
- (void)setSearchType:(int)type;
@end
