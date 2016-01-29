using System;
using System.Collections.Generic;
using Xamarin.Forms;
using MuseumsPlan.Library;
using System.IO;
using System.Reflection;

namespace MuseumsPlan
{
	public partial class MuseumList : ContentPage
	{
		public IList<Museum> ListMuseums;
		public DataService _service;

		public MuseumList ()
		{
			InitializeComponent ();
			//_service = new DataService ();

			var assembly = typeof(MuseumList).GetTypeInfo().Assembly;
			string data = String.Empty;
			#if __ANDROID__
			data = "MuseumsPlan.Droid.";
			#elif __IOS__

			#endif
			Stream stream = assembly.GetManifestResourceStream(data + "Data.Museum.json");
			string text = "";
			foreach (var res in assembly.GetManifestResourceNames())
				System.Diagnostics.Debug.WriteLine("found resource: " + res);
			using (var reader = new StreamReader (stream)) {
				text = reader.ReadToEnd ();
			}
			_service = new DataService (text);
			ListMuseums = _service.GetMuseums ();
			ListViewMuseum.ItemsSource = ListMuseums;
			ListViewMuseum.RowHeight = 70;
		}

		//OnSelectionListViewMuseum
		public void OnSelectionListViewMuseum (object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null) {
				return; //ItemSelected is called on deselection, which results in SelectedItem being set to null
			}
			// DisplayAlert ("Item Selected", e.SelectedItem.ToString (), "Ok");
			Navigation.PushModalAsync(new MuseumDetails(((Museum)((ListView)sender).SelectedItem).nom_du_musee, _service));
			((ListView)sender).SelectedItem = null; //uncomment line if you want to disable the visual selection state.
		}
	}
}

