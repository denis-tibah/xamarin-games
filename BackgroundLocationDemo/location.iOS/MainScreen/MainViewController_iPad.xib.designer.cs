// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Location.iOS.MainScreen {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("MainViewController_iPad")]
	public partial class MainViewController_iPad {
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		private MonoTouch.UIKit.UILabel __mt_lblAltitude;
		
		private MonoTouch.UIKit.UILabel __mt_lblCourse;
		
		private MonoTouch.UIKit.UILabel __mt_lblLatitude;
		
		private MonoTouch.UIKit.UILabel __mt_lblLongitude;
		
		private MonoTouch.UIKit.UILabel __mt_lblMagneticHeading;
		
		private MonoTouch.UIKit.UILabel __mt_lblSpeed;
		
		private MonoTouch.UIKit.UILabel __mt_lblTrueHeading;
		
		private MonoTouch.UIKit.UILabel __mt_lblDistanceToParis;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("view")]
		private MonoTouch.UIKit.UIView view {
			get {
				this.__mt_view = ((MonoTouch.UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("lblAltitude")]
		private MonoTouch.UIKit.UILabel lblAltitude {
			get {
				this.__mt_lblAltitude = ((MonoTouch.UIKit.UILabel)(this.GetNativeField("lblAltitude")));
				return this.__mt_lblAltitude;
			}
			set {
				this.__mt_lblAltitude = value;
				this.SetNativeField("lblAltitude", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("lblCourse")]
		private MonoTouch.UIKit.UILabel lblCourse {
			get {
				this.__mt_lblCourse = ((MonoTouch.UIKit.UILabel)(this.GetNativeField("lblCourse")));
				return this.__mt_lblCourse;
			}
			set {
				this.__mt_lblCourse = value;
				this.SetNativeField("lblCourse", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("lblLatitude")]
		private MonoTouch.UIKit.UILabel lblLatitude {
			get {
				this.__mt_lblLatitude = ((MonoTouch.UIKit.UILabel)(this.GetNativeField("lblLatitude")));
				return this.__mt_lblLatitude;
			}
			set {
				this.__mt_lblLatitude = value;
				this.SetNativeField("lblLatitude", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("lblLongitude")]
		private MonoTouch.UIKit.UILabel lblLongitude {
			get {
				this.__mt_lblLongitude = ((MonoTouch.UIKit.UILabel)(this.GetNativeField("lblLongitude")));
				return this.__mt_lblLongitude;
			}
			set {
				this.__mt_lblLongitude = value;
				this.SetNativeField("lblLongitude", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("lblMagneticHeading")]
		private MonoTouch.UIKit.UILabel lblMagneticHeading {
			get {
				this.__mt_lblMagneticHeading = ((MonoTouch.UIKit.UILabel)(this.GetNativeField("lblMagneticHeading")));
				return this.__mt_lblMagneticHeading;
			}
			set {
				this.__mt_lblMagneticHeading = value;
				this.SetNativeField("lblMagneticHeading", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("lblSpeed")]
		private MonoTouch.UIKit.UILabel lblSpeed {
			get {
				this.__mt_lblSpeed = ((MonoTouch.UIKit.UILabel)(this.GetNativeField("lblSpeed")));
				return this.__mt_lblSpeed;
			}
			set {
				this.__mt_lblSpeed = value;
				this.SetNativeField("lblSpeed", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("lblTrueHeading")]
		private MonoTouch.UIKit.UILabel lblTrueHeading {
			get {
				this.__mt_lblTrueHeading = ((MonoTouch.UIKit.UILabel)(this.GetNativeField("lblTrueHeading")));
				return this.__mt_lblTrueHeading;
			}
			set {
				this.__mt_lblTrueHeading = value;
				this.SetNativeField("lblTrueHeading", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("lblDistanceToParis")]
		private MonoTouch.UIKit.UILabel lblDistanceToParis {
			get {
				this.__mt_lblDistanceToParis = ((MonoTouch.UIKit.UILabel)(this.GetNativeField("lblDistanceToParis")));
				return this.__mt_lblDistanceToParis;
			}
			set {
				this.__mt_lblDistanceToParis = value;
				this.SetNativeField("lblDistanceToParis", value);
			}
		}
	}
}
