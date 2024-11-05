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

    /// <summary>
    /// Representa el formulario principal para gestionar archivos y directorios.
    /// Permite al usuario navegar por carpetas, visualizar y gestionar archivos (renombrar, eliminar, crear).
    /// </summary>
    public partial class GestorDeArchivos : Form
    {

        /// <summary>
        /// Ruta del directorio actual.
        /// </summary>
        private string filePath = "C:";

        /// <summary>
        /// Indica si el ítem seleccionado es un archivo.
        /// </summary>
        private bool isFile = false;

        /// <summary>
        /// Nombre del archivo o directorio seleccionado.
        /// </summary>
        private string selectedItemName = "";

        /// <summary>
        /// Historial de directorios para navegación hacia atrás.
        /// </summary>
        private Stack<string> directoryHistory = new Stack<string>();


        /// <summary>
        /// Inicializa una nueva instancia del formulario GestorDeArchivos.
        /// </summary>
        public GestorDeArchivos()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Evento que se ejecuta al cargar el formulario. 
        /// Configura la interfaz de usuario y carga los archivos y directorios del directorio inicial.
        /// </summary>
        /// <param name="sender">El objeto que originó el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void GestorDeArchivos_Load(object sender, EventArgs e)
        {
            textBoxPath.Text = filePath;
            deleteButton.Enabled = false;
            changeNameButton.Enabled = false;
            loadFilesAndDirectories(null);
        }

        /// <summary>
        /// Carga los archivos y directorios del directorio actual.
        /// Filtra los archivos por tipo si se especifica un tipo de archivo.
        /// </summary>
        /// <param name="tipoArchivo">El tipo de archivo para filtrar, o null para cargar todos los archivos.</param>
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
                MessageBox.Show("Error al cargar los archivos y directorios:" + ex.Message);
            }
        }


        /// <summary>
        /// Obtiene el índice de imagen correspondiente a la extensión del archivo.
        /// </summary>
        /// <param name="extension">La extensión del archivo (por ejemplo, .json, .pdf, .jpg).</param>
        /// <returns>El índice de la imagen asociada con la extensión del archivo.</returns>
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


        /// <summary>
        /// Evento que se ejecuta cuando se hace clic en el botón de búsqueda para seleccionar una nueva ruta de carpeta.
        /// Abre un cuadro de diálogo para seleccionar un directorio.
        /// </summary>
        /// <param name="sender">El objeto que originó el evento (el botón de búsqueda).</param>
        /// <param name="e">Argumentos del evento.</param>
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


        /// <summary>
        /// Evento que se ejecuta cuando se selecciona un ítem en la lista de archivos y directorios.
        /// Habilita o deshabilita los botones de eliminar y cambiar nombre, dependiendo de si un archivo o directorio está seleccionado.
        /// </summary>
        /// <param name="sender">El objeto que originó el evento (la lista de archivos y directorios).</param>
        /// <param name="e">Argumentos del evento.</param>
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


        /// <summary>
        /// Evento que se ejecuta cuando se hace doble clic sobre un ítem de la lista de archivos.
        /// Si es un directorio, navega a él. Si es un archivo, intenta abrirlo o procesarlo si es un archivo JSON.
        /// </summary>
        /// <param name="sender">El objeto que originó el evento (la lista de archivos y directorios).</param>
        /// <param name="e">Argumentos del evento.</param>
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


        /// <summary>
        /// Evento que se ejecuta cuando se hace clic en el botón de retroceso para volver al directorio anterior en el historial de navegación.
        /// </summary>
        /// <param name="sender">El objeto que originó el evento (el botón de retroceso).</param>
        /// <param name="e">Argumentos del evento.</param>
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
        /// Evento que se ejecuta cuando se hace clic en el botón de eliminar para borrar el archivo o directorio seleccionado.
        /// </summary>
        /// <param name="sender">El objeto que originó el evento (el botón de eliminar).</param>
        /// <param name="e">Argumentos del evento.</param>
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


        /// <summary>
        /// Evento que se ejecuta cuando se hace clic en el botón de filtro para aplicar un filtro de tipo de archivo.
        /// </summary>
        /// <param name="sender">El objeto que originó el evento (el botón de filtro).</param>
        /// <param name="e">Argumentos del evento.</param>
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


        /// <summary>
        /// Evento que se ejecuta cuando se hace clic en el botón de cambiar nombre para renombrar el archivo o directorio seleccionado.
        /// </summary>
        /// <param name="sender">El objeto que originó el evento (el botón de cambiar nombre).</param>
        /// <param name="e">Argumentos del evento.</param>
        private void changeNameButton_Click(object sender, EventArgs e)
        {

            
            string nuevoNombre = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nuevo nombre:", "Renombrar", selectedItemName);

            
            if (string.IsNullOrEmpty(nuevoNombre))
            {
                return; 
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


        /// <summary>
        /// Evento que se ejecuta cuando se hace clic en el botón de crear carpeta.
        /// Permite crear una nueva carpeta en el directorio actual.
        /// </summary>
        /// <param name="sender">El objeto que originó el evento (el botón de crear carpeta).</param>
        /// <param name="e">Argumentos del evento.</param>
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
