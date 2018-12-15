namespace AppBiomasa
{
    partial class FrmResumen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResumen));
            this.btnFin = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnUrl = new System.Windows.Forms.Button();
            this.panelWeb = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panelWeb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFin
            // 
            this.btnFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFin.Image = ((System.Drawing.Image)(resources.GetObject("btnFin.Image")));
            this.btnFin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFin.Location = new System.Drawing.Point(865, 556);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(211, 54);
            this.btnFin.TabIndex = 1;
            this.btnFin.Text = "Finalizar";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(14, 46);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1050, 466);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(14, 13);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(952, 20);
            this.txtUrl.TabIndex = 4;
            // 
            // btnUrl
            // 
            this.btnUrl.Location = new System.Drawing.Point(972, 10);
            this.btnUrl.Name = "btnUrl";
            this.btnUrl.Size = new System.Drawing.Size(75, 23);
            this.btnUrl.TabIndex = 5;
            this.btnUrl.Text = "Ir";
            this.btnUrl.UseVisualStyleBackColor = true;
            this.btnUrl.Click += new System.EventHandler(this.btnUrl_Click);
            // 
            // panelWeb
            // 
            this.panelWeb.Controls.Add(this.txtUrl);
            this.panelWeb.Controls.Add(this.btnUrl);
            this.panelWeb.Controls.Add(this.webBrowser1);
            this.panelWeb.Location = new System.Drawing.Point(12, 12);
            this.panelWeb.Name = "panelWeb";
            this.panelWeb.Size = new System.Drawing.Size(1087, 529);
            this.panelWeb.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(144, 547);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 63);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contenido";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(134, 31);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(52, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "Video";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.Text = "Imagen";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(215, 31);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(48, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Web";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // FrmResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelWeb);
            this.Controls.Add(this.btnFin);
            this.Name = "FrmResumen";
            this.Text = "Resumen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelWeb.ResumeLayout(false);
            this.panelWeb.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnUrl;
        private System.Windows.Forms.Panel panelWeb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}