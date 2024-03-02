
namespace ProjetoABC
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.prgimage = new System.Windows.Forms.PictureBox();
            this.bar = new System.Windows.Forms.ProgressBar();
            this.lb = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.prgimage)).BeginInit();
            this.SuspendLayout();
            // 
            // prgimage
            // 
            this.prgimage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.prgimage.Image = ((System.Drawing.Image)(resources.GetObject("prgimage.Image")));
            this.prgimage.Location = new System.Drawing.Point(240, 112);
            this.prgimage.Name = "prgimage";
            this.prgimage.Size = new System.Drawing.Size(300, 225);
            this.prgimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.prgimage.TabIndex = 0;
            this.prgimage.TabStop = false;
            // 
            // bar
            // 
            this.bar.Location = new System.Drawing.Point(240, 399);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(300, 32);
            this.bar.TabIndex = 1;
            this.bar.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(376, 372);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(20, 24);
            this.lb.TabIndex = 2;
            this.lb.Text = "0";
            this.lb.Click += new System.EventHandler(this.label1_Click);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(390, 372);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(25, 24);
            this.lb2.TabIndex = 3;
            this.lb2.Text = "%";
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.prgimage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loja ABC-Splash";
            ((System.ComponentModel.ISupportInitialize)(this.prgimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox prgimage;
        private System.Windows.Forms.ProgressBar bar;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lb2;
    }
}