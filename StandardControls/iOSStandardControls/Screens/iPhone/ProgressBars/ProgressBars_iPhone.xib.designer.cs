// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Example_StandardControls.Screens.iPhone.ProgressBars {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("ProgressBars_iPhone")]
	public partial class ProgressBars_iPhone {
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		private MonoTouch.UIKit.UIProgressView __mt_btnProgress1;
		
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
		
		[MonoTouch.Foundation.Connect("btnProgress1")]
		private MonoTouch.UIKit.UIProgressView btnProgress1 {
			get {
				this.__mt_btnProgress1 = ((MonoTouch.UIKit.UIProgressView)(this.GetNativeField("btnProgress1")));
				return this.__mt_btnProgress1;
			}
			set {
				this.__mt_btnProgress1 = value;
				this.SetNativeField("btnProgress1", value);
			}
		}
	}
}
