using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Example.Common;
using Cirrious.MvvmCross.Droid.Views;
using Cirrious.MvvmCross.Binding.BindingContext;

namespace Example.Android
{

	//var set = this.CreateBindingSet<ExampleiewController,TestViewModel> ();
	[Activity (Label = "Example.Android", MainLauncher = true)]
	public class MainActivity : MvxActivity
	{
		Counter c = new Counter();

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);

			this.DataContext = c;

			var set = this.CreateBindingSet<MainActivity,Counter>();

			set.Bind(button).For("Click").To("IncrementCommand");
			set.Bind (button).For ("Text").To ("Value");
			set.Apply ();
		}
	}
}


