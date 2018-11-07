namespace ObjectBuilderGUI
{
    partial class frmObjectBuilder
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
            this.tbGenFiles = new System.Windows.Forms.TextBox();
            this.BtnSelectGenFiles = new System.Windows.Forms.Button();
            this.genFilesDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.baseJsonDialog = new System.Windows.Forms.OpenFileDialog();
            this.objectSaveLocation = new System.Windows.Forms.SaveFileDialog();
            this.tbJson = new System.Windows.Forms.TextBox();
            this.tbFinalSave = new System.Windows.Forms.TextBox();
            this.btnFindJson = new System.Windows.Forms.Button();
            this.btnSaveLocation = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tbAuthors = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbGenFiles
            // 
            this.tbGenFiles.Enabled = false;
            this.tbGenFiles.Location = new System.Drawing.Point(12, 12);
            this.tbGenFiles.Name = "tbGenFiles";
            this.tbGenFiles.Size = new System.Drawing.Size(384, 20);
            this.tbGenFiles.TabIndex = 0;
            this.tbGenFiles.Text = "Directory with Generated Files";
            // 
            // BtnSelectGenFiles
            // 
            this.BtnSelectGenFiles.Location = new System.Drawing.Point(402, 12);
            this.BtnSelectGenFiles.Name = "BtnSelectGenFiles";
            this.BtnSelectGenFiles.Size = new System.Drawing.Size(27, 23);
            this.BtnSelectGenFiles.TabIndex = 1;
            this.BtnSelectGenFiles.Text = "...";
            this.BtnSelectGenFiles.UseVisualStyleBackColor = true;
            this.BtnSelectGenFiles.Click += new System.EventHandler(this.BtnSelectGenFiles_Click);
            // 
            // tbJson
            // 
            this.tbJson.Enabled = false;
            this.tbJson.Location = new System.Drawing.Point(12, 38);
            this.tbJson.Name = "tbJson";
            this.tbJson.Size = new System.Drawing.Size(384, 20);
            this.tbJson.TabIndex = 2;
            this.tbJson.Text = "Base Json";
            // 
            // tbFinalSave
            // 
            this.tbFinalSave.Enabled = false;
            this.tbFinalSave.Location = new System.Drawing.Point(12, 64);
            this.tbFinalSave.Name = "tbFinalSave";
            this.tbFinalSave.Size = new System.Drawing.Size(384, 20);
            this.tbFinalSave.TabIndex = 3;
            this.tbFinalSave.Text = "Final Object";
            // 
            // btnFindJson
            // 
            this.btnFindJson.Location = new System.Drawing.Point(402, 36);
            this.btnFindJson.Name = "btnFindJson";
            this.btnFindJson.Size = new System.Drawing.Size(27, 23);
            this.btnFindJson.TabIndex = 4;
            this.btnFindJson.Text = "...";
            this.btnFindJson.UseVisualStyleBackColor = true;
            this.btnFindJson.Click += new System.EventHandler(this.btnFindJson_Click);
            // 
            // btnSaveLocation
            // 
            this.btnSaveLocation.Location = new System.Drawing.Point(402, 62);
            this.btnSaveLocation.Name = "btnSaveLocation";
            this.btnSaveLocation.Size = new System.Drawing.Size(27, 23);
            this.btnSaveLocation.TabIndex = 5;
            this.btnSaveLocation.Text = "...";
            this.btnSaveLocation.UseVisualStyleBackColor = true;
            this.btnSaveLocation.Click += new System.EventHandler(this.btnSaveLocation_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(183, 116);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tbAuthors
            // 
            this.tbAuthors.Location = new System.Drawing.Point(12, 90);
            this.tbAuthors.Name = "tbAuthors";
            this.tbAuthors.Size = new System.Drawing.Size(417, 20);
            this.tbAuthors.TabIndex = 7;
            this.tbAuthors.Text = "Author(s)";
            // 
            // frmObjectBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 145);
            this.Controls.Add(this.tbAuthors);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnSaveLocation);
            this.Controls.Add(this.btnFindJson);
            this.Controls.Add(this.tbFinalSave);
            this.Controls.Add(this.tbJson);
            this.Controls.Add(this.BtnSelectGenFiles);
            this.Controls.Add(this.tbGenFiles);
            this.Name = "frmObjectBuilder";
            this.Text = "Object Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGenFiles;
        private System.Windows.Forms.Button BtnSelectGenFiles;
        private System.Windows.Forms.FolderBrowserDialog genFilesDialog;
        private System.Windows.Forms.OpenFileDialog baseJsonDialog;
        private System.Windows.Forms.SaveFileDialog objectSaveLocation;
        private System.Windows.Forms.TextBox tbJson;
        private System.Windows.Forms.TextBox tbFinalSave;
        private System.Windows.Forms.Button btnFindJson;
        private System.Windows.Forms.Button btnSaveLocation;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox tbAuthors;
    }
}

