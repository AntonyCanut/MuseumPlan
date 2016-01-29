using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MuseumsPlan.Library;

namespace MuseumsPlan
{
	public partial class MuseumDetails : ContentPage
	{
		private DataService _service;

		public MuseumDetails ()
		{
			InitializeComponent ();
		}

		public MuseumDetails(string name, DataService service)
		{
			InitializeComponent ();
			_service = service;
			BindingContext = _service.GetMuseumByName (name);
		}
	}
}

