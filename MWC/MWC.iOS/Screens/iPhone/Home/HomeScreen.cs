using System;
using System.Collections.Generic;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MWC.BL;

namespace MWC.iOS.Screens.iPhone.Home {
	/// <summary>
	/// Home screen contains a masthead graphic/ad
	/// plus (iPad only) "what's on" in the next two 'timeslots'
	/// and the "favorites" list.
	/// </summary>
	public partial class HomeScreen : UIViewController {
		Screens.Common.Session.SessionDayScheduleScreen dayScheduleScreen;
		UI.Controls.LoadingOverlay loadingOverlay;
		NSObject ObserverRotation;

		public HomeScreen () : base (AppDelegate.IsPhone ? "HomeScreen_iPhone" : "HomeScreen_iPad", null)
		{
		}
		
		MWC.iOS.AL.DaysTableSource tableSource = null;

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			BL.Managers.UpdateManager.UpdateFinished += HandleUpdateFinished; 
			
			if (AppDelegate.IsPhone) {
				MwcLogoImageView.Image = UIImage.FromBundle("/Images/Home");
			} else {
				// IsPad
				MwcLogoImageView.Image = UIImage.FromBundle("/Images/Home-Portrait~ipad");

				var blackView1 = new UIView();
				blackView1.BackgroundColor = UIColor.Black;
				// http://forums.macrumors.com/showthread.php?t=901706
				//this.SessionTable.Frame = new RectangleF(0,470, 320, 200);
				blackView1.Frame = new RectangleF(0,470, 320, 200);
				//this.SessionTable.BackgroundColor = UIColor.Clear;
				this.SessionTable.BackgroundView = blackView1;
				
				var blackView2 = new UIView();
				blackView2.BackgroundColor = UIColor.Black;
				blackView2.Frame = new RectangleF(0,470+210, 320, 320);
				//this.UpNextTable.Frame = new RectangleF(0,470+210, 320, 320);
				//this.UpNextTable.BackgroundColor = UIColor.Clear;
				this.UpNextTable.BackgroundView = blackView2;
				
				var blackView3 = new UIView();
				blackView3.BackgroundColor = UIColor.Black;
				blackView3.Frame = new RectangleF(768-320,470, 320, 420);
				//this.FavoritesTable.Frame = new RectangleF(768-320,470, 320, 420);
				FavoritesTable.BackgroundColor = UIColor.Black;
				this.FavoritesTable.BackgroundView = blackView3;	
			}

