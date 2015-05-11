
using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;

namespace Example_StandardControls.Screens.iPhone.Switches
{
	public partial class Switches_iPhone : UIViewController
	{
		#region Constructors

		// The IntPtr and initWithCoder constructors are required for controllers that need 
		// to be able to be created from a xib rather than from managed code

		public Switches_iPhone (IntPtr handle) : base(handle)
		{
			Initialize ();
		}

		[Export("initWithCoder:")]
		public Switches_iPhone (NSCoder coder) : base(coder)
		{
			Initialize ();
		}

		public Switches_iPhone () : base("Switches_iPhone", null)
		{
			Initialize ();
		}

		void Initialize ()
		{
		}
		
		#endregion
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			Title = "Switches";
			
			
			swchOne.ValueChanged += delegate {
				new UIAlertView ("Switch one change!", "is on: " + swchOne.On.ToString (), null, "OK", null).Show ();
			};
			swchTwo.ValueChanged += delegate {
				new UIAlertView ("Switch two change!", "is on: " + swchTwo.On.ToString (), null, "OK", null).Show ();
			};
		}
		
		
	}
}

