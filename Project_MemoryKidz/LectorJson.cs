using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Project_MemoryKidz
{
    public partial class LectorJson : Form
    {
        // Ruta del archivo JSON a cargar.
        private string jsonFilePath;
        private Root root; // Variable para almacenar los datos deserializados
        private int currentGroupIndex = 0;

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

                // Deserializa el contenido JSON a un objeto de tipo Root.
                root = JsonConvert.DeserializeObject<Root>(jsonContent);

                // Verifica si se han cargado los datos correctamente.
                if (root == null || root.groups == null || root.groups.Count == 0)
                {
                    MessageBox.Show("El archivo JSON está vacío o no tiene los datos esperados.");
                    return;
                }

                // Limpiar cualquier dato previo en el DataGridView.
                dataGridView1.Rows.Clear();

                // Mapeo de avatares
                string[] avatars = { "Mono", "Tiburón", "Tortuga", "Serpiente", "Pájaro" };

                // Obtener el grupo actual
                Group group = root.groups[currentGroupIndex];

                // Iterar sobre los avatares del grupo
                foreach (var avatar in group.avatars)
                {
                    int totalAttempts = 0;
                    string timeLevel1 = "", timeLevel2 = "", timeLevel3 = "";

                    // Iterar sobre los niveles del avatar y asignar los tiempos correspondientes
                    foreach (var level in avatar.levels)
                    {
                        totalAttempts += level.attempts;

                        // Asignar los tiempos a los niveles correspondientes
                        if (level.level == 1)
                        {
                            timeLevel1 = level.time;
                        }
                        else if (level.level == 2)
                        {
                            timeLevel2 = level.time;
                        }
                        else if (level.level == 3)
                        {
                            timeLevel3 = level.time;
                        }
                    }

                    // Agregar los datos del avatar al DataGridView
                    dataGridView1.Rows.Add(
                        avatars[avatar.avatar - 1],   // Nombre del avatar
                        timeLevel1,                   // Tiempo del primer nivel
                        timeLevel2,                   // Tiempo del segundo nivel
                        timeLevel3,                   // Tiempo del tercer nivel
                        totalAttempts                 // Intentos totales
                    );
                }

            }
            catch (Exception ex)
            {
                // Si ocurre un error al leer o deserializar el archivo JSON, muestra un mensaje de error.
                MessageBox.Show("Error al cargar el archivo JSON: " + ex.Message);
            }
        }

        private void ButtonPreviousGroup_Click(object sender, EventArgs e)
        {
            if (currentGroupIndex > 0)
            {
                currentGroupIndex--;
                LoadJson(); // Cargar el grupo anterior
            }
            else
            {
                MessageBox.Show("Ya estás en el primer grupo.");
            }
        }

        private void buttonNextGroup_Click(object sender, EventArgs e)
        {
            if (currentGroupIndex < root.groups.Count - 1)
            {
                currentGroupIndex++;
                LoadJson(); // Cargar el siguiente grupo
            }
            else
            {
                MessageBox.Show("Ya estás en el último grupo.");
            }
        }
    }
}
