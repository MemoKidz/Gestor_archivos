using Project_MemoryKidz.Properties;
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
    public partial class GestorDeArchivos : Form
    {

        private string filePath = "C:";
        private bool isFile = false;
        private string selectedItemName = "";
        private Stack<string> directoryHistory = new Stack<string>();

        public GestorDeArchivos()
        {
            InitializeComponent();
        }


        private void GestorDeArchivos_Load(object sender, EventArgs e)
        {
            textBoxPath.Text = filePath;
            deleteButton.Enabled = false;
            changeNameButton.Enabled = false;
            loadFilesAndDirectories(null);
        }

        private void loadFilesAndDirectories(string tipoArchivo)
        {
            try
            {
                listViewFiles.Items.Clear();
                DirectoryInfo fileList = new DirectoryInfo(filePath);

                FileInfo[] files = fileList.GetFiles();
                DirectoryInfo[] directories = fileList.GetDirectories();


                foreach (var directory in directories)
                {
                    ListViewItem item = new ListViewItem(directory.Name);

                    item.ImageIndex = 0;

                    listViewFiles.Items.Add(item);
                }

                foreach (var file in files)
                {

                    if (tipoArchivo == null || file.Extension.Equals(tipoArchivo, StringComparison.OrdinalIgnoreCase))
                    {
                        ListViewItem item = new ListViewItem(file.Name);

                        item.ImageIndex = getImageIndexByExtension(file.Extension);

                        listViewFiles.Items.Add(item);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los archivos y directorios");
            }
        }

        private int getImageIndexByExtension(string extension)
        {
            int imageIndex = 8;

            switch (extension.ToLower())
            {
                case ".json":
                    imageIndex = 1;
                    break;
                case ".pdf":
                    imageIndex = 2;
                    break;
                case ".doc":
                    imageIndex = 3;
                    break;
                case ".exe":
                    imageIndex = 4;
                    break;
                case ".png":
                case ".jpg":
                case ".jpeg":
                    imageIndex = 5;
                    break;
                case ".mp3":
                    imageIndex = 6;
                    break;
                case ".mp4":
                    imageIndex = 7;
                    break;
                default:
                    imageIndex = 8;
                    break;
            }

            return imageIndex;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folder = new FolderBrowserDialog())
            {
                DialogResult result = folder.ShowDialog();

                if (result == DialogResult.OK)
                {
                    filePath = folder.SelectedPath;
                    textBoxPath.Text = filePath;
                    loadFilesAndDirectories(null);
                }
            }
        }

        private void listViewFiles_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedItemName = e.IsSelected ? e.Item.Text : "";
            deleteButton.Enabled = !string.IsNullOrEmpty(selectedItemName);
            changeNameButton.Enabled = !string.IsNullOrEmpty(selectedItemName);


            FileAttributes fileAttr = File.GetAttributes(filePath + "/" + selectedItemName);
            if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                textBoxPath.Text = filePath + "/" + selectedItemName;
            }
            else
            {
                isFile = true;
            }
        }

        private void listViewFiles_DoubleClick(object sender, EventArgs e)
        {
            if (listViewFiles.SelectedItems.Count > 0)
            {
                selectedItemName = listViewFiles.SelectedItems[0].Text;
                string newPath = Path.Combine(filePath, selectedItemName);

                if (Directory.Exists(newPath))
                {
                    directoryHistory.Push(filePath);
                    filePath = newPath;
                    textBoxPath.Text = filePath;
                    loadFilesAndDirectories(null);
                    deleteButton.Enabled = false;
                    changeNameButton.Enabled = false;
                }
                else
                {
                    if (Path.GetExtension(newPath).ToLower() == ".json")
                    {
                        LectorJson lector = new LectorJson(newPath);
                        lector.ShowDialog();
                    }
                    else
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(newPath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se pudo abrir el archivo: " + ex.Message);
                        }
                    }
                }
            }
        }



        private void backButton_Click(object sender, EventArgs e)
        {
            if (directoryHistory.Count > 0)
            {
                filePath = directoryHistory.Pop();
                textBoxPath.Text = filePath;
                loadFilesAndDirectories(null);
            }
            else
            {
                MessageBox.Show("No hay directorios anteriores.");
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (selectedItemName != "")
            {
                DialogResult dialog = MessageBox.Show("¿Estas seguro de esta acción?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    string newPath = Path.Combine(filePath, selectedItemName);
                    if (Directory.Exists(newPath))
                    {
                        Directory.Delete(newPath);
                    }
                    else
                    {
                        File.Delete(newPath);
                    }
                    loadFilesAndDirectories(null);
                    deleteButton.Enabled = false;
                }

            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún archivo!");
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {


            using (FormularioFiltrar filtro = new FormularioFiltrar())
            {
                if (filtro.ShowDialog() == DialogResult.OK)
                {
                    String tipoArchivo = filtro.tipoArchivoSeleccionado.ToString();

                    loadFilesAndDirectories(tipoArchivo);

                }
            }

        }

        private void changeNameButton_Click(object sender, EventArgs e)
        {

            // Pedir al usuario el nuevo nombre
            string nuevoNombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nuevo nombre:", "Renombrar", selectedItemName);

            // Validar que el usuario no haya cancelado
            if (string.IsNullOrEmpty(nuevoNombre))
            {
                return; // Si se cancela, no hacemos nada
            }

            try
            {
                string currentPath = Path.Combine(filePath, selectedItemName);
                string newPath = Path.Combine(filePath, nuevoNombre);

                // Verificar si el nuevo nombre ya existe
                if (File.Exists(newPath) || Directory.Exists(newPath))
                {
                    MessageBox.Show("Ya existe un archivo o carpeta con ese nombre.");
                    return;
                }

                // Renombrar archivo o carpeta
                if (isFile)
                {
                    File.Move(currentPath, newPath);
                }
                else
                {
                    Directory.Move(currentPath, newPath);
                }

                // Recargar los archivos y directorios
                changeNameButton.Enabled = false;
                deleteButton.Enabled = false;
                loadFilesAndDirectories(null);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al renombrar: " + ex.Message);
            }

        }

        private void createFolderButton_Click(object sender, EventArgs e)
        {

            string newFolderName = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nombre de la nueva carpeta:", "Crear carpeta");
            //filePath es la variable del path actual

            if (string.IsNullOrEmpty(newFolderName))
            {
                return; // Si se cancela, no hacemos nada
            }

            try
            {
                string newCreationPath = Path.Combine(filePath, newFolderName);

                if (!Directory.Exists(newCreationPath))
                {
                    Directory.CreateDirectory(newCreationPath);
                    MessageBox.Show("Nueva carpeta creada!");
                    loadFilesAndDirectories(null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear nueva carpeta: " + ex.Message);
            }
        }

        private void createFileButton_Click(object sender, EventArgs e)
        {
            using (FormularioCrearArchivo nuevoArchivo = new FormularioCrearArchivo())
            {
                if (nuevoArchivo.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
}
