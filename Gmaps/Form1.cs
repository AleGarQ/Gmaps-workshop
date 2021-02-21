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
                dataSet.INICIO_DE_SINTOMAS = sl.GetCellValueAsDateTime(iRow, 2);
                dataSet.FECHA_DIAGNOSTICO = sl.GetCellValueAsDateTime(iRow, 3);
                dataSet.CIUDAD = sl.GetCellValueAsString(iRow, 4);
                dataSet.LOCALIDAD = sl.GetCellValueAsString(iRow, 5);
                dataSet.EDAD = sl.GetCellValueAsInt32(iRow, 6);
                dataSet.SEXO = sl.GetCellValueAsString(iRow, 7);
                dataSet.FUENTE = sl.GetCellValueAsString(iRow, 8);
                dataSet.UBICACION = sl.GetCellValueAsString(iRow, 9);
                dataSet.ESTADO = sl.GetCellValueAsString(iRow, 10);

                lst.Add(dataSet);

                iRow++;
            }
            comboBox1.Enabled = true;
            dataGridView1.DataSource = lst;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == 0) //numerico
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
                numerico();
            }
            if (comboBox1.SelectedIndex == 1) //categorico
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
                categorico();
            }
            if (comboBox1.SelectedIndex == 2) //numerico
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
                numerico();
            }
            if (comboBox1.SelectedIndex == 3) //categorico
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
                categorico();
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
            if (comboBox1.SelectedIndex == 5) //cadena
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
                cadena();
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
            if (comboBox1.SelectedIndex == 7) //cadena
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
                cadena();
            }
            if (comboBox1.SelectedIndex == 8) //categorico
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
                categorico();
            }
            if (comboBox1.SelectedIndex == 9) //cadena
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
                cadena();
            }
        }

        public void numerico()
        {
            numerico1.Enabled = true;
            numerico2.Enabled = true;
            if(categoriaCombo.Enabled == true )
            {
                categoriaCombo.Enabled = false;
            }if(texto.Enabled == true)
            {
                texto.Enabled = false;
            }
            
        }
        public void categorico()
        {
            categoriaCombo.Enabled = true;
            if(numerico1.Enabled == true && numerico2.Enabled == true)
            {
                numerico1.Enabled = false;
                numerico2.Enabled = false;
            }if(texto.Enabled == true)
            {
                texto.Enabled = false;
            }
            if(comboBox1.SelectedItem.ToString() == "CIUDAD") 
            {
                categoriaCombo.Items.Add("Bogotá");
                categoriaCombo.Items.Add("Fuera de Bogotá");
                categoriaCombo.Items.Add("Sin dato");
                if (categoriaCombo.Text == "Bogotá")
                {
                }
            }
            if (comboBox1.SelectedItem.ToString() == "SEXO")
            {
                categoriaCombo.Items.Add("Femenino");
                categoriaCombo.Items.Add("Masculino");
 
                if (categoriaCombo.Text == "Bogotá")
                {

                }
            }

        }
        public void cadena()
        {
            texto.Enabled = true;
            if (numerico1.Enabled == true && numerico2.Enabled == true)
            {
                numerico1.Enabled = false;
                numerico2.Enabled = false;
            }if(categoriaCombo.Enabled == true)
            {
                categoriaCombo.Enabled = false;
            }
        }

    }
}
