namespace Project_MemoryKidz
{
    partial class GestorDeArchivos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestorDeArchivos));
            this.backButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.labelRoute = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.deleteButton = new System.Windows.Forms.Button();
            this.changeNameButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = global::Project_MemoryKidz.Properties.Resources.back_button;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backButton.Location = new System.Drawing.Point(15, 28);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(40, 40);
            this.backButton.TabIndex = 0;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(840, 28);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 40);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Buscar";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // labelRoute
            // 
            this.labelRoute.AutoSize = true;
            this.labelRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoute.Location = new System.Drawing.Point(58, 40);
            this.labelRoute.Name = "labelRoute";
            this.labelRoute.Size = new System.Drawing.Size(42, 17);
            this.labelRoute.TabIndex = 2;
            this.labelRoute.Text = "Ruta:";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(101, 40);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(729, 20);
            this.textBoxPath.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.listViewFiles);
            this.groupBox1.Controls.Add(this.changeNameButton);
            this.groupBox1.Controls.Add(this.createButton);
            this.groupBox1.Controls.Add(this.textBoxPath);
            this.groupBox1.Controls.Add(this.backButton);
            this.groupBox1.Controls.Add(this.labelRoute);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 610);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar ficheros ";
            // 
            // listViewFiles
            // 
            this.listViewFiles.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listViewFiles.HideSelection = false;
            this.listViewFiles.LargeImageList = this.imageList1;
            this.listViewFiles.Location = new System.Drawing.Point(15, 125);
            this.listViewFiles.MultiSelect = false;
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.RightToLeftLayout = true;
            this.listViewFiles.Size = new System.Drawing.Size(924, 467);
            this.listViewFiles.SmallImageList = this.imageList1;
            this.listViewFiles.TabIndex = 4;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewFiles_ItemSelectionChanged);
            this.listViewFiles.DoubleClick += new System.EventHandler(this.listViewFiles_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "json-file.png");
            this.imageList1.Images.SetKeyName(2, "pdf.png");
            this.imageList1.Images.SetKeyName(3, "doc.png");
            this.imageList1.Images.SetKeyName(4, "exe.png");
            this.imageList1.Images.SetKeyName(5, "png.png");
            this.imageList1.Images.SetKeyName(6, "mp3.png");
            this.imageList1.Images.SetKeyName(7, "mp4-file.png");
            this.imageList1.Images.SetKeyName(8, "unknown.png");
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(381, 79);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(100, 40);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Borrar";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // changeNameButton
            // 
            this.changeNameButton.Location = new System.Drawing.Point(101, 79);
            this.changeNameButton.Name = "changeNameButton";
            this.changeNameButton.Size = new System.Drawing.Size(112, 40);
            this.changeNameButton.TabIndex = 11;
            this.changeNameButton.Text = "Cambiar Nombre";
            this.changeNameButton.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(247, 79);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(98, 39);
            this.createButton.TabIndex = 10;
            this.createButton.Text = "Crear";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // GestorDeArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 634);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestorDeArchivos";
            this.Text = "Explorador de archivos";
            this.Load += new System.EventHandler(this.GestorDeArchivos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label labelRoute;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button changeNameButton;
        private System.Windows.Forms.Button createButton;
    }
}

