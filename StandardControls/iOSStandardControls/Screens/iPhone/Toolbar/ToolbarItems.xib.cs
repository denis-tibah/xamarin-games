
using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;

namespace Example_StandardControls.Screens.iPhone.Toolbar
{
	public partial class ToolbarItems : UIViewController
	{
		#region Constructors

		// The IntPtr and initWithCoder constructors are required for items that need 
		// to be able to be created from a xib rather than from managed code

		public ToolbarItems (IntPtr handle) : base(handle)
		{
			Initialize ();
		}

		[Export("initWithCoder:")]
		public ToolbarItems (NSCoder coder) : base(coder)
		{
			Initialize ();
		}

		public ToolbarItems () : base("ToolbarItems", null)
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
			
			Title = "Various toolbar items";
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			return toInterfaceOrientation == UIInterfaceOrientation.LandscapeLeft || toInterfaceOrientation == UIInterfaceOrientation.LandscapeRight;
		}
	}
}

