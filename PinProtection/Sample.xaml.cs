using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace PinProtection
{
	public partial class Sample : ContentPage
	{
		string realPassword="123456";
		public  Sample ()
		{
			InitializeComponent ();
			PinInfo.CheckPassword+= PinInfo_CheckPassword; 
			PinInfo.ForgotPin+= PinInfo_ForgotPin;
		}
		/// <summary>
		/// Password Entered by the user.
		/// </summary>
		/// <param name="Password">Password.</param>
		void PinInfo_CheckPassword (string Password)
		{
			if(realPassword.Length== Password.Length)
			{
				if(realPassword== Password)
				{
					Device.BeginInvokeOnMainThread(async () => {

						PinInfo.AnimationsOnSuccess();
						Navigation.PushModalAsync(new SuccessPage());

					});
				}
				else
				{

					PinInfo.EntryValue="";
					PinInfo.AnimationsOnError();
				}
			}
		}
		/// <summary>
		/// Event raise when user Clicks ForgotPin
		/// </summary>
		void PinInfo_ForgotPin ()
		{
			
		}
	}
}

