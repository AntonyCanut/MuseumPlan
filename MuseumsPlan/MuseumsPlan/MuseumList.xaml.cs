using System;
using System.Collections.Generic;
using Xamarin.Forms;
using MuseumsPlan.Library;

namespace MuseumsPlan
{
	public partial class MuseumList : ContentPage
	{
		public IList<Museum> ListMuseums;
		public DataService _service;

		public MuseumList ()
		{
			InitializeComponent ();
			_service = new DataService ();
			ListMuseums = _service.GetMuseums ();
			ListViewMuseum.ItemsSource = ListMuseums;
			ListViewMuseum.RowHeight = 70;
		}
	}
}

