// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace QuartzSample {
	
	
	// Base type probably should be MonoTouch.Foundation.NSObject or subclass
	[MonoTouch.Foundation.Register("AppDelegate")]
	public partial class AppDelegate {
		
		private MonoTouch.UIKit.UIWindow __mt_window;
		
		private MonoTouch.UIKit.UINavigationController __mt_navigationController;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("window")]
		private MonoTouch.UIKit.UIWindow window {
			get {
				this.__mt_window = ((MonoTouch.UIKit.UIWindow)(this.GetNativeField("window")));
				return this.__mt_window;
			}
			set {
				this.__mt_window = value;
				this.SetNativeField("window", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("navigationController")]
		private MonoTouch.UIKit.UINavigationController navigationController {
			get {
				this.__mt_navigationController = ((MonoTouch.UIKit.UINavigationController)(this.GetNativeField("navigationController")));
				return this.__mt_navigationController;
			}
			set {
				this.__mt_navigationController = value;
				this.SetNativeField("navigationController", value);
			}
		}
	}
	
	// Base type probably should be MonoTouch.UIKit.UITableViewController or subclass
	[MonoTouch.Foundation.Register("MainViewController")]
	public partial class MainViewController {
	}
}
