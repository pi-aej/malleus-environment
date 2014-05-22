using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Example.Common;
using Cirrious.MvvmCross.Touch.Views;
using Cirrious.MvvmCross.Binding.BindingContext;

namespace Example.iOS
{
	public partial class Example_iOSViewController : MvxViewController
	{
		Counter c = new Counter();

		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public Example_iOSViewController ()
			: base (UserInterfaceIdiomIsPhone ? "Example_iOSViewController_iPhone" : "Example_iOSViewController_iPad", null)
		{
			this.DataContext = c;
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
				var button = Main_Button;

				var set = this.CreateBindingSet<Example_iOSViewController, Counter>();

				set.Bind(button).For("TouchUpInside").To("IncrementCommand");
				set.Bind(button).For("Title").To ("ValueStatement");
				set.Apply();
			}
			catch(Exception ex) {
				throw ex;
			}
		}
	}
}

