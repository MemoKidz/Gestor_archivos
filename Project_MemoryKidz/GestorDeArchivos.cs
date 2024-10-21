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

        private string filePath = "D:";
        private bool isFile = false;
        private string selectedItemName = "";

        public GestorDeArchivos()
        {
            InitializeComponent();
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
    }
}
