using System;
using party;
using Xamarin.Forms;
using party.iOS;
using LoginScreen;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using CoreGraphics;

[assembly: ExportRenderer(typeof(partyPage), typeof(IosLoginForm))]
namespace party.iOS
{
	public class IosLoginForm : PageRenderer
	{
		public IosLoginForm()
		{

		
		}

		protected override void OnElementChanged(VisualElementChangedEventArgs e)
		{
			base.OnElementChanged(e);

			if (e.OldElement != null || Element == null)
			{
				return;
			}

			try
			{
				base.ViewDidLoad();
				View.BackgroundColor = UIColor.White;

				var loginButton = new UIButton(UIButtonType.RoundedRect);
				loginButton.SetTitle("Log In", UIControlState.Normal);
				loginButton.SizeToFit();
				loginButton.Center = new CGPoint(View.Bounds.GetMidX(), View.Bounds.GetMidY());
				loginButton.AutoresizingMask = UIViewAutoresizing.FlexibleMargins;
				loginButton.TouchUpInside += LoginClick;
				View.AddSubview(loginButton);
			
	
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(@"          ERROR: ", ex.Message);
			}

		}
		void LoginClick(object sender, EventArgs e)
		{
			LoginScreenControl<TestCredentialsProvider>.Activate(this);
            
		}


	}

}