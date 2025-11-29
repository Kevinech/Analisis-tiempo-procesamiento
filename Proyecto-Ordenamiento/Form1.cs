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

            GetMostrarV(datos);

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

        private void GetMostrarV(int[] arr)
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

            bool ok = GetEstaOrdenado(copia);
            MessageBox.Show(ok ? "Ordenado correctamente" : "Hay un error en el ordenamiento");

            datos = copia;
            GetMostrarV(datos);

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
        private bool GetEstaOrdenado(int[] arr)
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

            copia = GetMergeSortInts(copia);

            if (!GetEstaOrdenado(copia))
            {
                MessageBox.Show("Error en el ordenamiento.");
                return;
            }

            datos = copia;
            GetMostrarV(datos);

            sw.Stop();

            lblTimeMerge.Text = $"Tiempo Merge: {sw.ElapsedMilliseconds} ms";

        }

        private int[] GetMergeSortInts(int[] arr)
        {
            if (arr.Length <= 1) return arr;

            int mid = arr.Length / 2;
            int[] left = arr.Take(mid).ToArray();
            int[] right = arr.Skip(mid).ToArray();

            left = GetMergeSortInts(left);

            right = GetMergeSortInts(right);

            return GetMergeInts(left, right);

        }

        private int[] GetMergeInts(int[] left, int[] right)
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

        private void btnJumpSearch_Click(object sender, EventArgs e)
        {
            if (datos == null)
            {
                MessageBox.Show("Primero debe generar los números.");
                return;

            }

            if (!GetEstaOrdenado(datos))
            {
                MessageBox.Show("Primero debes ordenar los datos (Selection Sort o Merge Sort).");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbBuscar.Text) || !int.TryParse(tbBuscar.Text, out int target))
            {
                MessageBox.Show("Ingrese un número válido a buscar.");
                return;
            }

            Stopwatch sw = Stopwatch.StartNew();

            int idx = GetJumpSearch(datos, target);

            sw.Stop();

            lblTimeJump.Text = $"Tiempo Jump: {sw.ElapsedMilliseconds} ms";

            string resultado = "JUMP SEARCH - ";
            

            if (idx >= 0)
            {
                 resultado += $"ENCONTRADO\n\n" +
                 $"Número buscado: {target}\n" +
                 $"Índice encontrado: {idx}\n" +
                 $"Valor en índice: {datos[idx]}\n" +
                 $"Tiempo: {sw.ElapsedMilliseconds} ms\n";
                GetMostrarR(resultado, System.Drawing.Color.Green);
            }
            else
            {
                resultado = $"NO ENCONTRADO\n\n" +
                $"Número buscado: {target}\n" +
                $"Resultado: No existe en el arreglo\n" +
                $"Tiempo: {sw.ElapsedMilliseconds} ms\n";
                GetMostrarR(resultado, System.Drawing.Color.Red);
            }



        }




        private int GetJumpSearch(int[] arr, int target)
        {
            int n = arr.Length;
            int step = (int)Math.Sqrt(n);
            int prev = 0;

            while (prev < n && arr[Math.Min(step, n) -1] < target)
            {
                prev = step;
                step += (int)Math.Sqrt(n);
                if (prev >= n) return -1;
            }

            while (prev < Math.Min(step, n) && arr[prev] < target)
            {
                prev++;
            }

            if (prev < n && arr[prev] == target)
            {
                return prev;
            }
            return -1;



        }

        private void btnInterpolSearch_Click(object sender, EventArgs e)
        {

            if (datos == null)
            {
                MessageBox.Show("Primero debe generar los números.");
                return;
            }

            if (!GetEstaOrdenado(datos))
            {
                MessageBox.Show("Primero debes ordenar los datos (Selection Sort o Merge Sort).");
                return;
            }


            if (string.IsNullOrWhiteSpace(tbBuscar.Text) || !int.TryParse(tbBuscar.Text, out int target))
            {
                MessageBox.Show("Ingrese un número válido a buscar.");
                return;
            }

            Stopwatch sw = Stopwatch.StartNew();

            int idx = GetInterSearch(datos, target);

            sw.Stop();

            lblTimeInterpol.Text = $"Tiempo Inter: {sw.ElapsedMilliseconds} ms";

            string resultado = "INTERPOLATION SEARCH -";


            if (idx >= 0)
            {
                resultado += $" ENCONTRADO\n\n" +
                $"Número buscado: {target}\n" +
                $"Índice encontrado: {idx}\n" +
                $"Valor en índice: {datos[idx]}\n" +
                $"Tiempo: {sw.ElapsedMilliseconds} ms\n";
                GetMostrarR(resultado, System.Drawing.Color.Green);
            }
            else
            {
                resultado += $"NO ENCONTRADO\n\n" +
                $"Número buscado: {target}\n" +
                $"Resultado: No existe en el arreglo\n" +
                $"Tiempo: {sw.ElapsedMilliseconds} ms\n";
                GetMostrarR(resultado, System.Drawing.Color.Red);

            }

        }


        private int GetInterSearch(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high && target >= arr[low] && target <= arr[high])
            {
                int pos = low + (int)((double)(target - arr[low]) / (arr[high] - arr[low] * (high - low)));

                if (arr[pos] == target)
                {
                    return pos;
                }
                   

                if (arr[pos] < target)
                {
                    low = pos + 1;
                }
                else
                {
                    high = pos - 1;
                }




            }
            return -1;

        }



        private void GetMostrarR(string texto, System.Drawing.Color color)
        {
            
            if (rtbBusqueda.Text.Length > 0)
                rtbBusqueda.AppendText("\n" + new string('=', 50) + "\n\n");

            rtbBusqueda.SelectionColor = color;
            rtbBusqueda.SelectionFont = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            rtbBusqueda.AppendText(texto);

  
            rtbBusqueda.SelectionStart = rtbBusqueda.Text.Length;
            rtbBusqueda.ScrollToCaret();
        }

       
    }
}
