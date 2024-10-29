using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_MemoryKidz
{
    public partial class FormularioFiltrar : Form
    {

        public String tipoArchivoSeleccionado { get; private set; }

        public FormularioFiltrar()
        {
            InitializeComponent();
        }


        private void applyButton_Click(object sender, EventArgs e)
        {
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

            this.DialogResult = DialogResult.OK;

            this.Close();

        }
    }
}
