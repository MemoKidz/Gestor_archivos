using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Project_MemoryKidz
{

    /// <summary>
    /// Representa un formulario para leer y mostrar los datos de un archivo JSON en un DataGridView.
    /// Deserializa el archivo JSON que contiene una lista de partidas y lo presenta en una tabla.
    /// </summary>
    public partial class LectorJson : Form
    {

        /// <summary>
        /// Ruta del archivo JSON a cargar.
        /// </summary>
        private string jsonFilePath;


        /// <summary>
        /// Inicializa una nueva instancia del formulario <see cref="LectorJson"/> con la ruta del archivo JSON.
        /// </summary>
        /// <param name="filePath">Ruta del archivo JSON que se desea cargar.</param>
        public LectorJson(string filePath)
        {
            InitializeComponent();
            jsonFilePath = filePath;
            LoadJson();
            
        }


        /// <summary>
        /// Carga y deserializa el contenido del archivo JSON especificado.
        /// Muestra los datos deserializados en un DataGridView.
        /// </summary>
        private void LoadJson()
        {
            try
            {
                // Lee todo el contenido del archivo JSON.
                string jsonContent = File.ReadAllText(jsonFilePath);

                // Deserializa el contenido JSON a una lista de objetos de tipo Partida.
                List<Partida> partidas = JsonConvert.DeserializeObject<List<Partida>>(jsonContent);


                // Asigna la lista de partidas como fuente de datos del DataGridView.
                dataGridView1.DataSource = partidas;

                // Configura el ancho de las columnas para un mejor formato visual.

                dataGridView1.Columns[0].Width = 80;
                dataGridView1.Columns[1].Width = 110;
                dataGridView1.Columns[2].Width = 110;
                dataGridView1.Columns[3].Width = 110;
                dataGridView1.Columns[4].Width = 78;
                dataGridView1.Columns[5].Width = 110;

                // Renombra los encabezados de las columnas.
                dataGridView1.Columns[1].HeaderText = "Tiempo primer nivel";
                dataGridView1.Columns[2].HeaderText = "Tiempo segundo nivel";
                dataGridView1.Columns[3].HeaderText = "Tiempo tercer nivel";


                dataGridView1.Columns[5].HeaderText = "Fecha y hora";

            }
            catch (Exception ex)
            {
                // Si ocurre un error al leer o deserializar el archivo JSON, muestra un mensaje de error.
                MessageBox.Show("Error al cargar el archivo JSON:" + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
