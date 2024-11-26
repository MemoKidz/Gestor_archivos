﻿using System;
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
                Group currentGroup = new Group
                {
                    group = 1,
                    avatars = new List<Avatar>()
                };

                foreach (DataGridViewRow row in createFileDataGridView.Rows)
                {
                    if (row.IsNewRow) continue;

                    int avatar = Convert.ToInt32(row.Cells["avatarColumn"].Value);

                    Avatar avatarObj = currentGroup.avatars.FirstOrDefault(a => a.avatar == avatar);

                    if (avatarObj == null)
                    {
                        avatarObj = new Avatar
                        {
                            avatar = avatar,
                            levels = new List<Level>()
                        };
                        currentGroup.avatars.Add(avatarObj);
                    }

                    avatarObj.levels.Add(new Level
                    {
                        level = 1,
                        time = row.Cells["level1TimeColumn"].Value.ToString(),
                        attempts = Convert.ToInt32(row.Cells["level1AttemptsColumn"].Value)
                    });

                    avatarObj.levels.Add(new Level
                    {
                        level = 2,
                        time = row.Cells["level2TimeColumn"].Value.ToString(),
                        attempts = Convert.ToInt32(row.Cells["level2AttemptsColumn"].Value)
                    });

                    avatarObj.levels.Add(new Level
                    {
                        level = 3,
                        time = row.Cells["level3TimeColumn"].Value.ToString(),
                        attempts = Convert.ToInt32(row.Cells["level3AttemptsColumn"].Value)
                    });
                }

                Root root = new Root
                {
                    groups = new List<Group> { currentGroup }
                };

                string jsonContent = JsonConvert.SerializeObject(root, Formatting.Indented);

                string newPath = Path.Combine(filePath, "partidas.json");
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



        private void FormularioCrearArchivo_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 6; i++)
            {
                createFileDataGridView.Rows.Add(i, "0:00", 0, "0:00", 0, "0:00", 0);
            }

            createFileDataGridView.AllowUserToAddRows = false;
        }
    }
}
