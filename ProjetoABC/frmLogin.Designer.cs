
namespace ProjetoABC
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.image = new System.Windows.Forms.PictureBox();
            this.lb = new System.Windows.Forms.Label();
            this.box = new System.Windows.Forms.TextBox();
            this.box2 = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.Image = ((System.Drawing.Image)(resources.GetObject("image.Image")));
            this.image.Location = new System.Drawing.Point(261, 38);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(244, 221);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(225, 262);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(64, 20);
            this.lb.TabIndex = 1;
            this.lb.Text = "Usuário";
            this.lb.Click += new System.EventHandler(this.label1_Click);
            // 
            // box
            // 
            this.box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box.Location = new System.Drawing.Point(229, 285);
            this.box.MaxLength = 50;
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(316, 26);
            this.box.TabIndex = 2;
            // 
            // box2
            // 
            this.box2.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.box2.Location = new System.Drawing.Point(229, 349);
            this.box2.MaxLength = 20;
            this.box2.Name = "box2";
            this.box2.PasswordChar = 'l';
            this.box2.Size = new System.Drawing.Size(316, 25);
            this.box2.TabIndex = 4;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(225, 326);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(56, 20);
            this.lb2.TabIndex = 3;
            this.lb2.Text = "Senha";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(228, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(317, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(229, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(316, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Entrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.box);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LojaABC - Login";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox box;
        private System.Windows.Forms.TextBox box2;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}