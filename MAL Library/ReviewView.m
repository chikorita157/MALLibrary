//
//  ReviewView.m
//  Shukofukurou
//
//  Created by 天々座理世 on 2017/04/23.
//  Copyright © 2017年 MAL Updater OS X Group. All rights reserved.
//

#import "ReviewView.h"
#import "NSTextView+SetHTMLAttributedText.h"
#import "Utility.h"
#import "AppDelegate.h"
#import "ProfileWindowController.h"
#import "listservice.h"
#import "RatingTwentyConvert.h"
#import "AniListScoreConvert.h"
#import <SDWebImage/UIImageView+WebCache.h>

@interface ReviewView ()
@property (strong) NSString *profile_username;
@end

@implementation ReviewView

- (instancetype)init {
    return [super initWithNibName:@"ReviewView" bundle:nil];
}

- (void)viewDidLoad {
    [super viewDidLoad];
    // Do view setup here.
    if (@available(macOS 10.14, *)) {
        return;
    }
    else {
        [self.view setWantsLayer:YES];
        self.view.layer.backgroundColor = [NSColor whiteColor].CGColor;
    }
}

- (void)loadReview:(NSDictionary *)review type:(int)type {
    int currentservice = [listservice.sharedInstance getCurrentServiceID];
    _reviewerusername.stringValue = review[@"username"];
    if (currentservice == 2) {
        _profile_username = review[@"actual_username"];
    }
    switch (currentservice) {
        case 1:
        case 3:
            if (currentservice == 1) {
                _reviewerscore.stringValue = [NSString stringWithFormat:@"Score: %@", review[@"rating"]];
                _episodeswatched.hidden = false;
            
            }
            else {
                _reviewerscore.stringValue = [NSString stringWithFormat:@"Score: %@", [AniListScoreConvert convertAniListScoreToActualScore:((NSNumber *)review[@"rating"]).intValue withScoreType:[NSUserDefaults.standardUserDefaults valueForKey:@"anilist-scoreformat"]]];
                _episodeswatched.hidden = true;
            }
            _reviewdatelabel.stringValue = [NSString stringWithFormat:@"Reviewed on %@", [Utility stringDatetoLocalizedDateString:(NSString *)review[@"date"]]];
            break;
        case 2:
            _reviewerscore.stringValue = [NSString stringWithFormat:@"Score: %@",  [RatingTwentyConvert convertRatingTwentyToActualScore:((NSNumber *)review[@"rating"]).intValue scoretype:(int)[NSUserDefaults.standardUserDefaults integerForKey:@"kitsu-ratingsystem"]]];
            _reviewdatelabel.stringValue = [NSString stringWithFormat:@"Reacted on %@", [Utility stringDatetoLocalizedDateString:(NSString *)review[@"date"]]];
            _episodeswatched.hidden = false;
            break;
        default:
            break;
    }
    if (type == 0) {
         _episodeswatched.stringValue = [NSString stringWithFormat:@"Episodes watched: %@", review[@"watched_episodes"]];
    }
    else {
         _episodeswatched.stringValue = [NSString stringWithFormat:@"Chapters read: %@", review[@"chapters_read"]];
    }
    if (review[@"helpful"]) {
        NSNumber *helpful = review[@"helpful"];
        if (helpful.intValue == 1) {
            switch (currentservice) {
                case 1:
                case 3:
                    _reviewhelpful.stringValue = [NSString stringWithFormat:@"%i user find this review helpful", helpful.intValue];
                    break;
                case 2:
                    _reviewhelpful.stringValue = [NSString stringWithFormat:@"%i user liked this", helpful.intValue];
                    break;
                default:
                    break;
            }
        }
        else {
            switch (currentservice) {
                case 1:
                case 3:
                    _reviewhelpful.stringValue = [NSString stringWithFormat:@"%i users find this review helpful", helpful.intValue];
                    break;
                case 2:
                    _reviewhelpful.stringValue = [NSString stringWithFormat:@"%i users liked this", helpful.intValue];
                    break;
                default:
                    break;
            }
        }
    }
    __weak ReviewView *weakSelf = self;
    if (currentservice == 1) {
        _reviewtext.string = [(NSString *)review[@"review"] stringByReplacingOccurrencesOfString:@"\\n\\n" withString:@"\n\n"];
    }
    else {
        [_reviewtext setTextToHTML:(NSString *)review[@"review"] withLoadingText:@"Loading review..." completion:^(NSAttributedString * _Nonnull astr) {
            [weakSelf.reviewtext scrollToBeginningOfDocument:weakSelf];
            [weakSelf.reviewtext scrollToBeginningOfDocument:weakSelf];
            weakSelf.reviewtext.textColor = NSColor.controlTextColor;
        }];
    }
    if (((NSString *)review[@"avatar_url"]).length > 0) {
        [_revieweravatar sd_setImageWithURL:review[@"avatar_url"]];
    }
    else {
        _revieweravatar.image = [NSImage imageNamed:@"noimage"];
    }
}

- (IBAction)viewreviewerprofile:(id)sender {
    if ([NSUserDefaults.standardUserDefaults boolForKey:@"donated"]) {
        ProfileWindowController *pwc = [(AppDelegate *)NSApplication.sharedApplication.delegate getProfileWindow];
        [pwc.window makeKeyAndOrderFront:self];
        switch ([listservice.sharedInstance getCurrentServiceID]) {
            case 1:
                [pwc loadProfileWithUsername:_reviewerusername.stringValue];
                break;
            case 2:
                [pwc loadProfileWithUsername:_profile_username];
                break;
            case 3:
                [pwc loadProfileWithUsername:_reviewerusername.stringValue];
                break;
            default:
                break;
        }
    }
    else {
        switch ([listservice.sharedInstance getCurrentServiceID]) {
            case 1:
                [[NSWorkspace sharedWorkspace] openURL:[NSURL URLWithString:[NSString stringWithFormat:@"https://myanimelist.net/profile/%@",_reviewerusername.stringValue]]];
                break;
            case 2:
                 [[NSWorkspace sharedWorkspace] openURL:[NSURL URLWithString:[NSString stringWithFormat:@"https://kitsu.io/users/%@",_profile_username]]];
                break;
            case 3:
                [[NSWorkspace sharedWorkspace] openURL:[NSURL URLWithString:[NSString stringWithFormat:@"https://anilist.co/user/%@/",_reviewerusername.stringValue]]];
                break;
            default:
                break;
        }
    }
}
@end
