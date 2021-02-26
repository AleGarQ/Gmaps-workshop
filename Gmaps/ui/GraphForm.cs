using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Gmaps.ui
{
    public partial class GraphForm : Form
    {
       
        List<Principal> lista;
        public GraphForm()
        {
            Console.WriteLine("antes del ini");
            InitializeComponent();
            Console.WriteLine("despues");
            chart1.Series["s1"].IsValueShownAsLabel = true;
            chart2.Series["s2"].IsValueShownAsLabel = true;
            chart3.Series["s3"].IsValueShownAsLabel = true;

            chart1.Titles.Add("Grafico 1");
            chart2.Titles.Add("Grafico 2");
            chart3.Titles.Add("Grafico 3");

            metodob();
            Console.WriteLine("despues de metodo b");

            
        }

        private void metodob()
        {
            OpenFileDialog FileExplorer = new OpenFileDialog();
            string path = "";


            if (FileExplorer.ShowDialog() == DialogResult.OK)
            {
                path = FileExplorer.FileName;
            }
            
            SLDocument sl = new SLDocument(path);
            Console.WriteLine("BBBBBBBBBB");
            int iRow = 2;
            List<Principal> lst = new List<Principal>();
            int count = 0;
            Console.WriteLine("antes del while");
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)) && iRow < 30 && count != 99)
            {
                Console.WriteLine(count);
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
                count++;
                Console.WriteLine("por aca pase" + count);
                if (count == 100)
                {
                    Console.WriteLine("100!!!");
                    break;
                }
            }
            lista = lst;
            Metodoa();
        }

        public void Metodoa()
        {
            int count = 0;
            foreach (Principal i in lista)
            {
                count++;
                chart1.Series["s1"].Points.AddXY(i.FUENTE, i.EDAD);
                chart2.Series["s2"].Points.AddXY(i.LOCALIDAD, i.EDAD);
                chart3.Series["s3"].Points.AddXY(i.UBICACION, i.EDAD);
                if (count == 100)
                {
                    break;
                } 
            }
        }

        private void CloseBTN(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void GraphForm_Load(object sender, EventArgs e)
        {

            

        }
    }
}
