using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Gmaps.model;

namespace Gmaps.ui
{
    public partial class MapForm : Form
    {
        private DataManager mapData;

        private List<PointLatLng> dots;

        GMapOverlay markers = new GMapOverlay("markers");
        
        public MapForm()
        {
            InitializeComponent();
            mapData = new DataManager();

            dots = new List<PointLatLng>();
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            map.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;

            map.Position = new PointLatLng(4.704940, -74.074369);

            map.Overlays.Add(markers);
        }

        private void setMarkers()
        {
            foreach (PointLatLng p in dots)
            {
                GMapMarker marker = new GMarkerGoogle(p, GMarkerGoogleType.blue_dot);
                markers.Markers.Add(marker);
            }
        }

        private void btnRecovered_Click(object sender, EventArgs e)
        {
            
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            List<string> loc = mapData.getLocations();

            foreach (string i in loc)
            {
                GeoCoderStatusCode statusCode;
                PointLatLng? pointLatLng1 = OpenStreet4UMapProvider.Instance.GetPoint(i, out statusCode);

                if (pointLatLng1 != null)
                {
                    GMapMarker marker0 = new GMarkerGoogle(new PointLatLng(pointLatLng1.Value.Lat, pointLatLng1.Value.Lng), GMarkerGoogleType.blue_dot);
                    marker0.ToolTipText = i + "\n" + pointLatLng1.Value.Lat + "\n" + pointLatLng1.Value.Lng;
                    markers.Markers.Add(marker0);
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dots.Clear();
            markers.Clear();
        }

        private void btnCases_Click(object sender, EventArgs e)
        {

        }

    }
}
