using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Project_MemoryKidz
{
    public partial class FormularioCrearArchivo : Form
    {

        public string filePath { get; set; }

        public FormularioCrearArchivo()
        {
            InitializeComponent();
        }


        private void createFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Partida> partidas = new List<Partida>();

                foreach (DataGridViewRow row in createFileDataGridView.Rows)
                {
                    if (row.IsNewRow) continue;

                    DateTime? dateTimeColumnValue = null;

                    dateTimeColumnValue = (DateTime?)row.Cells["dateColumn"].Value;

                    if (dateTimeColumnValue == null)
                    {
                        row.Cells["dateColumn"].Value = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss"); ;
                    }



                    Partida partida = new Partida
                    {
                        Avatar = row.Cells["avatarColumn"].Value?.ToString(),
                        TiempoNivel1 = Convert.ToInt32(row.Cells["level1TimeColumn"].Value),
                        TiempoNivel2 = Convert.ToInt32(row.Cells["level2TimeColumn"].Value),
                        TiempoNivel3 = Convert.ToInt32(row.Cells["level3TimeColumn"].Value),
                        Fallos = Convert.ToInt32(row.Cells["failsColumn"].Value),
                        FechaHora = Convert.ToDateTime(row.Cells["dateColumn"].Value),
                    };

                    partidas.Add(partida);

                }

                string jsonContent = JsonConvert.SerializeObject(partidas, Formatting.Indented);

                // string filePath = Path.Combine(folderPath, "partidas.json"); // Aquí puedes especificar la ruta deseada

                String newPath = Path.Combine(filePath, "partidas.json");


                File.WriteAllText(newPath, jsonContent);

                MessageBox.Show("Datos guardados exitosamente en el archivo JSON.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos en el archivo JSON: " + ex.Message);

            }

            this.DialogResult = DialogResult.OK;
            this.Close(); 

        }

        private void createFileDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
