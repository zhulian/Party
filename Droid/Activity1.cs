using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using LoginScreen;
using party.Droid;

namespace party.OS
{
	[Activity(Label = "LoginScreen.Android.Sample", MainLauncher = true)]
	public class Activity1 : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			SetContentView(Droid.Resource.Layout.Main);

			FindViewById<Button>(Droid.Resource.Id.loginButton).Click += (sender, e) => LoginScreenControl<TestCredentialsProvider>.Activate(this);
		}
	}
}

