using System;
using UIKit;
using System.Drawing;
using CoreGraphics;
using Example_StandardControls.Controls;

namespace Example_StandardControls.Screens.iPhone.PagerControl
{
	public class Controller_1 : UIViewController
	{
		UILabel lblMain;

		#region -= constructors =-

		public Controller_1 () : base()
		{
		}
		
		#endregion
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// set the background color of the view to white
			View.BackgroundColor = UIColor.White;
			
			lblMain = new UILabel (new CGRect (20, 200, 280, 33));
			lblMain.Text = "Controller 1";
			lblMain.BackgroundColor = UIColor.Clear;
			View.AddSubview (lblMain);
		}
		
	}
}
