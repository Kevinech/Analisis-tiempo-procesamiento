using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Globalization;
using System.Diagnostics.Eventing.Reader;

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


            lblTiempoGenerar.Text = $"Tiempo generar: {(swGen.ElapsedMilliseconds / 1000)} seg";


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
                lbVista.Items.Add($"{arr[i]}");
            }
        }

        private void btnSelectionSort_Click(object sender, EventArgs e)
        {

            

            if (datos == null)
            {
                MessageBox.Show("Primero debe generar los números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
            int[] copia = (int[])datos.Clone();

            Stopwatch sw = Stopwatch.StartNew();
            
            SelectionSort(copia);

            datos = copia;
            MostrarV(datos);

            sw.Stop();

            lblTimeSelection.Text = $"Tiempo Selection: {(sw.ElapsedMilliseconds / 1000)} seg";
        }

        private void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = arr[1];
                    arr[1] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }



    }
}

