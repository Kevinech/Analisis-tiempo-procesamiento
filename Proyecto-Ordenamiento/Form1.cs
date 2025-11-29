using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace Proyecto_Ordenamiento
{
    public partial class Form1 : Form
    {

        private int[] datos;
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

           
            Stopwatch swGen = Stopwatch.StartNew();

            datos = GetPalabrasR(n, 1, 1_000_000);

            MostrarV(datos);

            swGen.Stop();


            lblTiempoGenerar.Text = $"Tiempo generar: {swGen.ElapsedMilliseconds} ms";


            lblTimeSelection.Text = "Tiempo Selection: ";
            lblTimeSelection.Text = "Tiempo Selection: ";
            lblTimeMerge.Text = "Tiempo Merge: ";
            lblTimeJump.Text = "Tiempo Jump: ";
            lblTimeInterpol.Text = "Tiempo Interpolation: ";

        }


        private int[] GetPalabrasR(int cantidad, int min, int max)
        {


            int[] arr = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                arr[i] = rnd.Next(min, max + 1);
            }
            return arr;

        }

        private void MostrarV(int[] arr)
        {
            lbVista.Items.Clear();
            if (arr == null) return;

           
            for (int i = 0; i < arr.Length; i++)
            {
                lbVista.Items.Add($"{i}: {arr[i]}");
            }
        }
    }
}

