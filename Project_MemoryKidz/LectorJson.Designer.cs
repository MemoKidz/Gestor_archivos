namespace Project_MemoryKidz
{
    partial class LectorJson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LectorJson));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonPreviousGroup = new System.Windows.Forms.Button();
            this.buttonNextGroup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnAvatar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTimeFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTimeSecond = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTimeThird = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTries = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.safeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.safeButton);
            this.panel1.Controls.Add(this.ButtonPreviousGroup);
            this.panel1.Controls.Add(this.buttonNextGroup);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(39, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 347);
            this.panel1.TabIndex = 1;
            // 
            // ButtonPreviousGroup
            // 
            this.ButtonPreviousGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonPreviousGroup.Location = new System.Drawing.Point(285, 286);
            this.ButtonPreviousGroup.Name = "ButtonPreviousGroup";
            this.ButtonPreviousGroup.Size = new System.Drawing.Size(83, 33);
            this.ButtonPreviousGroup.TabIndex = 2;
            this.ButtonPreviousGroup.Text = "Anterior";
            this.ButtonPreviousGroup.UseVisualStyleBackColor = true;
            this.ButtonPreviousGroup.Click += new System.EventHandler(this.ButtonPreviousGroup_Click);
            // 
            // buttonNextGroup
            // 
            this.buttonNextGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNextGroup.Location = new System.Drawing.Point(377, 286);
            this.buttonNextGroup.Name = "buttonNextGroup";
            this.buttonNextGroup.Size = new System.Drawing.Size(90, 34);
            this.buttonNextGroup.TabIndex = 1;
            this.buttonNextGroup.Text = "Siguiente";
            this.buttonNextGroup.UseVisualStyleBackColor = true;
            this.buttonNextGroup.Click += new System.EventHandler(this.buttonNextGroup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leer JSON";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Snow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAvatar,
            this.ColumnTimeFirst,
            this.ColumnTimeSecond,
            this.ColumnTimeThird,
            this.ColumnTries});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.Location = new System.Drawing.Point(17, 42);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(730, 213);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnAvatar
            // 
            this.ColumnAvatar.HeaderText = "Avatar";
            this.ColumnAvatar.Name = "ColumnAvatar";
            this.ColumnAvatar.ReadOnly = true;
            this.ColumnAvatar.Width = 110;
            // 
            // ColumnTimeFirst
            // 
            this.ColumnTimeFirst.HeaderText = "Tiempo primer nivel";
            this.ColumnTimeFirst.Name = "ColumnTimeFirst";
            this.ColumnTimeFirst.Width = 160;
            // 
            // ColumnTimeSecond
            // 
            this.ColumnTimeSecond.HeaderText = "Tiempo segundo nivel";
            this.ColumnTimeSecond.Name = "ColumnTimeSecond";
            this.ColumnTimeSecond.Width = 160;
            // 
            // ColumnTimeThird
            // 
            this.ColumnTimeThird.HeaderText = "Tiempo tercer nivel";
            this.ColumnTimeThird.Name = "ColumnTimeThird";
            this.ColumnTimeThird.Width = 160;
            // 
            // ColumnTries
            // 
            this.ColumnTries.HeaderText = "Intentos";
            this.ColumnTries.Name = "ColumnTries";
            this.ColumnTries.ReadOnly = true;
            // 
            // safeButton
            // 
            this.safeButton.Location = new System.Drawing.Point(667, 261);
            this.safeButton.Name = "safeButton";
            this.safeButton.Size = new System.Drawing.Size(80, 28);
            this.safeButton.TabIndex = 3;
            this.safeButton.Text = "Guardar";
            this.safeButton.UseVisualStyleBackColor = true;
            this.safeButton.Click += new System.EventHandler(this.safeButton_Click);
            // 
            // LectorJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(850, 408);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LectorJson";
            this.Text = "Leer JSON";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ButtonPreviousGroup;
        private System.Windows.Forms.Button buttonNextGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAvatar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTimeFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTimeSecond;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTimeThird;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTries;
        private System.Windows.Forms.Button safeButton;
    }
}