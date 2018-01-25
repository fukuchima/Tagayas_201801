using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

using Xamarin.Forms;

namespace XF_ListView
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new XF_ListView.MainPage();
		}

		protected override void OnStart ()
		{
			// Appcenter Analyticsの初期設定 
			AppCenter.Start(
				"android=8f10cbda-7059-43c9-8fb4-91ead2b0bc43;" + 
				"uwp=39d0e04f-3dc6-4ec1-9bea-848b2e6f50f9;" +
				"ios=b8eaf9d0-ba1c-429c-a99f-fbcc2e31f9dd",
				typeof(Analytics), typeof(Crashes));

		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
