using Newtonsoft.Json;
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

namespace Project_MemoryKidz
{
    public partial class LectorJson : Form
    {
        private string jsonFilePath;

        public LectorJson(string filePath)
        {
            InitializeComponent();
            jsonFilePath = filePath;
            LoadJson();
            
        }

        private void LoadJson()
        {
            try
            {
                string jsonContent = File.ReadAllText(jsonFilePath);

                List<Partida> partidas = JsonConvert.DeserializeObject<List<Partida>>(jsonContent);

                dataGridView1.DataSource = partidas;               
                dataGridView1.Columns[0].Width = 80;
                dataGridView1.Columns[1].Width = 110;
                dataGridView1.Columns[2].Width = 110;
                dataGridView1.Columns[3].Width = 110;
                dataGridView1.Columns[4].Width = 110;
                dataGridView1.Columns[5].Width = 78;
                dataGridView1.Columns[6].Width = 110;

                dataGridView1.Columns[1].HeaderText = "Tiempo primer nivel";
                dataGridView1.Columns[2].HeaderText = "Tiempo segundo nivel";
                dataGridView1.Columns[3].HeaderText = "Tiempo tercer nivel";
                dataGridView1.Columns[4].HeaderText = "Tiempo cuarto nivel";

                dataGridView1.Columns[6].HeaderText = "Fecha y hora";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo JSON");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
