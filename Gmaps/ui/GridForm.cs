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
using System.IO;
using System.Collections;

namespace Gmaps.ui
{
    public partial class GridForm : Form
    {
        private string path = "..\\..\\data\\COVID.xlsx";

        public object Rows { get; private set; }

        public GridForm()
        {
            InitializeComponent();
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
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
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
        /*    public List<Principal> filtrado()
            {
                string[] stg = File.ReadAllLines(path);
                List<Principal> tmp = new List<Principal>();
                if ()
                {

                }


                return tmp;
            }
        */
        public string[] Numerico()
        {
            numerico1.Enabled = true;
            numerico2.Enabled = true;
            filter.Visible = true;
            if (categoriaCombo.Enabled == true)
            {
                categoriaCombo.Enabled = false;
            }
            string[] stg = { numerico1.Text.ToString(), numerico2.Text.ToString() };
            return stg;
        }

        public void categorico()
        {
            categoriaCombo.Enabled = true;
            categoriaCombo.Items.Clear();
            if (numerico1.Enabled == true && numerico2.Enabled == true)
            {
                numerico1.Enabled = false;
                numerico2.Enabled = false;
                numerico1.Text = "";
                numerico2.Text = "";
                filter.Visible = false;
            }
            if (comboBox1.SelectedItem.ToString() == "CIUDAD")
            {
                categoriaCombo.Items.Add("Bogotá");
                categoriaCombo.Items.Add("Fuera de Bogotá");
                categoriaCombo.Items.Add("Sin dato");
            }

            if (comboBox1.SelectedItem.ToString() == "SEXO")
            {
                categoriaCombo.Items.Add("Femenino");
                categoriaCombo.Items.Add("Masculino");
            }

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) //numerico
            {
                Numerico();
            }
            if (comboBox1.SelectedIndex == 1) //categorico
            {
                categorico();
            }
            if (comboBox1.SelectedIndex == 2) //numerico
            {
                Numerico();
            }
            if (comboBox1.SelectedIndex == 3) //categorico
            {
                categorico();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            loadData();
            categoriaCombo.Items.Clear();
        }

        private void categoriaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "SEXO")
            {

                if (categoriaCombo.SelectedItem.ToString() == "Femenino")
                {
                    for (int row = 1; row <= 6890; row++)
                    {
                        string r = (string)dataGridView1.Rows[row].Cells[6].Value;
                        if (r != "F")
                        {
                            dataGridView1.Rows[row].Visible = false;
                        }
                    }
                }
                if (categoriaCombo.SelectedItem.ToString() == "Masculino")
                {
                    for (int row = 1; row <= 6890; row++)
                    {
                        string r = (string)dataGridView1.Rows[row].Cells[6].Value;
                        if (r != "M")
                        {
                            dataGridView1.Rows[row].Visible = false;
                        }
                    }
                }
            }
            if (comboBox1.SelectedItem.ToString() == "CIUDAD")
            {
                if (categoriaCombo.SelectedItem.ToString().Equals(""))
                {
                    categoriaCombo.Items.Add("Bogotá");
                    categoriaCombo.Items.Add("Fuera de Bogotá");
                    categoriaCombo.Items.Add("Sin dato");
                }

                if (categoriaCombo.SelectedItem.ToString() == "Bogotá")
                {
                    for (int row = 1; row <= 6890; row++)
                    {
                        string r = (string)dataGridView1.Rows[row].Cells[3].Value;
                        if (r != "Bogotá")
                        {
                            dataGridView1.Rows[row].Visible = false;
                        }
                    }
                }
                if (categoriaCombo.SelectedItem.ToString() == "Sin dato")
                {
                    for (int row = 1; row <= 6890; row++)
                    {
                        string r = (string)dataGridView1.Rows[row].Cells[3].Value;
                        if (r != "Sin dato")
                        {
                            dataGridView1.Rows[row].Visible = false;
                        }
                    }
                }
                if (categoriaCombo.SelectedItem.ToString() == "Fuera de Bogotá")
                {
                    for (int row = 1; row <= 6890; row++)
                    {
                        string r = (string)dataGridView1.Rows[row].Cells[3].Value;
                        if (r != "Fuera de Bogotá")
                        {
                            dataGridView1.Rows[row].Visible = false;
                        }
                    }
                }
            }
        }

        private void filter_Click(object sender, EventArgs e)
        {
           
            string[] valores = Numerico();
            int valorOne = int.Parse(valores[0]);
            int valorTwo = int.Parse(valores[1]);
            if(comboBox1.SelectedItem.ToString() == "CASO")
            {
                for (int row = 1; row <= 6890; row++)
                {
                    int r = (int)dataGridView1.Rows[row].Cells[0].Value;
                    if (!(r > valorOne - 1) || !(r < valorTwo + 1))
                    {
                        dataGridView1.Rows[row].Visible = false;
                    }
                }
            }
            if (comboBox1.SelectedItem.ToString() == "EDAD")
            {
                for (int row = 1; row <= 6890; row++)
                {
                    int r = (int)dataGridView1.Rows[row].Cells[5].Value;
                    if (!(r > valorOne - 1) || !(r < valorTwo + 1))
                    {
                        dataGridView1.Rows[row].Visible = false;
                    }
                }
            }

            numerico1.Text = "";
            numerico2.Text = "";
        }
    }
}
