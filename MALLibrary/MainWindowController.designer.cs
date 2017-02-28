// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MALLibrary
{
	[Register ("MainWindowController")]
	partial class MainWindowController
	{
		[Outlet]
		AppKit.NSPopover addpopover { get; set; }

		[Outlet]
		AppKit.NSTextField addpopoverepifield { get; set; }

		[Outlet]
		Foundation.NSNumberFormatter addpopoverformat { get; set; }

		[Outlet]
		AppKit.NSPopUpButton addpopoverscore { get; set; }

		[Outlet]
		AppKit.NSPopUpButton addpopoverstatus { get; set; }

		[Outlet]
		AppKit.NSTextField addpopovertotal { get; set; }

		[Outlet]
		AppKit.NSProgressIndicator addprogressview { get; set; }

		[Outlet]
		AppKit.NSButton addtitlebutton { get; set; }

		[Outlet]
		AppKit.NSView addtitleexists { get; set; }

		[Outlet]
		AppKit.NSTextField addtitlelbl { get; set; }

		[Outlet]
		AppKit.NSView addtitleview { get; set; }

		[Outlet]
		AppKit.NSTextField alternativetitlelbl { get; set; }

		[Outlet]
		AppKit.NSTextField animeinfotitle { get; set; }

		[Outlet]
		AppKit.NSView animeinfoview { get; set; }

		[Outlet]
		AppKit.NSArrayController animelistarraycontroller { get; set; }

		[Outlet]
		AppKit.NSTableView animetb { get; set; }

		[Outlet]
		AppKit.NSTextView backgroundtextview { get; set; }

		[Outlet]
		AppKit.NSTextView detailstextview { get; set; }

		[Outlet]
		AppKit.NSSearchField Filter { get; set; }

		[Outlet]
		AppKit.NSButton filtercompleted { get; set; }

		[Outlet]
		AppKit.NSButton filterdropped { get; set; }

		[Outlet]
		AppKit.NSButton filteronhold { get; set; }

		[Outlet]
		AppKit.NSButton filterplantowatch { get; set; }

		[Outlet]
		AppKit.NSButton filterwatching { get; set; }

		[Outlet]
		AppKit.NSVisualEffectView listloggedoutview { get; set; }

		[Outlet]
		AppKit.NSView listview { get; set; }

		[Outlet]
		AppKit.NSProgressIndicator loadingwheel { get; set; }

		[Outlet]
		AppKit.NSTextField loggedinuser { get; set; }

		[Outlet]
		AppKit.NSView mainview { get; set; }

		[Outlet]
		AppKit.NSPopover minieditpopover { get; set; }

		[Outlet]
		AppKit.NSButton minieditpopoveredit { get; set; }

		[Outlet]
		AppKit.NSTextField miniedittitle { get; set; }

		[Outlet]
		AppKit.NSTextField minipopupeditstatus { get; set; }

		[Outlet]
		AppKit.NSTextField minipopupeepi { get; set; }

		[Outlet]
		Foundation.NSNumberFormatter minipopupepiformat { get; set; }

		[Outlet]
		AppKit.NSProgressIndicator minipopupprogressindicatoor { get; set; }

		[Outlet]
		AppKit.NSPopUpButton minipopupscore { get; set; }

		[Outlet]
		AppKit.NSPopUpButton minipopupstatus { get; set; }

		[Outlet]
		AppKit.NSTextField minipopuptotalepi { get; set; }

		[Outlet]
		AppKit.NSView noinfo { get; set; }

		[Outlet]
		AppKit.NSImageView posterimage { get; set; }

		[Outlet]
		AppKit.NSView progressview { get; set; }

		[Outlet]
		AppKit.NSArrayController searcharraycontroller { get; set; }

		[Outlet]
		AppKit.NSSearchField searchbox { get; set; }

		[Outlet]
		AppKit.NSView searchview { get; set; }

		[Outlet]
		AppKit.NSArrayController seasonarraycontroller { get; set; }

		[Outlet]
		AppKit.NSPopUpButton seasonselect { get; set; }

		[Outlet]
		AppKit.NSView seasonsview { get; set; }

		[Outlet]
		AppKit.NSTableView seasontb { get; set; }

		[Outlet]
		AppKit.NSPopUpButton seasonyrselect { get; set; }

		[Outlet]
		MALLibrary.SourceListView sourcelist { get; set; }

		[Outlet]
		AppKit.NSTableView stb { get; set; }

		[Outlet]
		AppKit.NSTextView synopsistextview { get; set; }

		[Outlet]
		AppKit.NSToolbar toolbar { get; set; }

		[Outlet]
		AppKit.NSWindow w { get; set; }

		[Action ("addpopoveraddtitle:")]
		partial void addpopoveraddtitle (Foundation.NSObject sender);

		[Action ("addtitle:")]
		partial void addtitle (Foundation.NSObject sender);

		[Action ("animelistdoubleclick:")]
		partial void animelistdoubleclick (Foundation.NSObject sender);

		[Action ("edittitle:")]
		partial void edittitle (Foundation.NSObject sender);

		[Action ("minieditstatuschanged:")]
		partial void minieditstatuschanged (Foundation.NSObject sender);

		[Action ("opensharemenu:")]
		partial void opensharemenu (Foundation.NSObject sender);

		[Action ("performeditminipopover:")]
		partial void performeditminipopover (Foundation.NSObject sender);

		[Action ("performfilter:")]
		partial void performfilter (Foundation.NSObject sender);

		[Action ("performrefresh:")]
		partial void performrefresh (Foundation.NSObject sender);

		[Action ("performsearch:")]
		partial void performsearch (Foundation.NSObject sender);

		[Action ("performstatusfilter:")]
		partial void performstatusfilter (Foundation.NSObject sender);

		[Action ("removetitle:")]
		partial void removetitle (Foundation.NSObject sender);

		[Action ("returnpreviousview:")]
		partial void returnpreviousview (Foundation.NSObject sender);

		[Action ("searchtbdoubleclick:")]
		partial void searchtbdoubleclick (Foundation.NSObject sender);

		[Action ("seasonchanged:")]
		partial void seasonchanged (Foundation.NSObject sender);

		[Action ("seasontbdoubleclicked:")]
		partial void seasontbdoubleclicked (Foundation.NSObject sender);

		[Action ("selectmainview:")]
		partial void selectmainview (Foundation.NSObject sender);

		[Action ("viewloginpref:")]
		partial void viewloginpref (Foundation.NSObject sender);

		[Action ("viewonmal:")]
		partial void viewonmal (Foundation.NSObject sender);

		[Action ("yearchanged:")]
		partial void yearchanged (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (addtitlelbl != null) {
				addtitlelbl.Dispose ();
				addtitlelbl = null;
			}

			if (addpopover != null) {
				addpopover.Dispose ();
				addpopover = null;
			}

			if (addpopoverepifield != null) {
				addpopoverepifield.Dispose ();
				addpopoverepifield = null;
			}

			if (addpopoverformat != null) {
				addpopoverformat.Dispose ();
				addpopoverformat = null;
			}

			if (addpopoverscore != null) {
				addpopoverscore.Dispose ();
				addpopoverscore = null;
			}

			if (addpopoverstatus != null) {
				addpopoverstatus.Dispose ();
				addpopoverstatus = null;
			}

			if (addpopovertotal != null) {
				addpopovertotal.Dispose ();
				addpopovertotal = null;
			}

			if (addprogressview != null) {
				addprogressview.Dispose ();
				addprogressview = null;
			}

			if (addtitlebutton != null) {
				addtitlebutton.Dispose ();
				addtitlebutton = null;
			}

			if (addtitleexists != null) {
				addtitleexists.Dispose ();
				addtitleexists = null;
			}

			if (addtitleview != null) {
				addtitleview.Dispose ();
				addtitleview = null;
			}

			if (alternativetitlelbl != null) {
				alternativetitlelbl.Dispose ();
				alternativetitlelbl = null;
			}

			if (animeinfotitle != null) {
				animeinfotitle.Dispose ();
				animeinfotitle = null;
			}

			if (animeinfoview != null) {
				animeinfoview.Dispose ();
				animeinfoview = null;
			}

			if (animelistarraycontroller != null) {
				animelistarraycontroller.Dispose ();
				animelistarraycontroller = null;
			}

			if (animetb != null) {
				animetb.Dispose ();
				animetb = null;
			}

			if (backgroundtextview != null) {
				backgroundtextview.Dispose ();
				backgroundtextview = null;
			}

			if (detailstextview != null) {
				detailstextview.Dispose ();
				detailstextview = null;
			}

			if (Filter != null) {
				Filter.Dispose ();
				Filter = null;
			}

			if (filtercompleted != null) {
				filtercompleted.Dispose ();
				filtercompleted = null;
			}

			if (filterdropped != null) {
				filterdropped.Dispose ();
				filterdropped = null;
			}

			if (filteronhold != null) {
				filteronhold.Dispose ();
				filteronhold = null;
			}

			if (filterplantowatch != null) {
				filterplantowatch.Dispose ();
				filterplantowatch = null;
			}

			if (filterwatching != null) {
				filterwatching.Dispose ();
				filterwatching = null;
			}

			if (listloggedoutview != null) {
				listloggedoutview.Dispose ();
				listloggedoutview = null;
			}

			if (listview != null) {
				listview.Dispose ();
				listview = null;
			}

			if (loadingwheel != null) {
				loadingwheel.Dispose ();
				loadingwheel = null;
			}

			if (loggedinuser != null) {
				loggedinuser.Dispose ();
				loggedinuser = null;
			}

			if (mainview != null) {
				mainview.Dispose ();
				mainview = null;
			}

			if (minieditpopover != null) {
				minieditpopover.Dispose ();
				minieditpopover = null;
			}

			if (minieditpopoveredit != null) {
				minieditpopoveredit.Dispose ();
				minieditpopoveredit = null;
			}

			if (miniedittitle != null) {
				miniedittitle.Dispose ();
				miniedittitle = null;
			}

			if (minipopupeditstatus != null) {
				minipopupeditstatus.Dispose ();
				minipopupeditstatus = null;
			}

			if (minipopupeepi != null) {
				minipopupeepi.Dispose ();
				minipopupeepi = null;
			}

			if (minipopupepiformat != null) {
				minipopupepiformat.Dispose ();
				minipopupepiformat = null;
			}

			if (minipopupprogressindicatoor != null) {
				minipopupprogressindicatoor.Dispose ();
				minipopupprogressindicatoor = null;
			}

			if (minipopupscore != null) {
				minipopupscore.Dispose ();
				minipopupscore = null;
			}

			if (minipopupstatus != null) {
				minipopupstatus.Dispose ();
				minipopupstatus = null;
			}

			if (minipopuptotalepi != null) {
				minipopuptotalepi.Dispose ();
				minipopuptotalepi = null;
			}

			if (noinfo != null) {
				noinfo.Dispose ();
				noinfo = null;
			}

			if (posterimage != null) {
				posterimage.Dispose ();
				posterimage = null;
			}

			if (progressview != null) {
				progressview.Dispose ();
				progressview = null;
			}

			if (searcharraycontroller != null) {
				searcharraycontroller.Dispose ();
				searcharraycontroller = null;
			}

			if (searchbox != null) {
				searchbox.Dispose ();
				searchbox = null;
			}

			if (searchview != null) {
				searchview.Dispose ();
				searchview = null;
			}

			if (seasonarraycontroller != null) {
				seasonarraycontroller.Dispose ();
				seasonarraycontroller = null;
			}

			if (seasonselect != null) {
				seasonselect.Dispose ();
				seasonselect = null;
			}

			if (seasonsview != null) {
				seasonsview.Dispose ();
				seasonsview = null;
			}

			if (seasontb != null) {
				seasontb.Dispose ();
				seasontb = null;
			}

			if (seasonyrselect != null) {
				seasonyrselect.Dispose ();
				seasonyrselect = null;
			}

			if (sourcelist != null) {
				sourcelist.Dispose ();
				sourcelist = null;
			}

			if (stb != null) {
				stb.Dispose ();
				stb = null;
			}

			if (synopsistextview != null) {
				synopsistextview.Dispose ();
				synopsistextview = null;
			}

			if (toolbar != null) {
				toolbar.Dispose ();
				toolbar = null;
			}

			if (w != null) {
				w.Dispose ();
				w = null;
			}
		}
	}
}
