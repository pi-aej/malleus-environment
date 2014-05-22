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
				var set = this.CreateBindingSet<Example_iOSViewController, Counter>();

				//Binding to events and methods is done with reflection, so strong typing is not possible
				set.Bind(Main_Button)
					.For("TouchUpInside")
					.To("IncrementCommand");

				//Binding to members is requires reflection too, so a NotifyPropertyChanged event can be raised.
				set.Bind(Main_Button).For("Title").To(vm => vm.ValueStatement);

				//Binding to properties can be done statically, so strong typing is possible
				set.Bind(Main_Label).For(v => v.Text).To(vm => vm.ValueStatement);
				set.Apply();
			}
			catch(Exception ex) {
				throw ex;
			}
		}
	}
}

