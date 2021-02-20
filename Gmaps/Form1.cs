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

namespace Gmaps
{
    public partial class Form1 : Form
    {
        private string path = @"C:\Users\Windows 10\Desktop\Gmaps-workshop\Gmaps\data\COVID.xlsx";

        private List<PointLatLng> points; //marcadores
        private GMapOverlay MarkerOverlay;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog buscarArchivos = new OpenFileDialog();
            if (buscarArchivos.ShowDialog() == DialogResult.OK)
            {
                loadData();
            }
        }

        public void loadData()
        {
            SLDocument sl = new SLDocument(path);

            int iRow = 2;
            List<Principal> lst = new List<Principal>();
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)) && iRow < 30)
            {
                Principal dataSet = new Principal();
                dataSet.CASO = sl.GetCellValueAsInt32(iRow, 1);
                dataSet.CIUDAD = sl.GetCellValueAsString(iRow, 2);
                dataSet.EDAD = sl.GetCellValueAsInt32(iRow, 3);
                dataSet.ESTADO = sl.GetCellValueAsString(iRow, 4);
                dataSet.FECHA_DIAGNOSTICO = sl.GetCellValueAsString(iRow, 5);
                dataSet.FUENTE = sl.GetCellValueAsString(iRow, 6);
                dataSet.INICIO_DE_SINTOMAS = sl.GetCellValueAsString(iRow, 7);
                dataSet.LOCALIDAD = sl.GetCellValueAsString(iRow, 8);
                dataSet.SEXO = sl.GetCellValueAsInt32(iRow, 9);
                dataSet.UBICACION = sl.GetCellValueAsString(iRow, 10);


                lst.Add(dataSet);

                iRow++;
            }

            dataGridView1.DataSource = lst;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView1.Columns["CASO"].Visible = true;
                dataGridView1.Columns["CIUDAD"].Visible = false;
                dataGridView1.Columns["EDAD"].Visible = false;
                dataGridView1.Columns["ESTADO"].Visible = false;
                dataGridView1.Columns["FECHA_DIAGNOSTICO"].Visible = false;
                dataGridView1.Columns["FUENTE"].Visible = false;
                dataGridView1.Columns["INICIO_DE_SINTOMAS"].Visible = false;
                dataGridView1.Columns["LOCALIDAD"].Visible = false;
                dataGridView1.Columns["SEXO"].Visible = false;
                dataGridView1.Columns["UBICACION"].Visible = false;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                dataGridView1.Columns["CASO"].Visible = false;
                dataGridView1.Columns["CIUDAD"].Visible = true;
                dataGridView1.Columns["EDAD"].Visible = false;
                dataGridView1.Columns["ESTADO"].Visible = false;
                dataGridView1.Columns["FECHA_DIAGNOSTICO"].Visible = false;
                dataGridView1.Columns["FUENTE"].Visible = false;
                dataGridView1.Columns["INICIO_DE_SINTOMAS"].Visible = false;
                dataGridView1.Columns["LOCALIDAD"].Visible = false;
                dataGridView1.Columns["SEXO"].Visible = false;
                dataGridView1.Columns["UBICACION"].Visible = false;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                dataGridView1.Columns["CASO"].Visible = false;
                dataGridView1.Columns["CIUDAD"].Visible = false;
                dataGridView1.Columns["EDAD"].Visible = true;
                dataGridView1.Columns["ESTADO"].Visible = false;
                dataGridView1.Columns["FECHA_DIAGNOSTICO"].Visible = false;
                dataGridView1.Columns["FUENTE"].Visible = false;
                dataGridView1.Columns["INICIO_DE_SINTOMAS"].Visible = false;
                dataGridView1.Columns["LOCALIDAD"].Visible = false;
                dataGridView1.Columns["SEXO"].Visible = false;
                dataGridView1.Columns["UBICACION"].Visible = false;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                dataGridView1.Columns["CASO"].Visible = false;
                dataGridView1.Columns["CIUDAD"].Visible = false;
                dataGridView1.Columns["EDAD"].Visible = false;
                dataGridView1.Columns["ESTADO"].Visible = true;
                dataGridView1.Columns["FECHA_DIAGNOSTICO"].Visible = false;
                dataGridView1.Columns["FUENTE"].Visible = false;
                dataGridView1.Columns["INICIO_DE_SINTOMAS"].Visible = false;
                dataGridView1.Columns["LOCALIDAD"].Visible = false;
                dataGridView1.Columns["SEXO"].Visible = false;
                dataGridView1.Columns["UBICACION"].Visible = false;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                dataGridView1.Columns["CASO"].Visible = false;
                dataGridView1.Columns["CIUDAD"].Visible = false;
                dataGridView1.Columns["EDAD"].Visible = false;
                dataGridView1.Columns["ESTADO"].Visible = false;
                dataGridView1.Columns["FECHA_DIAGNOSTICO"].Visible = true;
                dataGridView1.Columns["FUENTE"].Visible = false;
                dataGridView1.Columns["INICIO_DE_SINTOMAS"].Visible = false;
                dataGridView1.Columns["LOCALIDAD"].Visible = false;
                dataGridView1.Columns["SEXO"].Visible = false;
                dataGridView1.Columns["UBICACION"].Visible = false;
            }
            if (comboBox1.SelectedIndex == 5)
            {
                dataGridView1.Columns["CASO"].Visible = false;
                dataGridView1.Columns["CIUDAD"].Visible = false;
                dataGridView1.Columns["EDAD"].Visible = false;
                dataGridView1.Columns["ESTADO"].Visible = false;
                dataGridView1.Columns["FECHA_DIAGNOSTICO"].Visible = false;
                dataGridView1.Columns["FUENTE"].Visible = true;
                dataGridView1.Columns["INICIO_DE_SINTOMAS"].Visible = false;
                dataGridView1.Columns["LOCALIDAD"].Visible = false;
                dataGridView1.Columns["SEXO"].Visible = false;
                dataGridView1.Columns["UBICACION"].Visible = false;
            }
            if (comboBox1.SelectedIndex == 6)
            {
                dataGridView1.Columns["CASO"].Visible = false;
                dataGridView1.Columns["CIUDAD"].Visible = false;
                dataGridView1.Columns["EDAD"].Visible = false;
                dataGridView1.Columns["ESTADO"].Visible = false;
                dataGridView1.Columns["FECHA_DIAGNOSTICO"].Visible = false;
                dataGridView1.Columns["FUENTE"].Visible = false;
                dataGridView1.Columns["INICIO_DE_SINTOMAS"].Visible = true;
                dataGridView1.Columns["LOCALIDAD"].Visible = false;
                dataGridView1.Columns["SEXO"].Visible = false;
                dataGridView1.Columns["UBICACION"].Visible = false;
            }
            if (comboBox1.SelectedIndex == 7)
            {
                dataGridView1.Columns["CASO"].Visible = false;
                dataGridView1.Columns["CIUDAD"].Visible = false;
                dataGridView1.Columns["EDAD"].Visible = false;
                dataGridView1.Columns["ESTADO"].Visible = false;
                dataGridView1.Columns["FECHA_DIAGNOSTICO"].Visible = false;
                dataGridView1.Columns["FUENTE"].Visible = false;
                dataGridView1.Columns["INICIO_DE_SINTOMAS"].Visible = false;
                dataGridView1.Columns["LOCALIDAD"].Visible = true;
                dataGridView1.Columns["SEXO"].Visible = false;
                dataGridView1.Columns["UBICACION"].Visible = false;
            }
            if (comboBox1.SelectedIndex == 8)
            {
                dataGridView1.Columns["CASO"].Visible = false;
                dataGridView1.Columns["CIUDAD"].Visible = false;
                dataGridView1.Columns["EDAD"].Visible = false;
                dataGridView1.Columns["ESTADO"].Visible = false;
                dataGridView1.Columns["FECHA_DIAGNOSTICO"].Visible = false;
                dataGridView1.Columns["FUENTE"].Visible = false;
                dataGridView1.Columns["INICIO_DE_SINTOMAS"].Visible = false;
                dataGridView1.Columns["LOCALIDAD"].Visible = false;
                dataGridView1.Columns["SEXO"].Visible = true;
                dataGridView1.Columns["UBICACION"].Visible = false;
            }
            if (comboBox1.SelectedIndex == 9)
            {
                dataGridView1.Columns["CASO"].Visible = false;
                dataGridView1.Columns["CIUDAD"].Visible = false;
                dataGridView1.Columns["EDAD"].Visible = false;
                dataGridView1.Columns["ESTADO"].Visible = false;
                dataGridView1.Columns["FECHA_DIAGNOSTICO"].Visible = false;
                dataGridView1.Columns["FUENTE"].Visible = false;
                dataGridView1.Columns["INICIO_DE_SINTOMAS"].Visible = false;
                dataGridView1.Columns["LOCALIDAD"].Visible = false;
                dataGridView1.Columns["SEXO"].Visible = false;
                dataGridView1.Columns["UBICACION"].Visible = true;
            }
        }

    }
}
