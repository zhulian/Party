using System;
using Xamarin.Forms;

namespace party
{
	public class LoginScreenSuccessDetails : ContentPage
	{

		public LoginScreenSuccessDetails()
		{

		}
		public async void ShowLandingPage(string userName)
		{


			//await Navigation.PushAsync(new partyPage(), false);

			int count = Navigation.NavigationStack.Count;
			//await Navigation.PushAsync(GetLandingPage(userName), false);
			//Navigation.InsertPageBefore(GetLandingPage(userName), Navigation.NavigationStack[Navigation.NavigationStack.Count - 1]);
			await Navigation.PushAsync(new LandingPage());
			count = Navigation.NavigationStack.Count;

			//await Navigation.PopAsync(false);

		}
		private Page GetLandingPage(string userName)
		{
			return new ContentPage
			{
				Content = new Label
				{
					Text = userName,
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
				},
				Title = "test"
			};
		}
	}
}
