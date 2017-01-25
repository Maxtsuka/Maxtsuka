using System;

using UIKit;

namespace Maxtsuka.iOS
{
	public partial class MenuFlowController : UIViewController
	{
		public MenuFlowController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			btnMap.TouchUpInside += (sender, e) =>
			{
				PerformSegue("moveToMap", this);
			};

			btnWeb.TouchUpInside += (sender, e) =>
			{
				PerformSegue("moveToWeb", this);
			};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

