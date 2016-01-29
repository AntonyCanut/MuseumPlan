using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MuseumsPlan
{
	public partial class Home : ContentPage
	{
		public Home ()
		{
			InitializeComponent ();
		}

		public void OnEnterClicked(object sender, EventArgs e)
		{
			//DisplayAlert ("Alert", "You have been alerted", "OK");
			Navigation.PushModalAsync(new MuseumList());
		}
	}
}

