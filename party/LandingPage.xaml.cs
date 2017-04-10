using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace party
{
	public partial class LandingPage : ContentPage
	{

		public LandingPage()
		{
			InitializeComponent();
			//	Navigation.PopAsync();
int count = Navigation.NavigationStack.Count;
//Page p = ((NavigationPage)Application.Current.MainPage).CurrentPage;
//Navigation.RemovePage(p);
//Navigation.PushModalAsync(new Page2());
Application.Current.MainPage =new NavigationPage(this);
			Application.Current.MainPage.Focus();
count = Navigation.NavigationStack.Count;


		}


	}
}
