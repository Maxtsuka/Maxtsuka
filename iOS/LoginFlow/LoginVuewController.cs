using System;

using UIKit;

namespace Maxtsuka.iOS
{
	public partial class LoginVuewController : UIViewController
	{
		public LoginVuewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			btnLogin.TouchUpInside += (sender, e) =>
			{
				PerformSegue("moveToMenu", this);
			};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

