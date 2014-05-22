using System;
using Cirrious.MvvmCross.Droid.Platform;
using Android.Content;
using Cirrious.MvvmCross.ViewModels;

namespace Example.Android
{
	public class Setup : MvxAndroidSetup
	{
		public Setup(Context applicationContext)
			: base(applicationContext)
		{
		}

		protected override IMvxApplication CreateApp()
		{
			return new Example.Common.App();
		}

		protected override void InitializeLastChance()
		{
			//var errorHandler = new ErrorDisplayer(ApplicationContext);
//			Cirrious.MvvmCross.Plugins.Json.PluginLoader.Instance.EnsureLoaded();
//			Cirrious.MvvmCross.Plugins.Visibility.PluginLoader.Instance.EnsureLoaded();
//			Cirrious.MvvmCross.Plugins.File.PluginLoader.Instance.EnsureLoaded();
//			Cirrious.MvvmCross.Plugins.DownloadCache.PluginLoader.Instance.EnsureLoaded();
			base.InitializeLastChance();
		}
	}
}

