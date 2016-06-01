using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Diagnostics;

namespace PinProtection
{
	public delegate void ChkPassword(string Password);
	public delegate void FrgtPin();
	public partial class PinView : ContentView
	{
		public event ChkPassword CheckPassword;
		public event FrgtPin ForgotPin;
		private string titleLabel;
		private string entryPassword;
		private string btntext1="1";
		private string btntext2="2";
		private string btntext3="3";
		private string btntext4="4";
		private string btntext5="5";
		private string btntext6="6";
		private string btntext7="7";
		private string btntext8="8";
		private string btntext9="9";
		private string btntext0="0";
		private string btnTextOk="Save";

		private  Color theamColor;
		private string btnForgotPinText="Forgot";
		private string btnDeleteText="Delete";
		 int max;
		public PinView ()
		{
			InitializeComponent ();
			lblTitle.Text = TitleLabel;
			entPassword.Text = EntryPassword;
			Btn1.Text = Btntext1;
			Btn2.Text = Btntext2;
			Btn3.Text = Btntext3;
			Btn4.Text = Btntext4;
			Btn5.Text = Btntext5;
			Btn6.Text = Btntext6;
			Btn7.Text = Btntext7;
			Btn8.Text = Btntext8;
			Btn9.Text = Btntext9;
			Btn0.Text = Btntext0;
//			BtnOk.Text = BtnTextOk;
			max = PasswordMaxLength;
			entPassword.Text = EntryPassword;
			BtnDelete.Text = BtnDeleteText;
			BtnForgotPIN.Text = BtnForgotPinText;
			Btn0.Clicked += MyButtonClick;
			Btn1.Clicked += MyButtonClick;
			Btn2.Clicked += MyButtonClick;
			Btn3.Clicked += MyButtonClick;
			Btn4.Clicked += MyButtonClick;
			Btn5.Clicked += MyButtonClick;
			Btn6.Clicked += MyButtonClick;
			Btn7.Clicked += MyButtonClick;
			Btn8.Clicked += MyButtonClick;
			Btn9.Clicked += MyButtonClick;
//			BtnDelete.Image = new FileImageSource () { File = "Tag Remove-WF.png" };
//			BtnForgotPIN.Image = new FileImageSource () { File = "ForgotPin.png" };
			Debug.WriteLine(theamColor);
			entPassword.TextChanged += (object sender, TextChangedEventArgs e) => 
			{
				if(entPassword.Text.Length >= passwordMinLength)
				{
					if(CheckPassword!=null)
					CheckPassword(entPassword.Text);
				}
			};
			BtnDelete.Clicked+= (object sender, EventArgs e) => 
			{
				if(!string.IsNullOrEmpty(entPassword.Text))
				if(entPassword.Text.Length!=0)
				{
					entPassword.Text=	entPassword.Text.Substring(0,entPassword.Text.Length-1);
				}

			};

			BtnForgotPIN.Clicked+= (object sender, EventArgs e) => {
				if(ForgotPin!=null)
					ForgotPin();
			};
		}

		private PinViewType pinType;

		public PinViewType PinType {
			get {
				return pinType;
			}
			set {
				pinType = value;
			}
		}

		/// <summary>
		/// Title of the screen
		/// </summary>
		/// <value>Displaying the title on screen.</value>
		public string TitleLabel 
		{
			get 
			{
				return titleLabel;
			}
			set 
			{
				lblTitle.Text = value;
			}
		}
		/// <summary>
		/// Gets or sets the entry password.
		/// </summary>
		/// <value>password entered by the user.</value>
		public string EntryPassword 
		{
			get {
				return entryPassword;
			}
			set {
				entPassword.Text = value;
			}
		}
		/// <summary>
		/// Gets or sets the btntext1.
		/// </summary>
		/// <value>Text of Button one .</value>
		public string Btntext1 
		{
			get
			{
				return btntext1;
			}
			set 
			{
				Btn1.Text = value;
			}
		}
		/// <summary>
		/// Gets or sets the btntext2.
		/// </summary>
		/// <value>Text of Button two</value>
		public string Btntext2 
		{
			get 
			{
				return btntext2;
			}
			set 
			{
				Btn2.Text = value;
			}
		}
		/// <summary>
		/// Gets or sets the btntext3.
		/// </summary>
		/// <value>The btntext3.</value>
		public string Btntext3 
		{
			get 
			{
				return btntext3;
			}
			set {
				Btn3.Text = value;
			}
		}
		/// <summary>
		/// Gets or sets the Button 4 text.
		/// </summary>
		/// <value>The btntext4.</value>
		public string Btntext4 
		{
			get 
			{
				return btntext4;
			}
			set {
				Btn4.Text = value;
			}
		}
		/// <summary>
		/// Gets or sets the Button 5 text.
		/// </summary>
		/// <value>The btntext5.</value>
		public string Btntext5 {
			get {
				return btntext5;
			}
			set {
				Btn5.Text = value;
			}
		}
		/// <summary>
		/// Gets or sets the Button 6 text.
		/// </summary>
		/// <value>The btntext6.</value>
		public string Btntext6 {
			get {
				return btntext6;
			}
			set {
				Btn6.Text = value;
			}
		}
		/// <summary>
		/// Gets or sets the Button 7 text.
		/// </summary>
		/// <value>The btntext7.</value>
		public string Btntext7 {
			get {
				return btntext7;
			}
			set {
				Btn7.Text = value;
			}
		}
		/// <summary>
		/// Gets or sets the Button 8 text.
		/// </summary>
		/// <value>The btntext8.</value>
		public string Btntext8 {
			get {
				return btntext8;
			}
			set {
				Btn8.Text = value;
			}
		}
		/// <summary>
		/// Gets or sets the Button 9 text.
		/// </summary>
		/// <value>The btntext9.</value>
		public string Btntext9 {
			get {
				return btntext9;
			}
			set {
				Btn9.Text = value;
			}
		}
		/// <summary>
		/// Gets or sets the Button 0 text.
		/// </summary>
		/// <value>The btntext0.</value>
		public string Btntext0 {
			get {
				return btntext0;
			}
			set {
				Btn0.Text = value;
			}
		}

