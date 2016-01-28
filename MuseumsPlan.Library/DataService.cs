using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MuseumsPlan.Library;

namespace MuseumsPlan
{
    public class DataService
    {
		IList<Museum> _listMuseums;

		public DataService()
		{
			var data = DataService.GetDataService();
			_listMuseums = new List<Museum>();
			foreach (var museum in data.records)
			{
				_listMuseums.Add(museum.fields);
			}
		}

		public static MuseumData GetDataService()
		{
			string queryString = "http://data.iledefrance.fr/api/records/1.0/search/?dataset=liste_des_musees_franciliens&rows=100&facet=dept";
			HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, queryString);
            HttpClient client = new HttpClient();
			HttpResponseMessage httpResponse = client.SendAsync(request).Result;
			string responseText = httpResponse.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<MuseumData>(responseText);

        }

        public IList<Museum> GetMuseums()
		{
			return _listMuseums;
		}

		public Museum GetMuseumByName(string name)
		{
			foreach (var museum in _listMuseums)
			{
				if (museum.nom_du_musee == name)
				{
					return museum;
				}
			}
			return null;
		}

		public Museum GetMuseumByDepartment(int dept)
		{
			foreach (var museum in _listMuseums)
			{
				if (museum.dept == dept)
				{
					return museum;
				}    
			}
			return null;
		}

    }
}
