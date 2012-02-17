using MonoTouch.UIKit;
using System.Drawing;
using System;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MWC.iOS.Screens.iPhone.Speakers;

/* https://github.com/grgcombs/IntelligentSplitViewController/blob/master/IntelligentSplitViewController.m */
namespace MWC.iOS.Screens.iPad.Speakers {
	public class SpeakerSplitView : UISplitViewController {
		SpeakersScreen speakersList;
		SpeakerSessionMasterDetail speakerDetailWithSession;
		
		NSObject ObserverWillRotate;
		NSObject ObserverDidRotate;

		public SpeakerSplitView ()
		{
			Delegate = new SpeakerSplitViewDelegate();
			
			speakersList = new SpeakersScreen(this);
			speakerDetailWithSession = new SpeakerSessionMasterDetail(-1);
			
			ViewControllers = new UIViewController[]
				{speakersList, speakerDetailWithSession};

			ObserverWillRotate = NSNotificationCenter.DefaultCenter.AddObserver(
					"UIApplicationWillChangeStatusBarOrientationNotification", OnWillRotate);			
			ObserverDidRotate = NSNotificationCenter.DefaultCenter.AddObserver(
					"UIApplicationDidChangeStatusBarOrientationNotification", OnDidRotate);			
		}
		~SpeakerSplitView () {
			NSNotificationCenter.DefaultCenter.RemoveObserver(ObserverWillRotate);
			NSNotificationCenter.DefaultCenter.RemoveObserver(ObserverDidRotate);
		}
		protected void OnWillRotate (NSNotification notification)
		{
			if (!IsViewLoaded) return;
			if (notification == null) return;

			var o1 = notification.UserInfo.ValueForKey(new NSString("UIApplicationStatusBarOrientationUserInfoKey"));
			int o2 = Convert.ToInt32(o1.ToString ());
			UIInterfaceOrientation toOrientation =(UIInterfaceOrientation) o2;
			var notModal = !(TabBarController.ModalViewController == null);
			var isSelectedTab = (TabBarController.SelectedViewController == this);

			//Console.WriteLine ("toOrientation:"+toOrientation);
			//Console.WriteLine ("isSelectedTab:"+isSelectedTab);

			var duration = UIApplication.SharedApplication.StatusBarOrientationAnimationDuration;

			if (!isSelectedTab || !notModal) {
				base.WillRotate (toOrientation, duration);
				
				UIViewController master = ViewControllers[0];
				var theDelegate = Delegate;
				
				//YOU_DONT_FEEL_QUEAZY_ABOUT_THIS_BECAUSE_IT_PASSES_THE_APP_STORE
				UIBarButtonItem button = base.ValueForKey (new NSString("_barButtonItem")) as UIBarButtonItem;
				
				
				if (toOrientation == UIInterfaceOrientation.Portrait
				|| toOrientation == UIInterfaceOrientation.PortraitUpsideDown) {
					if (theDelegate != null && theDelegate.RespondsToSelector(new Selector("splitViewController:willHideViewController:withBarButtonItem:forPopoverController:"))) {
						try {
							UIPopoverController popover = base.ValueForKey(new NSString("_hiddenPopoverController")) as UIPopoverController;
							theDelegate.WillHideViewController(this, master, button, popover);
						} catch (Exception e) {
							Console.WriteLine ("There was a nasty error while notifyng splitviewcontrollers of a portrait orientation change: " + e.Message);
						}
					}
		
				} else {
					if (theDelegate != null && theDelegate.RespondsToSelector(new Selector("splitViewController:willShowViewController:invalidatingBarButtonItem:"))) {
						try {
							theDelegate.WillShowViewController (this, master, button);
						} catch (Exception e) {
							Console.WriteLine ("There was a nasty error while notifyng splitviewcontrollers of a landscape orientation change: " + e.Message);
						}
					}
				}
	
			}


		}
		protected void OnDidRotate (NSNotification notification)
		{
			if (!IsViewLoaded) return;
			if (notification == null) return;

			var o1 = notification.UserInfo.ValueForKey(new NSString("UIApplicationStatusBarOrientationUserInfoKey"));
			int o2 = Convert.ToInt32(o1.ToString ());
			UIInterfaceOrientation toOrientation =(UIInterfaceOrientation) o2;
			var notModal = !(TabBarController.ModalViewController == null);
			var isSelectedTab = (TabBarController.SelectedViewController == this);
			if (!isSelectedTab || !notModal) {
				base.DidRotate(toOrientation);
			}
		}
		public void ShowSpeaker (int speakerID)
		{
			speakerDetailWithSession = this.ViewControllers[1] as SpeakerSessionMasterDetail;
			speakerDetailWithSession.Update(speakerID);
		}
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
        {
            return true;
        }
	}

 	public class SpeakerSplitViewDelegate : UISplitViewControllerDelegate
    {
		public override bool ShouldHideViewController (UISplitViewController svc, UIViewController viewController, UIInterfaceOrientation inOrientation)
		{
			return inOrientation == UIInterfaceOrientation.Portrait
				|| inOrientation == UIInterfaceOrientation.PortraitUpsideDown;
		}

		public override void WillHideViewController (UISplitViewController svc, UIViewController aViewController, UIBarButtonItem barButtonItem, UIPopoverController pc)
		{
			SpeakerSessionMasterDetail dvc = svc.ViewControllers[1] as SpeakerSessionMasterDetail;
			
			if (dvc != null) {
				dvc.AddNavBarButton (barButtonItem);
				dvc.Popover = pc;
			}
		}
		
		public override void WillShowViewController (UISplitViewController svc, UIViewController aViewController, UIBarButtonItem button)
		{
			SpeakerSessionMasterDetail dvc = svc.ViewControllers[1] as SpeakerSessionMasterDetail;
			
			if (dvc != null) {
				dvc.RemoveNavBarButton ();
				dvc.Popover = null;
			}
		}
	}
}