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

        public GestorDeArchivos()
        {
            InitializeComponent();
            InitializeImageList();
        }


        private void GestorDeArchivos_Load(object sender, EventArgs e)
        {
            textBoxPath.Text = filePath;
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

        // Agregar directorios
        foreach (var directory in directories)
        {
            ListViewItem item = new ListViewItem(directory.Name)
            {
                ImageKey = "folder" // Icono para carpetas
            };
            listViewFiles.Items.Add(item);
        }

        // Agregar archivos con icono según su tipo
        foreach (var file in files)
        {
            string extension = file.Extension.ToLower();
            string imageKey;

            // Asigna un icono según la extensión del archivo
            switch (extension)
            {
                case ".doc":
                case ".docx":
                    imageKey = "doc";
                    break;
                case ".pdf":
                    imageKey = "pdf";
                    break;
                case ".mp3":
                    imageKey = "mp3";
                    break;
                case ".mp4":
                    imageKey = "mp4";
                    break;
                case ".exe":
                    imageKey = "exe";
                    break;
                case ".png":
                case ".jpg":
                case ".jpeg":
                    imageKey = "png";
                    break;
                case ".json":
                    imageKey = "json";
                    break;
                default:
                    imageKey = "unknown"; // Para tipos desconocidos
                    break;
            }

            ListViewItem item = new ListViewItem(file.Name)
            {
                ImageKey = imageKey // Asigna el icono según el tipo de archivo
            };
            listViewFiles.Items.Add(item);
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error al cargar archivos y directorios: " + ex.Message);
    }
}


        public void loadButtonAction()
        {
            filePath = textBoxPath.Text;
            loadFilesAndDirectories();
            isFile = false;
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
            selectedItemName = e.Item.Text;

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
                    filePath = newPath; 
                    textBoxPath.Text = filePath; 
                    loadFilesAndDirectories(); 
                }
                else
                {
                    MessageBox.Show("Has seleccionado un archivo: " + selectedItemName);
                }
            }
        }
        
        private void InitializeImageList()
        {
            string resourcePath = Path.Combine(Application.StartupPath, "resources");
            try
            {
                imageList1.Images.Add("folder", Image.FromFile(Path.Combine(resourcePath, "folder.png")));
                imageList1.Images.Add("doc", Image.FromFile(Path.Combine(resourcePath, "doc.png")));
                imageList1.Images.Add("pdf", Image.FromFile(Path.Combine(resourcePath, "pdf.png")));
                imageList1.Images.Add("mp3", Image.FromFile(Path.Combine(resourcePath, "mp3.png")));
                imageList1.Images.Add("mp4", Image.FromFile(Path.Combine(resourcePath, "mp4-file.png")));
                imageList1.Images.Add("exe", Image.FromFile(Path.Combine(resourcePath, "exe.png")));
                imageList1.Images.Add("png", Image.FromFile(Path.Combine(resourcePath, "png.png")));              
                imageList1.Images.Add("json", Image.FromFile(Path.Combine(resourcePath, "json-file.png")));
                imageList1.Images.Add("unknown", Image.FromFile(Path.Combine(resourcePath, "unknown.png")));

                listViewFiles.SmallImageList = imageList1; // Asigna el ImageList al ListView
            }
            catch (Exception ex) {
                MessageBox.Show("Error al cargar imágenes: " + ex.Message);
            }            
        }     

    }
}
