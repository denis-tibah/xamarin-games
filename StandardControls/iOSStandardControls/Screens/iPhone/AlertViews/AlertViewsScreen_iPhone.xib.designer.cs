// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Example_StandardControls.Screens.iPhone.AlertViews {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("AlertViewsScreen_iPhone")]
	public partial class AlertViewsScreen_iPhone {
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		private MonoTouch.UIKit.UIButton __mt_btnCustomButtons;
		
		private MonoTouch.UIKit.UIButton __mt_btnSimpleAlert;
		
		private MonoTouch.UIKit.UIButton __mt_btnCustomButtonsWithDelegate;
		
		private MonoTouch.UIKit.UIButton __mt_btnCustomAlert;
		
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
		
		[MonoTouch.Foundation.Connect("btnCustomButtons")]
		private MonoTouch.UIKit.UIButton btnCustomButtons {
			get {
				this.__mt_btnCustomButtons = ((MonoTouch.UIKit.UIButton)(this.GetNativeField("btnCustomButtons")));
				return this.__mt_btnCustomButtons;
			}
			set {
				this.__mt_btnCustomButtons = value;
				this.SetNativeField("btnCustomButtons", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("btnSimpleAlert")]
		private MonoTouch.UIKit.UIButton btnSimpleAlert {
			get {
				this.__mt_btnSimpleAlert = ((MonoTouch.UIKit.UIButton)(this.GetNativeField("btnSimpleAlert")));
				return this.__mt_btnSimpleAlert;
			}
			set {
				this.__mt_btnSimpleAlert = value;
				this.SetNativeField("btnSimpleAlert", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("btnCustomButtonsWithDelegate")]
		private MonoTouch.UIKit.UIButton btnCustomButtonsWithDelegate {
			get {
				this.__mt_btnCustomButtonsWithDelegate = ((MonoTouch.UIKit.UIButton)(this.GetNativeField("btnCustomButtonsWithDelegate")));
				return this.__mt_btnCustomButtonsWithDelegate;
			}
			set {
				this.__mt_btnCustomButtonsWithDelegate = value;
				this.SetNativeField("btnCustomButtonsWithDelegate", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("btnCustomAlert")]
		private MonoTouch.UIKit.UIButton btnCustomAlert {
			get {
				this.__mt_btnCustomAlert = ((MonoTouch.UIKit.UIButton)(this.GetNativeField("btnCustomAlert")));
				return this.__mt_btnCustomAlert;
			}
			set {
				this.__mt_btnCustomAlert = value;
				this.SetNativeField("btnCustomAlert", value);
			}
		}
	}
}