		public string BtnTextOk 
		{
			get 
			{
				return btnTextOk;
			}
			set 
			{
				btnTextOk = value;
			}
		}

		/// <summary>
		/// Gets or sets the text forgotpin .
		/// </summary>
		/// <value>The button BtnForgotPinText.</value>
		public string BtnForgotPinText {
			get {
				return btnForgotPinText;
			}
			set {
				BtnForgotPIN.Text = value;
			}
		}
		/// <summary>
		/// Gets or sets the button delete.
		/// </summary>
		/// <value>The button delete.</value>

		public string BtnDeleteText {
			get {
				return btnDeleteText;
			}
			set {
				BtnDelete.Text = value;
			}
		}
		private static int passwordMaxLength;

		public int PasswordMaxLength {
			get {
				return passwordMaxLength;
			}
			set {
				passwordMaxLength = value;
			}
		}
		private static int passwordMinLength;

		public int PasswordMinLength {
			get {
				return passwordMinLength;
			}
			set {
				passwordMinLength = value;
			}
		}
		private  string entryValue;

		public string EntryValue {
			get {
				return entryValue;
			}
			set {
				entPassword.Text = value;
			}
		}

		/// <summary>
		/// Gets or sets the color theam of the App .
		/// </summary>
		/// <value>The color of the App.</value>
		public Color TheamColor {
			get {
				return theamColor;
			}
			set {
				Btn0.TextColor=value;
				Btn0.BorderColor = value;
				Btn1.TextColor=value;
				Btn1.BorderColor = value;
				Btn2.TextColor=value;
				Btn2.BorderColor = value;
				Btn3.TextColor=value;
				Btn3.BorderColor = value;
				Btn4.TextColor=value;
				Btn4.BorderColor = value;
				Btn5.TextColor=value;
				Btn5.BorderColor = value;
				Btn6.TextColor=value;
				Btn6.BorderColor = value;
				Btn7.TextColor=value;
				Btn7.BorderColor = value;
				Btn8.TextColor=value;
				Btn8.BorderColor = value;
				Btn9.TextColor=value;
				Btn9.BorderColor = value;
				BtnForgotPIN.TextColor = value;
				BtnDelete.TextColor = value;
				EntryFrame.OutlineColor = value;
//				BtnOk.TextColor=value;
//				BtnOk.BorderColor = value;
				textColors=value;
				TextColors = value;
			}
		}
		private ButtonShape buttonTypeCircular;

		public ButtonShape ButtonTypeCircular 
		{
			get 
			{
				return buttonTypeCircular;
			}
			set {
				var res = value;
				if (res==ButtonShape.Circular) {
					Btn0.BorderRadius = 32;
					Btn1.BorderRadius = 32;
					Btn2.BorderRadius = 32;
					Btn3.BorderRadius = 32;
					Btn4.BorderRadius = 32;
					Btn5.BorderRadius = 32;
					Btn6.BorderRadius = 32;
					Btn7.BorderRadius = 32;
					Btn8.BorderRadius = 32;
					Btn9.BorderRadius = 32;

				} else {
					Btn0.BorderRadius = 12;
					Btn1.BorderRadius = 12;
					Btn2.BorderRadius = 12;
					Btn3.BorderRadius = 12;
					Btn4.BorderRadius = 12;
					Btn5.BorderRadius = 12;
					Btn6.BorderRadius = 12;
					Btn7.BorderRadius = 12;
					Btn8.BorderRadius = 12;
					Btn9.BorderRadius = 12;
				}
			}
		}
		private Color textColors;

		public Color TextColors {
			get {
				return textColors;
			}
			set {
				textColors = value;
			}
		}

		/// <summary>
		///click of all in View.
		/// </summary>
		/// <param name="sender">Sender.</param>
		/// <param name="e">E.</param>
		void MyButtonClick(object sender, EventArgs e)
		{
			
			string Value = ((Button)sender).Text;
			entPassword.Text = entPassword.Text + Value;

		}
		public async void AnimationsOnError()
		{
			entPassword.Placeholder="Incorrect Password";
			await entPassword.ScaleTo(0.5, 500, Easing.BounceIn);  
			await entPassword.ScaleTo(1, 500, Easing.Linear); 
		}
		public async void AnimationsOnSuccess()
		{
			EntryFrame.OutlineColor = Color.Green;
			await entPassword.ScaleTo(100, 500, Easing.CubicInOut);  
//			await entPassword.ScaleTo(1, 500, Easing.Linear); 
			EntryFrame.OutlineColor = Color.White;
		}
	}
}

