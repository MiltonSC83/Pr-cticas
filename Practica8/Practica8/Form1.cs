using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Queue<string> QueueNombre = new Queue<string>();
            Queue<string> QueueApellidos = new Queue<string>();
            Queue<string> QueueNumeroDeCuenta = new Queue<string>();
            Queue<Queue<string>> QueueNombreCompleto = new Queue<Queue<string>>();


            QueueNombre.Enqueue("JESUS ALEJANDRO");
            QueueNombre.Enqueue("ERICK IVAN");
            QueueNombre.Enqueue("LUIS ANTONIO");
            QueueNombre.Enqueue("SEBASTIAN ALDAIR");
            QueueNombre.Enqueue("LUIS ARMANDO");
            QueueNombre.Enqueue("MILTON OSMAR");
            QueueNombre.Enqueue("Armando");

            QueueApellidos.Enqueue("ARZATE");
            QueueApellidos.Enqueue("BARCENAS");
            QueueApellidos.Enqueue("LAGUNA2");
            QueueApellidos.Enqueue("MARTINEZ");
            QueueApellidos.Enqueue("SANCHEZ");
            QueueApellidos.Enqueue("SOSA");
            QueueApellidos.Enqueue("Uribe");

            QueueNumeroDeCuenta.Enqueue("1");
            QueueNumeroDeCuenta.Enqueue("2");
            QueueNumeroDeCuenta.Enqueue("3");
            QueueNumeroDeCuenta.Enqueue("4");
            QueueNumeroDeCuenta.Enqueue("5");
            QueueNumeroDeCuenta.Enqueue("6");
            QueueNumeroDeCuenta.Enqueue("7");

            QueueNombreCompleto.Enqueue(QueueNombre); QueueNombreCompleto.Enqueue(QueueApellidos);
            QueueNombreCompleto.Enqueue(QueueNumeroDeCuenta);

            dataGridView1.ColumnCount = 3; dataGridView1.Columns[0].Name = "Apellido Paterno";
            dataGridView1.Columns[1].Name = "Nombre";
            dataGridView1.Columns[2].Name = "Numero de cuenta";

            for (int contadorFilas = 0; contadorFilas < 7; contadorFilas++)
            {
                Boolean flag1 = true;
                dataGridView1.Rows.Add();
                for (int contadorCol = 0; contadorCol < 2; contadorCol++)
                {
                    if (flag1)
                    {
                        dataGridView1.Rows[contadorFilas].Cells[contadorCol].Value = QueueApellidos.Peek();
                        QueueApellidos.Dequeue();
                        flag1 = false;

                    }
                    else
                    {
                        dataGridView1.Rows[contadorFilas].Cells[contadorCol].Value = QueueNombre.Peek();
                        QueueNombre.Dequeue();
                        flag1 = true;
                    }
                }
            }

        }
    }
    
}
