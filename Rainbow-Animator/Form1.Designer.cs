namespace Rainbow_Animator
{
    partial class RainbowAnimator
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.animate = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.TempDir = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 800);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(806, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Load Picture";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // animate
            // 
            this.animate.Enabled = false;
            this.animate.Location = new System.Drawing.Point(806, 48);
            this.animate.Name = "animate";
            this.animate.Size = new System.Drawing.Size(166, 30);
            this.animate.TabIndex = 2;
            this.animate.Text = "&Animate!";
            this.animate.UseVisualStyleBackColor = true;
            this.animate.Click += new System.EventHandler(this.animate_Click);
            // 
            // TempDir
            // 
            this.TempDir.Location = new System.Drawing.Point(806, 84);
            this.TempDir.Name = "TempDir";
            this.TempDir.Size = new System.Drawing.Size(166, 30);
            this.TempDir.TabIndex = 3;
            this.TempDir.Text = "Choose Temp Dir";
            this.TempDir.UseVisualStyleBackColor = true;
            this.TempDir.Click += new System.EventHandler(this.TempDir_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(806, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 318);
            this.label1.TabIndex = 4;
            this.label1.Text = "1. Load a Picture\r\n\r\n2. Choose a Temp Directory (optional)\r\n\r\n3. Click on Animate" +
    " and wait untill prompted to enter a name.";
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Black;
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBar1.ForeColor = System.Drawing.Color.Blue;
            this.progressBar1.Location = new System.Drawing.Point(806, 438);
            this.progressBar1.Maximum = 120;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(166, 27);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // RainbowAnimator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 749);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TempDir);
            this.Controls.Add(this.animate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RainbowAnimator";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.RainbowAnimator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button animate;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button TempDir;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }


}

