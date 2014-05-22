﻿using System;
using Cirrious.MvvmCross.Touch.Platform;
using Cirrious.MvvmCross.Touch.Views.Presenters;
using Cirrious.CrossCore.Plugins;
using Cirrious.MvvmCross.ViewModels;
using Example.Common;

namespace Example.iOS
{
	public class Setup
		: MvxTouchSetup
	{
		public Setup(MvxApplicationDelegate applicationDelegate, IMvxTouchViewPresenter presenter)
			: base(applicationDelegate, presenter)
		{
		}

		protected override void AddPluginsLoaders(MvxLoaderPluginRegistry registry)
		{
//			registry.AddConventionalPlugin<Cirrious.MvvmCross.Plugins.Visibility.Touch.Plugin>();
//			registry.AddConventionalPlugin<Cirrious.MvvmCross.Plugins.DownloadCache.Touch.Plugin>();
//			registry.AddConventionalPlugin<Cirrious.MvvmCross.Plugins.File.Touch.Plugin>();
			base.AddPluginsLoaders(registry);
		}

		public override void LoadPlugins(IMvxPluginManager pluginManager)
		{
//			pluginManager.EnsurePluginLoaded<Cirrious.MvvmCross.Plugins.Visibility.PluginLoader>();
//			pluginManager.EnsurePluginLoaded<Cirrious.MvvmCross.Plugins.Json.PluginLoader>();
//			pluginManager.EnsurePluginLoaded<Cirrious.MvvmCross.Plugins.DownloadCache.PluginLoader>();
//			pluginManager.EnsurePluginLoaded<Cirrious.MvvmCross.Plugins.File.PluginLoader>();
			base.LoadPlugins(pluginManager);
		}

		protected override IMvxApplication CreateApp()
		{
			var app = new App();
			return app;
		}

		protected override void InitializeLastChance()
		{
			// create a new error displayer - it will hook itself into the framework
			//var errorDisplayer = new ErrorDisplayer();

			base.InitializeLastChance();
		}
	}
}

