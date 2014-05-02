using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Example.Common;

namespace Example.iOS
{
	public partial class Example_iOSViewController : UIViewController
	{
		Counter c = new Counter();

		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public Example_iOSViewController ()
			: base (UserInterfaceIdiomIsPhone ? "Example_iOSViewController_iPhone" : "Example_iOSViewController_iPad", null)
		{

		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.

			try
			{
				Main_Button.TouchUpInside += (object sender, EventArgs e) => 
				{
					c.Increment();
					Main_Button.SetTitle(c.Value().ToString(), UIControlState.Normal);
					Main_Label.Text = String.Format("{0} Times!",c.Value());
				};
			}
			catch(Exception ex) {
				throw ex;
			}
		}
	}
}

