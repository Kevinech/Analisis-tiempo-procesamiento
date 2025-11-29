using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Ordenamiento
{
    public partial class Form1 : Form
    {

        private string[] datos;
        private readonly Random rnd = new Random();


        public Form1()
        {
            InitializeComponent();

            cmbTamano.Items.AddRange(new object[] { "500000", "1000000", "5000000" });
            cmbTamano.SelectedIndex = 0;

            lblTiempoGenerar.Text = "Tiempo generar: ";
            lblTimeSelection.Text = "Tiempo Selection: ";
            lblTimeMerge.Text = "Tiempo Merge: ";
            lblTimeJump.Text = "Tiempo Jump: ";
            lblTimeInterpol.Text = "Tiempo Interpolation: ";

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            int n = int.Parse(cmbTamano.SelectedItem.ToString());

            Stopwatch total = Stopwatch.StartNew();
            Stopwatch swGen = Stopwatch.StartNew();

            datos = GetPalabrasR(n, 5, 10);

            swGen.Stop();
            MostrarV(datos);

            total.Stop();

            lblTiempoGenerar.Text = $"Tiempo generar: {swGen.ElapsedMilliseconds / 1000} ms";


            lblTimeSelection.Text = "Tiempo Selection: ";
            lblTimeSelection.Text = "Tiempo Selection: ";
            lblTimeMerge.Text = "Tiempo Merge: ";
            lblTimeJump.Text = "Tiempo Jump: ";
            lblTimeInterpol.Text = "Tiempo Interpolation: ";

        }


        private string[] GetPalabrasR(int cantidad, int minLen, int maxLen)
        {

            string[] arr = new string[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                int len = rnd.Next(minLen, maxLen + 1);
                char[] chars = new char[len];
                for (int j = 0; j < len; j++)
                {
                    chars[j] = (char)rnd.Next('a', 'z' + 1);
                }
                arr[i] = new string(chars);
            }
            return arr;


        }
    }
}

