using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PinProtection
{
	public partial class SuccessPage : ContentPage
	{
		public SuccessPage ()
		{
			InitializeComponent ();
			BtnPinView.Clicked+= (object sender, EventArgs e) => {
				Device.BeginInvokeOnMainThread( () => {
					Navigation.PushModalAsync(new Sample(),true);


				});
			};
		}
	}
}

