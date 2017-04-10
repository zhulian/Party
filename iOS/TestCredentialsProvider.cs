using System;
using System.Threading.Tasks;
using System.Timers;

using LoginScreen;


namespace party.iOS
{
	public class TestCredentialsProvider : ICredentialsProvider
	{
		readonly Random rnd = new Random();
public event EventHandler RowSelected;
		public bool NeedLoginAfterRegistration
		{
			get { return false; }
		}

		public bool ShowRegistration
		{
			get { return false; }
		}
		public bool ShowPasswordResetLink
		{
			get { return false; }
		}

		void ICredentialsProvider.Login(string userName, string password, Action successCallback, Action<LoginScreenFaultDetails> failCallback)
		{
			//DelayInvoke (EquiprobableSelect (successCallback = new LoginScreenSuccessDetails().ShowLandingPage, () => failCallback (new LoginScreenFaultDetails { CommonErrorMessage = "Something wrong happened." })));
			new LandingPage();

			//var alert = new UIAlertView("My Title Text", "This is my main text", null, "Ok", null);
			//alert.Show();

		}

		public void Register(string email, string userName, string password, Action successCallback, Action<LoginScreenFaultDetails> failCallback)
		{
			DelayInvoke(() =>
			{
				if (password.Length < 4)
				{
					failCallback(new LoginScreenFaultDetails { PasswordErrorMessage = "Password must be at least 4 chars." });
				}
				else
				{
					successCallback();
				}
			});
		}

		public void ResetPassword(string email, Action successCallback, Action<LoginScreenFaultDetails> failCallback)
		{
			DelayInvoke(EquiprobableSelect(successCallback, () => failCallback(new LoginScreenFaultDetails { CommonErrorMessage = "Something wrong happened." })));
		}

		private void DelayInvoke(Action operation)
		{
			Timer timer = new Timer();
			timer.AutoReset = false;
			timer.Interval = 300;
			timer.Elapsed += (object sender, ElapsedEventArgs e) => operation.Invoke();
			timer.Start();
		}

		private T EquiprobableSelect<T>(T first, T second)
		{
			return rnd.Next(100) < int.MaxValue ? first : second;
		}
	}
}

