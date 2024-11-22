using System.Data;
using System;
using System.IO;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<int> notas = new List<int>(); // Lista para almacenar notas válidas de manera global
        private List<string> registrosOmitidos = new List<string>();

        private void btn_Load_Click(object sender, EventArgs e)
        {
            //Abre un dialogo de seleccion de archivo CSV con su respectivo filtro para NO cargar otro tipo de archivo
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            openFileDialog.Title = "Seleccione un archivo csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                try
                {
                    /*
                     *  
                     * 
                     */
                    (DataTable dataTable, List<string> errores, List<int> notasCargadas) = LeerYValidarCSV(filePath);
                    notas = notasCargadas; // Guardar las notas válidas en la lista global

                    if (dataTable != null)
                    {
                        dgv_CSV.DataSource = dataTable;

                        if (errores.Count == 0)
                        {
                            MessageBox.Show("Todos los datos son correctos.");
                        }
                        else
                        {
                            string mensajeErrores = "Errores encontrados en las siguientes líneas:\n" + string.Join("\n", errores);
                            MessageBox.Show(mensajeErrores);
                            MostrarRegistrosOmitidos(errores);
                            CargarErroresEnComboBox(errores);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer el archivo CSV: " + ex.Message);
                }
            }
        }

        //Funcion para leer y validar el CSV ademas que no tenga errores 
        //Dependiendo del renglo que tenga el error 
        private (DataTable, List<string>, List<int>) LeerYValidarCSV(string filePath)
        {
            DataTable dataTable = new DataTable();
            List<string> errores = new List<string>(); // Lista para almacenar líneas con errores
            List<int> notasTemp = new List<int>();     // Lista para almacenar notas válidas

            List<string> datos;
            try
            {
                datos = File.ReadLines(filePath).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo: {ex.Message}");
                return (null, errores, notasTemp);
            }

            if (datos.Count <= 1)
            {
                MessageBox.Show("El archivo está vacío o solo contiene encabezado.");
                return (null, errores, notasTemp);
            }

            string headerLine = datos[0];
            string[] headers = headerLine.Split(',');
            foreach (string header in headers)
            {
                dataTable.Columns.Add(header);
            }

            for (int i = 1; i < datos.Count; i++)
            {
                var renglon = datos[i];
                var datosSeparados = renglon.Split(',');

                if (datosSeparados.Length < 2)
                {
                    errores.Add($"Línea {i + 1}: '{renglon}' - formato incorrecto");
                    continue;
                }

                string nombre = datosSeparados[0].Trim();
                string notaStr = datosSeparados[1].Trim();
                int nota;

                // Usar CultureInfo para interpretar el número, adaptado para comas o puntos decimales.
                if (int.TryParse(notaStr, out nota))
                {
                    dataTable.Rows.Add(nombre, nota);
                    notasTemp.Add(nota);
                }
                else
                {
                    errores.Add($"Línea {i + 1}: '{renglon}' - nota no válida");
                }
            }

            return (dataTable, errores, notasTemp);
        }

        private void btn_lower_higher_Click(object sender, EventArgs e)
        {
            if (notas.Count > 0)
            {
                int mayorNota = notas.Max();
                int menorNota = notas.Min();


                // Mostrar los resultados en los TextBox
                txt_notaMayor.Text = mayorNota.ToString();
                txt_menorNota.Text = menorNota.ToString();
            }
            else
            {
                MessageBox.Show("No hay datos válidos para calcular estadísticas.");
            }
        }

        private void btn_average_Click(object sender, EventArgs e)

        {
            if (notas.Count > 0)
            {
                // Convertir la lista de notas de `int` a `double`
                List<double> notasDouble = notas.Select(n => (double)n).ToList();

                // Calcular la mediana con la lista de `double`
                double mediana = CalcularMediana(notasDouble);

                // Mostrar el resultado en el TextBox de la mediana
                txt_mediana.Text = mediana.ToString("F2"); // Mostrar con dos decimales
            }
            else
            {
                MessageBox.Show("No hay datos válidos para calcular la mediana.");
            }
        }
        private double CalcularMediana(List<double> datos)
        {
            var sortedDatos = datos.OrderBy(n => n).ToList();
            int count = sortedDatos.Count;

            if (count % 2 == 0)
            {
                // Si es par, se promedian los dos valores centrales
                return (sortedDatos[count / 2 - 1] + sortedDatos[count / 2]) / 2.0;
            }
            else
            {
                // Si es impar, se toma el valor central
                return sortedDatos[count / 2];
            }
        }

        private double CalcularPromedio(List<double> datos)
        {
            return datos.Average();
        }


        private void btn_Media_Click(object sender, EventArgs e)
        {

            // Verificar que haya datos válidos en la lista de notas
            if (notas.Count > 0)
            {
                double average = notas.Average();

                txt_Media.Text = average.ToString();
            }
            else
            {
                MessageBox.Show("No hay datos válidos para calcular la mediana.");
            }
        }

        private void btn_Style_Click(object sender, EventArgs e)
        {
            // Verificar que haya datos válidos en la lista de notas
            if (notas.Count > 0)
            {
                // Convertir la lista de notas de `int` a `double`, si es necesario
                List<double> notasDouble = notas.Select(n => (double)n).ToList();

                // Calcular la moda
                double moda = CalcularModa(notasDouble);

                // Mostrar el resultado en el TextBox de la moda
                txt_Moda.Text = moda.ToString("F1"); // Mostrar con dos decimales
            }
            else
            {
                MessageBox.Show("No hay datos válidos para calcular la moda.");
            }
        }

        private double CalcularModa(List<double> datos)
        {
            return datos.GroupBy(n => n)
            .OrderByDescending(g => g.Count())
            .First()
            .Key;
        }

        //Lista de registros de errores omitidos(funcion)
        private void MostrarRegistrosOmitidos(List<string> registrosOmitidos)
        {
            cmBox_Errores.Text = registrosOmitidos.Count.ToString();
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            // Limpiar TextBox de resultados
            txt_notaMayor.Clear();
            txt_menorNota.Clear();
            txt_Media.Clear();
            txt_mediana.Clear();
            txt_Moda.Clear();
            cmBox_Errores.Items.Clear();
            cmBox_Errores.Text = string.Empty;

            dgv_CSV.DataSource = null;
        }

        private void CargarErroresEnComboBox(List<string> errores)
        {
            // Limpiar ComboBox de errores antes de agregar nuevos
            cmBox_Errores.Items.Clear();

            // Agregar el conteo de errores como el primer elemento
            cmBox_Errores.Items.Add($"Total de errores omitidos: {errores.Count}");

            // Agregar cada error a la lista de ComboBox
            foreach (var error in errores)
            {
                cmBox_Errores.Items.Add(error);
            }

            // Seleccionar el primer elemento del ComboBox para mostrar el conteo
            if (cmBox_Errores.Items.Count > 0)
            {
                cmBox_Errores.SelectedIndex = 0;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
