using System;
using System.Windows.Forms;

namespace Project_MemoryKidz
{

    /// <summary>
    /// Representa un formulario para filtrar y seleccionar el tipo de archivo.
    /// Permite al usuario elegir entre varios tipos de archivos, como .json, .pdf, .jpg, etc.
    /// </summary>
    public partial class FormularioFiltrar : Form
    {
        /// <summary>
        /// Obtiene el tipo de archivo seleccionado por el usuario.
        /// </summary>
        /// <value>
        /// Un String que representa la extensión del archivo seleccionada (ej. ".json", ".pdf", ".mp3").
        /// </value>
        public String tipoArchivoSeleccionado { get; private set; }


        /// <summary>
        /// Inicializa una nueva instancia del formulario de filtrado.
        /// </summary>
        public FormularioFiltrar()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Evento para el botón de aplicar.
        /// Asigna el tipo de archivo seleccionado a la propiedad <see cref="tipoArchivoSeleccionado"/>
        /// y cierra el formulario.
        /// </summary>
        /// <param name="sender">El objeto que originó el evento (el botón de filtrar).</param>
        /// <param name="e">Argumentos del evento.</param>
        private void applyButton_Click(object sender, EventArgs e)
        {
            // Se evalúa cuál es el tipo de archivo seleccionado
            if (jsonRadioButton.Checked)
            {
                tipoArchivoSeleccionado = ".json";
            }
            else if (pdfRadioButton.Checked)
            {
                tipoArchivoSeleccionado = ".pdf";
            }
            else if (docRadioButton.Checked)
            {
                tipoArchivoSeleccionado = ".doc";
            }
            else if (exeRadioButton.Checked)
            {
                tipoArchivoSeleccionado = ".exe";
            }
            else if (jpgRadioButton.Checked)
            {
                tipoArchivoSeleccionado = ".jpg";
            }
            else if (jpegRadioButton.Checked)
            {
                tipoArchivoSeleccionado = ".jpeg";
            }
            else if (pngRadioButton.Checked)
            {
                tipoArchivoSeleccionado = ".png";
            }
            else if (mp3RadioButton.Checked)
            {
                tipoArchivoSeleccionado = ".mp3";
            }
            else if (mp4RadioButton.Checked)
            {
                tipoArchivoSeleccionado = ".mp4";
            }

            // Establecer el resultado del cuadro de diálogo como OK
            this.DialogResult = DialogResult.OK;

            // Cerrar el formulario
            this.Close();

        }

        private void FormularioFiltrar_Load(object sender, EventArgs e)
        {

        }
    }
}
