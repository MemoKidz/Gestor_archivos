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
            this.createFileGroupBox = new System.Windows.Forms.GroupBox();
            this.createFileDataGridView = new System.Windows.Forms.DataGridView();
            this.avatarColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level1TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level2TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level3TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.failsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createFileButton = new System.Windows.Forms.Button();
            this.createFileGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.createFileDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // createFileGroupBox
            // 
            this.createFileGroupBox.Controls.Add(this.createFileButton);
            this.createFileGroupBox.Controls.Add(this.createFileDataGridView);
            this.createFileGroupBox.Location = new System.Drawing.Point(13, 12);
            this.createFileGroupBox.Name = "createFileGroupBox";
            this.createFileGroupBox.Size = new System.Drawing.Size(825, 425);
            this.createFileGroupBox.TabIndex = 1;
            this.createFileGroupBox.TabStop = false;
            this.createFileGroupBox.Text = "Crear nuevo fichero";
            // 
            // createFileDataGridView
            // 
            this.createFileDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.createFileDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.avatarColumn,
            this.level1TimeColumn,
            this.level2TimeColumn,
            this.Column1,
            this.level3TimeColumn,
            this.failsColumn,
            this.dateColumn});
            this.createFileDataGridView.Location = new System.Drawing.Point(6, 30);
            this.createFileDataGridView.Name = "createFileDataGridView";
            this.createFileDataGridView.Size = new System.Drawing.Size(744, 150);
            this.createFileDataGridView.TabIndex = 0;
            this.createFileDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // avatarColumn
            // 
            this.avatarColumn.HeaderText = "Avatar";
            this.avatarColumn.Name = "avatarColumn";
            // 
            // level1TimeColumn
            // 
            this.level1TimeColumn.HeaderText = "Tiempo Primer Nivel";
            this.level1TimeColumn.Name = "level1TimeColumn";
            // 
            // level2TimeColumn
            // 
            this.level2TimeColumn.HeaderText = "Tiempo Segundo Nivel";
            this.level2TimeColumn.Name = "level2TimeColumn";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // level3TimeColumn
            // 
            this.level3TimeColumn.HeaderText = "Tiempo Tercer Nivel";
            this.level3TimeColumn.Name = "level3TimeColumn";
            // 
            // failsColumn
            // 
            this.failsColumn.HeaderText = "Fallos";
            this.failsColumn.Name = "failsColumn";
            // 
            // dateColumn
            // 
            this.dateColumn.HeaderText = "Fecha y Hora";
            this.dateColumn.Name = "dateColumn";
            // 
            // createFileButton
            // 
            this.createFileButton.Location = new System.Drawing.Point(6, 228);
            this.createFileButton.Name = "createFileButton";
            this.createFileButton.Size = new System.Drawing.Size(75, 23);
            this.createFileButton.TabIndex = 1;
            this.createFileButton.Text = "Crear archivo";
            this.createFileButton.UseVisualStyleBackColor = true;
            // 
            // FormularioCrearArchivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 449);
            this.Controls.Add(this.createFileGroupBox);
            this.Name = "FormularioCrearArchivo";
            this.Text = "FormularioCrearArchivo";
            this.createFileGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.createFileDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox createFileGroupBox;
        private System.Windows.Forms.DataGridView createFileDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn avatarColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn level1TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn level2TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn level3TimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn failsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.Button createFileButton;
    }
}