			//TODO: Craig, i want to look at encapsulating this at the BL layer, 
			// i don't know if that's a feasible approach, but i think this is 
			// generally a good pattern.
			//
			// if we're in the process of updating, populate the table when it's done
			// alas, if we keep it in the app layer, it gives us an opportunity to 
			// show a spinner over the table with an "updating" message.
			if(BL.Managers.UpdateManager.IsUpdating)
			{
				if (AppDelegate.IsPhone)
					loadingOverlay = new MWC.iOS.UI.Controls.LoadingOverlay (SessionTable.Frame);
				else {	// IsPad (rotates!)
					var overlayFrame = View.Frame;
					overlayFrame.Y = 330;
					overlayFrame.Height = 768 - 330;
					loadingOverlay = new MWC.iOS.UI.Controls.LoadingOverlay (overlayFrame);
					loadingOverlay.AutoresizingMask = UIViewAutoresizing.FlexibleDimensions;
				}
				View.AddSubview (loadingOverlay);
				
				Console.WriteLine("UpdateManager.IsUpdating ~ wait for them to finish");
			}
			else { PopulateTable(); }
		}
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			BL.Managers.UpdateManager.UpdateFinished -= HandleUpdateFinished; 
		}
		void HandleUpdateFinished(object sender, EventArgs e)
		{
			Console.WriteLine("Updates finished, going to populate table.");
			InvokeOnMainThread ( () => {
				PopulateTable ();
				if (loadingOverlay != null)
					loadingOverlay.Hide ();
			});
		}

		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			return AppDelegate.IsPad;
		}

		/// <summary>iPad only method</summary>
		void SessionClicked (object sender, MWC.iOS.AL.FavoriteClickedEventArgs args)
		{
			var s = new MWC.iOS.Screens.iPad.SessionPopupScreen(args.SessionClicked, this);
			s.ModalPresentationStyle = UIModalPresentationStyle.FormSheet;
			PresentModalViewController (s, true);
		}

		/// <summary>iPad only method</summary>
		public void SessionClosed(bool wasDirty) 
		{
			if (wasDirty)
				PopulateiPadTables();
		}

		protected void PopulateTable ()
		{
			tableSource = new MWC.iOS.AL.DaysTableSource();
			SessionTable.Source = tableSource;
			SessionTable.ReloadData();
			tableSource.DayClicked += delegate (object sender, MWC.iOS.AL.DayClickedEventArgs e) {
				LoadSessionDayScreen (e.DayName, e.Day);
			};
			
			if (AppDelegate.IsPad)
				PopulateiPadTables();
		}
		/// <summary>iPad only method: the UpNext and Favorites tables</summary>
		void PopulateiPadTables()
		{
			var uns = new MWC.iOS.AL.UpNextTableSource();
			UpNextTable.Source = uns;
			uns.SessionClicked += SessionClicked;
			UpNextTable.ReloadData();
			
			var fs = new MWC.iOS.AL.FavoritesTableSource();
			FavoritesTable.Source = fs;
			fs.FavoriteClicked += SessionClicked;
			FavoritesTable.ReloadData ();
		}

		/// <summary>
		/// Show the session info, push navctrl for iPhone, in a modal overlay for iPad
		/// </summary>
		protected void LoadSessionDayScreen (string dayName, int day)
		{
			if (AppDelegate.IsPhone) {
				dayScheduleScreen = new MWC.iOS.Screens.Common.Session.SessionDayScheduleScreen (dayName, day, null);
				NavigationController.PushViewController (dayScheduleScreen, true);				
			} else {
				var nvc = ParentViewController;
				var tab = nvc.ParentViewController as MWC.iOS.Screens.Common.TabBarController;
				tab.SelectedIndex = 1;
				tab.ShowSessionDay(day);
			}
		}
		
		public bool IsPortrait {
			get {
				return InterfaceOrientation == UIInterfaceOrientation.Portrait 
					|| InterfaceOrientation == UIInterfaceOrientation.PortraitUpsideDown;
			}
		}

		/// <summary>
		/// Home layout changes on rotation
		/// </summary>
		protected void OnDeviceRotated (NSNotification notification)
		{
			if (AppDelegate.IsPad) {
				if (IsPortrait) {
					MwcLogoImageView.Image = UIImage.FromBundle("/Images/Home-Portrait~ipad");
					SessionTable.Frame   = new RectangleF(0, 370, 320, 230);
					UpNextTable.Frame    = new RectangleF(0, 620, 320, 320);
					FavoritesTable.Frame = new RectangleF(768-400,370, 400, 560);
				}
				else
				{	// IsLandscape
					MwcLogoImageView.Image = UIImage.FromBundle("/Images/Home-Landscape~ipad");
					SessionTable.Frame   = new RectangleF(0,   310, 320, 320);
					UpNextTable.Frame    = new RectangleF(350, 310, 320, 320);
					FavoritesTable.Frame = new RectangleF(704, 310, 320, 380);
				}
			}
		}

		/// <summary>
		/// Is called when the view is about to appear on the screen. We use this method to hide the 
		/// navigation bar.
		/// </summary>
		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			NavigationController.SetNavigationBarHidden (true, animated);
			
			if (AppDelegate.IsPad) {
				OnDeviceRotated(null);
				
				// We attempt to re-populate to refresh the 'Favorites' and 'Up Next' lists (which need to change over time)
				if (!BL.Managers.UpdateManager.IsUpdating)
					PopulateiPadTables();
			
				ObserverRotation = NSNotificationCenter.DefaultCenter.AddObserver("UIDeviceOrientationDidChangeNotification", OnDeviceRotated);
				UIDevice.CurrentDevice.BeginGeneratingDeviceOrientationNotifications();
			}
		}
		
		/// <summary>
		/// Is called when the another view will appear and this one will be hidden. We use this method
		/// to show the navigation bar again.
		/// </summary>
		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
			NavigationController.SetNavigationBarHidden (false, animated);
	
			if (AppDelegate.IsPad) {
				UIDevice.CurrentDevice.EndGeneratingDeviceOrientationNotifications();
				NSNotificationCenter.DefaultCenter.RemoveObserver(ObserverRotation);
			}
		}
	}
}