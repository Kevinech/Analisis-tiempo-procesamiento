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

            cmbTamano.Items.AddRange(new object[] { "10000", "500000", "1000000", "5000000" });
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

            int max = Math.Min(arr.Length, 1000); 
            for (int i = 0; i < max; i++)
            {
                lbVista.Items.Add(arr[i]);   
            }
        }

        

        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            if (datos == null)
            {
                MessageBox.Show("Primero debe generar los números.");
                return;
            }

            int[] copia = (int[])datos.Clone();

            Stopwatch sw = Stopwatch.StartNew();
            SelectionSort(copia);

            bool ok = EstaOrdenado(copia);
            MessageBox.Show(ok ? "Ordenado correctamente" : "Hay un error en el ordenamiento");

            datos = copia;
            MostrarV(datos);

            sw.Stop();

            lblTimeSelection.Text = $"Tiempo Selection: {sw.ElapsedMilliseconds} ms";
        }

        private void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIdx = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIdx])
                        minIdx = j;
                }

                if (minIdx != i)
                {
                    int tmp = arr[i];
                    arr[i] = arr[minIdx];
                    arr[minIdx] = tmp;
                }
            }
        }
        private bool EstaOrdenado(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                    return false;
            }
            return true;
        }

        private void btnMergeSort_Click(object sender, EventArgs e)
        {
            if (datos == null)
            {
                MessageBox.Show("Primero debe generar los números.");
                return;
            }

            int[] copia = (int[])datos.Clone();
            Stopwatch sw = Stopwatch.StartNew();

            copia = MergeSortInts(copia);

            if (!EstaOrdenado(copia))
            {
                MessageBox.Show("Error en el ordenamiento.");
                return;
            }

            datos = copia;
            MostrarV(datos);

            sw.Stop();

            lblTimeMerge.Text = $"Tiempo Merge: {sw.ElapsedMilliseconds} ms";

        }

        private int[] MergeSortInts(int[] arr)
        {
            if (arr.Length <= 1) return arr;

            int mid = arr.Length / 2;
            int[] left = arr.Take(mid).ToArray();
            int[] right = arr.Skip(mid).ToArray();

            left = MergeSortInts(left);

            right = MergeSortInts(right);

            return MergeInts(left, right);

        }

        private int[] MergeInts(int[] left, int[] right)
        {

            int[] result = new int[left.Length + right.Length];
            int i = 0, j = 0, k = 0;


            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    result[k++] = left[i++];
                }
                else
                {
                    result[k++] = right[j++];
                }
            }

            while (i < left.Length)
            {
                result[k++] = left[i++];
            }

            while (j < right.Length)
            {
                result[k++] = right[j++];
            }


            return result;
        }




    }
}

