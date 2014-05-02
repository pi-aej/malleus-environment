// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace Example.iOS
{
	[Register ("Example_iOSViewController")]
	partial class Example_iOSViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton Main_Button { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel Main_Label { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (Main_Button != null) {
				Main_Button.Dispose ();
				Main_Button = null;
			}

			if (Main_Label != null) {
				Main_Label.Dispose ();
				Main_Label = null;
			}
		}
	}
}
