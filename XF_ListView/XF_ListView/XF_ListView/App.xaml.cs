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
				"android=Android用の自分のキー" +
                "uwp=UWP用の自分のキー" +
                "ios=iOS用の自分のキー",
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
