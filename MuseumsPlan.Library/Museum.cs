using System;
using System.Collections.Generic;
using System.Text;

namespace MuseumsPlan.Library
{
    public class Parameters
    {
        public List<string> dataset { get; set; }
        public string timezone { get; set; }
        public int rows { get; set; }
        public string format { get; set; }
        public List<string> facet { get; set; }
    }

    public class Museum
    {
        public string periode_ouverture { get; set; }
        public string nom_du_musee { get; set; }
        public List<double> wgs84 { get; set; }
        public string ville { get; set; }
        public string sitweb { get; set; }
        public string adresse { get; set; }
        public int dept { get; set; }
        public string ferme { get; set; }
        public string fermeture_annuelle { get; set; }
        public int cp { get; set; }
        public string departements { get; set; }
        public string jours_nocturnes { get; set; }
    }

    public class Geometry
    {
        public string type { get; set; }
        public List<double> coordinates { get; set; }
    }

    public class Record
    {
        public string datasetid { get; set; }
        public string recordid { get; set; }
        public Museum fields { get; set; }
        public Geometry geometry { get; set; }
        public string record_timestamp { get; set; }
    }

    public class Facet
    {
        public string name { get; set; }
        public string path { get; set; }
        public int count { get; set; }
        public string state { get; set; }
    }

    public class FacetGroup
    {
        public string name { get; set; }
        public List<Facet> facets { get; set; }
    }

    public class MuseumData
    {
        public int nhits { get; set; }
        public Parameters parameters { get; set; }
        public List<Record> records { get; set; }
        public List<FacetGroup> facet_groups { get; set; }
    }
}
