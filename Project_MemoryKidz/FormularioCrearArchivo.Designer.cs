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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioCrearArchivo));
            this.createFileGroupBox = new System.Windows.Forms.GroupBox();
            this.createFileButton = new System.Windows.Forms.Button();
            this.createFileDataGridView = new System.Windows.Forms.DataGridView();
            this.avatarColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level1TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level1AttemptsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level2TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level2AttemptsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level3TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level3AttemptsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createFileGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.createFileDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // createFileGroupBox
            // 
            this.createFileGroupBox.BackColor = System.Drawing.Color.Snow;
            this.createFileGroupBox.Controls.Add(this.createFileButton);
            this.createFileGroupBox.Controls.Add(this.createFileDataGridView);
            this.createFileGroupBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createFileGroupBox.Location = new System.Drawing.Point(13, 12);
            this.createFileGroupBox.Name = "createFileGroupBox";
            this.createFileGroupBox.Size = new System.Drawing.Size(1044, 254);
            this.createFileGroupBox.TabIndex = 1;
            this.createFileGroupBox.TabStop = false;
            this.createFileGroupBox.Text = "Crear nuevo fichero";
            // 
            // createFileButton
            // 
            this.createFileButton.Location = new System.Drawing.Point(6, 207);
            this.createFileButton.Name = "createFileButton";
            this.createFileButton.Size = new System.Drawing.Size(86, 31);
            this.createFileButton.TabIndex = 1;
            this.createFileButton.Text = "Crear archivo";
            this.createFileButton.UseVisualStyleBackColor = true;
            this.createFileButton.Click += new System.EventHandler(this.createFileButton_Click);
            // 
            // createFileDataGridView
            // 
            this.createFileDataGridView.BackgroundColor = System.Drawing.Color.Snow;
            this.createFileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.createFileDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.avatarColumn,
            this.level1TimeColumn,
            this.level1AttemptsColumn,
            this.level2TimeColumn,
            this.level2AttemptsColumn,
            this.level3TimeColumn,
            this.level3AttemptsColumn});
            this.createFileDataGridView.Location = new System.Drawing.Point(6, 30);
            this.createFileDataGridView.Name = "createFileDataGridView";
            this.createFileDataGridView.Size = new System.Drawing.Size(1006, 171);
            this.createFileDataGridView.TabIndex = 0;
            // 
            // avatarColumn
            // 
            this.avatarColumn.HeaderText = "Avatar";
            this.avatarColumn.Name = "avatarColumn";
            this.avatarColumn.Width = 120;
            // 
            // level1TimeColumn
            // 
            this.level1TimeColumn.HeaderText = "Tiempo Primer Nivel";
            this.level1TimeColumn.Name = "level1TimeColumn";
            this.level1TimeColumn.Width = 180;
            // 
            // level1AttemptsColumn
            // 
            this.level1AttemptsColumn.HeaderText = "Intentos Primer Nivel";
            this.level1AttemptsColumn.Name = "level1AttemptsColumn";
            // 
            // level2TimeColumn
            // 
            this.level2TimeColumn.HeaderText = "Tiempo Segundo Nivel";
            this.level2TimeColumn.Name = "level2TimeColumn";
            this.level2TimeColumn.Width = 180;
            // 
            // level2AttemptsColumn
            // 
            this.level2AttemptsColumn.HeaderText = "Intentos Segundo Nivel";
            this.level2AttemptsColumn.Name = "level2AttemptsColumn";
            // 
            // level3TimeColumn
            // 
            this.level3TimeColumn.HeaderText = "Tiempo Tercer Nivel";
            this.level3TimeColumn.Name = "level3TimeColumn";
            this.level3TimeColumn.Width = 180;
            // 
            // level3AttemptsColumn
            // 
            this.level3AttemptsColumn.HeaderText = "Intentos Tercer Nivel";
            this.level3AttemptsColumn.Name = "level3AttemptsColumn";
            // 
            // FormularioCrearArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1087, 278);
            this.Controls.Add(this.createFileGroupBox);
            this.Name = "FormularioCrearArchivo";
            this.Text = "FormularioCrearArchivo";
            this.Load += new System.EventHandler(this.FormularioCrearArchivo_Load);
            this.createFileGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.createFileDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox createFileGroupBox;
        private System.Windows.Forms.DataGridView createFileDataGridView;
        private System.Windows.Forms.Button createFileButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn avatarColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn level1TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn level1AttemptsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn level2TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn level2AttemptsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn level3TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn level3AttemptsColumn;
    }
}