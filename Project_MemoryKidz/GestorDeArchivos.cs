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
            loadFilesAndDirectories();
        }

        private void loadFilesAndDirectories()
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
                    ListViewItem item = new ListViewItem(file.Name);

                    item.ImageIndex = getImageIndexByExtension(file.Extension);
                    
                    listViewFiles.Items.Add(item);
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
                    loadFilesAndDirectories();         
                }
            }
        }

        private void listViewFiles_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedItemName = e.IsSelected ? e.Item.Text : "";
            deleteButton.Enabled = !string.IsNullOrEmpty(selectedItemName);

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
                    loadFilesAndDirectories();
                    deleteButton.Enabled = false;
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
                loadFilesAndDirectories();
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
                    loadFilesAndDirectories();
                    deleteButton.Enabled = false;
                }

            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún archivo!");
            }
        }
    }
}
