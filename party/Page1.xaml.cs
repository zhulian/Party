using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace party
{
	public partial class Page1 : ContentPage
	{
		public Page1()
		{
			InitializeComponent();


		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			int count = Navigation.NavigationStack.Count;
			Navigation.PushAsync(new Page2());
			count = Navigation.NavigationStack.Count;
		}
	}
}
