namespace AppBiomasa
{
    partial class FrmJuego
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJuego));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblAgua = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblVegetal = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.Img3 = new System.Windows.Forms.PictureBox();
            this.Img2 = new System.Windows.Forms.PictureBox();
            this.Img1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureLlama = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnResumen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLlama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(341, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblAgua
            // 
            this.lblAgua.AutoSize = true;
            this.lblAgua.Location = new System.Drawing.Point(365, 92);
            this.lblAgua.Name = "lblAgua";
            this.lblAgua.Size = new System.Drawing.Size(33, 13);
            this.lblAgua.TabIndex = 2;
            this.lblAgua.Text = "100%";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(110, 127);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(106, 109);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // lblVegetal
            // 
            this.lblVegetal.AutoSize = true;
            this.lblVegetal.Location = new System.Drawing.Point(154, 92);
            this.lblVegetal.Name = "lblVegetal";
            this.lblVegetal.Size = new System.Drawing.Size(21, 13);
            this.lblVegetal.TabIndex = 5;
            this.lblVegetal.Text = "0%";
            this.lblVegetal.Click += new System.EventHandler(this.lblVegetal_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Image = ((System.Drawing.Image)(resources.GetObject("btnReiniciar.Image")));
            this.btnReiniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReiniciar.Location = new System.Drawing.Point(633, 54);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(154, 70);
            this.btnReiniciar.TabIndex = 6;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelContainer
            // 
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContainer.Controls.Add(this.Img3);
            this.panelContainer.Controls.Add(this.Img2);
            this.panelContainer.Controls.Add(this.Img1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelContainer.Location = new System.Drawing.Point(896, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(358, 610);
            this.panelContainer.TabIndex = 10;
            // 
            // Img3
            // 
            this.Img3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Img3.Location = new System.Drawing.Point(118, 346);
            this.Img3.Name = "Img3";
            this.Img3.Size = new System.Drawing.Size(130, 130);
            this.Img3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img3.TabIndex = 10;
            this.Img3.TabStop = false;
            this.Img3.Click += new System.EventHandler(this.Img3_Click);
            // 
            // Img2
            // 
            this.Img2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Img2.Location = new System.Drawing.Point(118, 204);
            this.Img2.Name = "Img2";
            this.Img2.Size = new System.Drawing.Size(130, 130);
            this.Img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img2.TabIndex = 9;
            this.Img2.TabStop = false;
            this.Img2.Click += new System.EventHandler(this.Img2_Click);
            // 
            // Img1
            // 
            this.Img1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Img1.Location = new System.Drawing.Point(118, 64);
            this.Img1.Name = "Img1";
            this.Img1.Size = new System.Drawing.Size(130, 130);
            this.Img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Img1.TabIndex = 8;
            this.Img1.TabStop = false;
            this.Img1.Click += new System.EventHandler(this.ImgCombustible_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.progressBar1.Location = new System.Drawing.Point(56, 509);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(412, 41);
            this.progressBar1.TabIndex = 14;
            this.progressBar1.Value = 100;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.lblAgua);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.lblVegetal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 610);
            this.panel1.TabIndex = 16;
            // 
            // pictureLlama
            // 
            this.pictureLlama.Image = ((System.Drawing.Image)(resources.GetObject("pictureLlama.Image")));
            this.pictureLlama.Location = new System.Drawing.Point(611, 129);
            this.pictureLlama.Name = "pictureLlama";
            this.pictureLlama.Size = new System.Drawing.Size(201, 165);
            this.pictureLlama.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLlama.TabIndex = 17;
            this.pictureLlama.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(611, 298);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(201, 180);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // btnResumen
            // 
            this.btnResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResumen.Image = ((System.Drawing.Image)(resources.GetObject("btnResumen.Image")));
            this.btnResumen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResumen.Location = new System.Drawing.Point(716, 24);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(159, 70);
            this.btnResumen.TabIndex = 19;
            this.btnResumen.Text = "Resumen";
            this.btnResumen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResumen.UseVisualStyleBackColor = true;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // FrmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1254, 610);
=======
            this.ClientSize = new System.Drawing.Size(1254, 535);
            this.Controls.Add(this.btnResumen);
>>>>>>> 13a9519f527a0d04348e5768d2813f27ad99139a
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureLlama);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.btnReiniciar);
            this.Name = "FrmJuego";
            this.Text = "BIOMASA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Img3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLlama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblAgua;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblVegetal;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox Img1;
        private System.Windows.Forms.PictureBox Img3;
        private System.Windows.Forms.PictureBox Img2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureLlama;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnResumen;
    }
}