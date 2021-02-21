using GMap.NET;
using GMap.NET.WindowsForms;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gmaps.ui;

namespace Gmaps
{
    public partial class Form1 : Form
    {
        //private string path = @"C:\Users\Windows 10\Desktop\Gmaps-workshop\Gmaps\data\COVID.xlsx";
        private string path = @"C:\Users\alejo\source\repos\Gmaps\Gmaps\data\COVID.xlsx";

        private List<PointLatLng> points; //marcadores
        private GMapOverlay MarkerOverlay;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new MapForm());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            openChildForm(new GridForm());
        }

        private void openChildForm(object child)
        {
            if (this.container.Controls.Count > 0)
                this.container.Controls.RemoveAt(0);

            Form childF = child as Form;
            childF.TopLevel = false;
            childF.Dock = DockStyle.Fill;
            this.container.Controls.Add(childF);
            this.container.Tag = childF;
            childF.Show();
        }

        private void btnGraph_Click(object sender, EventArgs e)
        {
            openChildForm(new GraphForm());
        }
    }
}
