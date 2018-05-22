using System;
using Xamarin.Forms;
using App7.Views;
using Xamarin.Forms.Xaml;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace App7
{
	public partial class App : Application
	{
		
		public App ()
		{
			InitializeComponent();


			MainPage = new MainPage();
		}

		protected override void OnStart ()
		{
			AppCenter.Start("android=5261e17b-cd91-4d5d-ad8f-cd736731ae4e;" +
			                "uwp={Your UWP App secret here};" +
			                "ios={Your iOS App secret here}",
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
