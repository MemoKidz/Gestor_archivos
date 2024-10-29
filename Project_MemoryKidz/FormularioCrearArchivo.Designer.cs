namespace Project_MemoryKidz
{
    partial class FormularioCrearArchivo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.pdfRadioButton = new System.Windows.Forms.RadioButton();
            this.docRadioButton = new System.Windows.Forms.RadioButton();
            this.jsonRadioButton = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelNewFileName = new System.Windows.Forms.Label();
            this.acceptNewFileButton = new System.Windows.Forms.Button();
            this.cancelNewFileButton = new System.Windows.Forms.Button();
            this.fileTypeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileTypeGroupBox
            // 
            this.fileTypeGroupBox.Controls.Add(this.pdfRadioButton);
            this.fileTypeGroupBox.Controls.Add(this.docRadioButton);
            this.fileTypeGroupBox.Controls.Add(this.jsonRadioButton);
            this.fileTypeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.fileTypeGroupBox.Name = "fileTypeGroupBox";
            this.fileTypeGroupBox.Size = new System.Drawing.Size(179, 106);
            this.fileTypeGroupBox.TabIndex = 1;
            this.fileTypeGroupBox.TabStop = false;
            this.fileTypeGroupBox.Text = "Seleccione el tipo de archivo";
            // 
            // pdfRadioButton
            // 
            this.pdfRadioButton.AutoSize = true;
            this.pdfRadioButton.Location = new System.Drawing.Point(6, 52);
            this.pdfRadioButton.Name = "pdfRadioButton";
            this.pdfRadioButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.pdfRadioButton.Size = new System.Drawing.Size(83, 17);
            this.pdfRadioButton.TabIndex = 9;
            this.pdfRadioButton.TabStop = true;
            this.pdfRadioButton.Text = ".pdf";
            this.pdfRadioButton.UseVisualStyleBackColor = true;
            // 
            // docRadioButton
            // 
            this.docRadioButton.AutoSize = true;
            this.docRadioButton.Location = new System.Drawing.Point(6, 75);
            this.docRadioButton.Name = "docRadioButton";
            this.docRadioButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.docRadioButton.Size = new System.Drawing.Size(86, 17);
            this.docRadioButton.TabIndex = 3;
            this.docRadioButton.TabStop = true;
            this.docRadioButton.Text = ".doc";
            this.docRadioButton.UseVisualStyleBackColor = true;
            // 
            // jsonRadioButton
            // 
            this.jsonRadioButton.AutoSize = true;
            this.jsonRadioButton.Location = new System.Drawing.Point(6, 29);
            this.jsonRadioButton.Name = "jsonRadioButton";
            this.jsonRadioButton.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.jsonRadioButton.Size = new System.Drawing.Size(87, 17);
            this.jsonRadioButton.TabIndex = 0;
            this.jsonRadioButton.TabStop = true;
            this.jsonRadioButton.Text = ".json";
            this.jsonRadioButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 20);
            this.textBox1.TabIndex = 2;
            // 
            // labelNewFileName
            // 
            this.labelNewFileName.AutoSize = true;
            this.labelNewFileName.Location = new System.Drawing.Point(13, 135);
            this.labelNewFileName.Name = "labelNewFileName";
            this.labelNewFileName.Size = new System.Drawing.Size(102, 13);
            this.labelNewFileName.TabIndex = 3;
            this.labelNewFileName.Text = "Nombre del archivo:";
            // 
            // acceptNewFileButton
            // 
            this.acceptNewFileButton.Location = new System.Drawing.Point(12, 180);
            this.acceptNewFileButton.Name = "acceptNewFileButton";
            this.acceptNewFileButton.Size = new System.Drawing.Size(75, 23);
            this.acceptNewFileButton.TabIndex = 4;
            this.acceptNewFileButton.Text = "Aceptar";
            this.acceptNewFileButton.UseVisualStyleBackColor = true;
            // 
            // cancelNewFileButton
            // 
            this.cancelNewFileButton.Location = new System.Drawing.Point(116, 180);
            this.cancelNewFileButton.Name = "cancelNewFileButton";
            this.cancelNewFileButton.Size = new System.Drawing.Size(75, 23);
            this.cancelNewFileButton.TabIndex = 5;
            this.cancelNewFileButton.Text = "Cancelar";
            this.cancelNewFileButton.UseVisualStyleBackColor = true;
            // 
            // FormularioCrearArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 229);
            this.Controls.Add(this.cancelNewFileButton);
            this.Controls.Add(this.acceptNewFileButton);
            this.Controls.Add(this.labelNewFileName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.fileTypeGroupBox);
            this.Name = "FormularioCrearArchivo";
            this.Text = "FormularioCrearArchivo";
            this.fileTypeGroupBox.ResumeLayout(false);
            this.fileTypeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox fileTypeGroupBox;
        private System.Windows.Forms.RadioButton pdfRadioButton;
        private System.Windows.Forms.RadioButton docRadioButton;
        private System.Windows.Forms.RadioButton jsonRadioButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelNewFileName;
        private System.Windows.Forms.Button acceptNewFileButton;
        private System.Windows.Forms.Button cancelNewFileButton;
    }
}