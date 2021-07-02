using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAREA5_REPOSITORIOLP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Consultarbutton1_Click(object sender, EventArgs e)
        {
            int fila, columna;

            fila = int.Parse(FilatextBox1.Text);
            columna = int.Parse(ColumnatextBox2.Text);
            int[,] matriz = new int[fila, columna];
            Random aleatorio = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    matriz[i, j] = aleatorio.Next(0, 100);
                }
            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    MessageBox.Show("La posicion :" + i + "," + j + "=" + matriz[i, j].ToString());
                }
            }





        }
    }
}
