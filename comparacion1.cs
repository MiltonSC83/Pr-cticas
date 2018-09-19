using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglos
{
    public partial class Form1 : Form
    {
        string[] arreglo2 = { "Alejandro", "Erick", "Carlos", "Antonio", "Sebastian", "Antonio" };
        string[] arreglo3 = { "Alejandro", "Erick", "Carlos", "Antonio", "Sebastian", "Milton" };
        int i;
        int[] arreglo1 = {1,2 };
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<List<string>> Listanombres;
            Listanombres = new List<List<string>>();

            List<string> NombreList;
            NombreList = new List<string>();

            List<string> Apellido;
            Apellido = new List<string>();

            List<string> NumeroList;
            NumeroList = new List<string>();

            NombreList.Add("Alejandro");
            NombreList.Add("Erick");
            Apellido.Add("Perez");
            Apellido.Add("Contreras");
            NumeroList.Add("12345");
            NumeroList.Add("67890");

            Listanombres.Add(NombreList);
            Listanombres.Add(Apellido);
            Listanombres.Add(NumeroList);


            dataGridView3.ColumnCount = 4;
            dataGridView3.Columns[0].Name = "Apellido paterno";
            dataGridView3.Columns[1].Name = "Apellido materno";
            dataGridView3.Columns[2].Name = "Nombres";
            dataGridView3.Columns[3].Name = "Numero de cuenta";
            
            for (i = 0; i < Listanombres.Count; i++)
            {
                dataGridView3.Rows.Add();
                for (int j = 0; j < 2; j++)
                {
                    dataGridView3.Rows[i].Cells[j].Value = Listanombres[i][j];
                }

            }
            

            string[,] NombreCompletoArray = new string[7, 4] { { "ARZATE", "GOMEZ", "JESUS ALEJANDRO", "314168126" }, { "BARCENAS", "MARTINEZ", "ERICK IVAN", "417092331" }, { "LAGUNA", "LOPEZ", "LUIS ANTONIO", "313067136" }, { "MARTINEZ", "ANDRADE", "SEBASTIAN ALDAIR", "313041578" }, { "SANCHEZ", "RUIZ", "LUIS ARMANDO", "305303965" }, { "SOSA", "CORONA", "MILTON OSMAR", "314308067" }, { "URIBE", "SERRALDE", "ARMANDO", "314104326" } };

            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Apellido paterno";
            dataGridView1.Columns[1].Name = "Apellido materno";
            dataGridView1.Columns[2].Name = "Nombres";
            dataGridView1.Columns[3].Name = "Numero de cuenta";

            string[][] NombreCompletoJArray = new string[7][];

            NombreCompletoJArray[0] = new string[] { "ARZATE", "GOMEZ", "JESUS ALEJANDRO", "314168126" };
            NombreCompletoJArray[1] = new string[] { "BARCENAS", "MARTINEZ", "ERICK IVAN", "417092331" };
            NombreCompletoJArray[2] = new string[] { "LAGUNA2", "LOPEZ", "LUIS ANTONIO", "313067136" };
            NombreCompletoJArray[3] = new string[] { "MARTINEZ", "ANDRADE", "SEBASTIAN ALDAIR", "313041578" };
            NombreCompletoJArray[4] = new string[] { "SANCHEZ", "RUIZ", "LUIS ARMANDO", "305303965" };
            NombreCompletoJArray[5] = new string[] { "SOSA", "CORONA", "MILTON OSMAR", "314308067" };
            NombreCompletoJArray[6] = new string[] { "URIBE", "SERRALDE", "ARMANDO", "314104326" };

            for (i = 0; i < 7; i++)
            {
                dataGridView1.Rows.Add();
                for (int j = 0; j < 4; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = NombreCompletoArray[i, j];
                }

            }

           

            dataGridView2.ColumnCount = 4;
            dataGridView2.Columns[0].Name = "Apellido Materno";
            dataGridView2.Columns[1].Name = "Apellido Paterno";
            dataGridView2.Columns[2].Name = "Nombre";
            dataGridView2.Columns[3].Name = "Numero de cuenta";


            for (int i = 0; i < 7; i++)
            {
                dataGridView2.Rows.Add();
                for (int j = 0; j < 4; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = NombreCompletoJArray[i][j];
                }

            }

        }    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

