
using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;
using Example_StandardControls.Controls;

namespace Example_StandardControls.Screens.iPad.DatePicker
{
	public partial class ActionSheetDatePicker_iPad : UIViewController
	{
		
		UIViewDatePicker actionSheetDatePicker;
		UIViewDatePicker actionSheetTimerPicker;
	
		#region Constructors

		// The IntPtr and initWithCoder constructors are required for controllers that need 
		// to be able to be created from a xib rather than from managed code

		public ActionSheetDatePicker_iPad (IntPtr handle) : base(handle)
		{
			Initialize ();
		}

		[Export("initWithCoder:")]
		public ActionSheetDatePicker_iPad (NSCoder coder) : base(coder)
		{
			Initialize ();
		}

		public ActionSheetDatePicker_iPad () : base("ActionSheetDatePicker_iPad", null)
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
			
			Title = "Date Picker";
			
			// setup our custom action sheet date picker
			actionSheetDatePicker = new UIViewDatePicker (View);
			actionSheetDatePicker.Title = "Choose Date:";
			actionSheetDatePicker.DatePicker.ValueChanged += Handle_actionSheetDatePickerDatePickerValueChanged;
			actionSheetDatePicker.DatePicker.Mode = UIDatePickerMode.DateAndTime;
			actionSheetDatePicker.DatePicker.MinimumDate = (NSDate)DateTime.Today.AddDays (-7);
			actionSheetDatePicker.DatePicker.MaximumDate = (NSDate)DateTime.Today.AddDays (7);
			btnChooseDate.TouchUpInside += (s, e) => { actionSheetDatePicker.Show (); };
			
			// setup our countdown timer 
			actionSheetTimerPicker = new UIViewDatePicker (View);
			actionSheetTimerPicker.Title = "Choose Time:";
			actionSheetTimerPicker.DatePicker.Mode = UIDatePickerMode.CountDownTimer;
		}

		protected void Handle_actionSheetDatePickerDatePickerValueChanged (object sender, EventArgs e)
		{
			lblDate.Text = ((UIDatePicker)sender).Date.ToString ();
		}
	
		
	}
}

