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
        public void Numerico()
        {
            numerico1.Enabled = true;
            numerico2.Enabled = true;
            if (categoriaCombo.Enabled == true)
            {
                categoriaCombo.Enabled = false;
            }
            if (texto.Enabled == true)
            {
                texto.Enabled = false;
            }

            //string[] lines = File.ReadAllLines(path);
            ArrayList ar = new ArrayList();

            for (int row = 1; row <= 6890; row++)
            {
                if (numerico1.Text != string.Empty && numerico2.Text != string.Empty)
                {
                    int num1 = int.Parse(numerico1.Text);
                    int num2 = int.Parse(numerico2.Text);
                    int valor = (int)dataGridView1.Rows[row].Cells[3].Value;

                    if (valor > num1 && valor < num2)
                    {
                        ar.Add(valor);

                    }
                    if (!ar.Contains(valor))
                    {
                        dataGridView1.Rows[row].Visible = false;
                    }
                }

            }
        }

        public void categorico()
        {
            categoriaCombo.Enabled = true;
            if (numerico1.Enabled == true && numerico2.Enabled == true)
            {
                numerico1.Enabled = false;
                numerico2.Enabled = false;
                numerico1.Text = "";
                numerico2.Text = "";
            }
            if (texto.Enabled == true)
            {
                texto.Enabled = false;
            }
            if (comboBox1.SelectedItem.ToString() == "CIUDAD")
            {
                categoriaCombo.Items.Add("Bogotá");
                categoriaCombo.Items.Add("Fuera de Bogotá");
                categoriaCombo.Items.Add("Sin dato");

                
            }

            /*if (comboBox1.SelectedItem.ToString() == "SEXO")
            {
                categoriaCombo.Items.Add("Femenino");
                categoriaCombo.Items.Add("Masculino");

                if (categoriaCombo.Text == "Bogotá")
                {

                }
            }*/

        }

        public void cadena()
        {
            texto.Enabled = true;
            if (numerico1.Enabled == true && numerico2.Enabled == true)
            {
                numerico1.Enabled = false;
                numerico2.Enabled = false;
            }
            if (categoriaCombo.Enabled == true)
            {
                categoriaCombo.Enabled = false;
                categoriaCombo.Text = "";
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
            if (comboBox1.SelectedIndex == 5) //cadena
            {
                cadena();
            }
            if (comboBox1.SelectedIndex == 7) //cadena
            {
                cadena();
            }
            if (comboBox1.SelectedIndex == 8) //categorico
            {
                categorico();
            }
            if (comboBox1.SelectedIndex == 9) //cadena
            {
                cadena();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void categoriaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "CIUDAD")
            {
                if (comboBox1.SelectedItem.ToString().Equals(""))
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
    }
}
