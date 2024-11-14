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
            this.searchButton = new System.Windows.Forms.Button();
            this.labelRoute = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createFileButton = new System.Windows.Forms.Button();
            this.createFolderButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.changeNameButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            resources.ApplyResources(this.searchButton, "searchButton");
            this.searchButton.Name = "searchButton";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // labelRoute
            // 
            resources.ApplyResources(this.labelRoute, "labelRoute");
            this.labelRoute.Name = "labelRoute";
            // 
            // textBoxPath
            // 
            resources.ApplyResources(this.textBoxPath, "textBoxPath");
            this.textBoxPath.Name = "textBoxPath";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createFileButton);
            this.groupBox1.Controls.Add(this.createFolderButton);
            this.groupBox1.Controls.Add(this.filterButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.listViewFiles);
            this.groupBox1.Controls.Add(this.changeNameButton);
            this.groupBox1.Controls.Add(this.textBoxPath);
            this.groupBox1.Controls.Add(this.backButton);
            this.groupBox1.Controls.Add(this.labelRoute);
            this.groupBox1.Controls.Add(this.searchButton);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // createFileButton
            // 
            resources.ApplyResources(this.createFileButton, "createFileButton");
            this.createFileButton.Name = "createFileButton";
            this.createFileButton.UseVisualStyleBackColor = true;
            this.createFileButton.Click += new System.EventHandler(this.createFileButton_Click);
            // 
            // createFolderButton
            // 
            resources.ApplyResources(this.createFolderButton, "createFolderButton");
            this.createFolderButton.Name = "createFolderButton";
            this.createFolderButton.UseVisualStyleBackColor = true;
            this.createFolderButton.Click += new System.EventHandler(this.createFolderButton_Click);
            // 
            // filterButton
            // 
            resources.ApplyResources(this.filterButton, "filterButton");
            this.filterButton.Name = "filterButton";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // deleteButton
            // 
            resources.ApplyResources(this.deleteButton, "deleteButton");
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // listViewFiles
            // 
            resources.ApplyResources(this.listViewFiles, "listViewFiles");
            this.listViewFiles.HideSelection = false;
            this.listViewFiles.LargeImageList = this.imageList1;
            this.listViewFiles.MultiSelect = false;
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.SmallImageList = this.imageList1;
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
            // changeNameButton
            // 
            resources.ApplyResources(this.changeNameButton, "changeNameButton");
            this.changeNameButton.Name = "changeNameButton";
            this.changeNameButton.UseVisualStyleBackColor = true;
            this.changeNameButton.Click += new System.EventHandler(this.changeNameButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = global::Project_MemoryKidz.Properties.Resources.back_button;
            resources.ApplyResources(this.backButton, "backButton");
            this.backButton.Name = "backButton";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // GestorDeArchivos
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_MemoryKidz.Properties.Resources.background;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "GestorDeArchivos";
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
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Button createFolderButton;
        private System.Windows.Forms.Button createFileButton;
    }
}

