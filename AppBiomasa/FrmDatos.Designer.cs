namespace AppBiomasa
{
    partial class FrmDatos
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
            this.panelDatos = new System.Windows.Forms.Panel();
            this.dataGridBio = new System.Windows.Forms.DataGridView();
            this.btnCierraDatos = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBio)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDatos
            // 
            this.panelDatos.Controls.Add(this.dataGridBio);
            this.panelDatos.Controls.Add(this.btnCierraDatos);
            this.panelDatos.Location = new System.Drawing.Point(12, 12);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(969, 459);
            this.panelDatos.TabIndex = 12;
            // 
            // dataGridBio
            // 
            this.dataGridBio.AllowUserToAddRows = false;
            this.dataGridBio.AllowUserToDeleteRows = false;
            this.dataGridBio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridBio.Location = new System.Drawing.Point(15, 15);
            this.dataGridBio.Name = "dataGridBio";
            this.dataGridBio.ReadOnly = true;
            this.dataGridBio.Size = new System.Drawing.Size(924, 384);
            this.dataGridBio.TabIndex = 10;
            // 
            // btnCierraDatos
            // 
            this.btnCierraDatos.Location = new System.Drawing.Point(809, 417);
            this.btnCierraDatos.Name = "btnCierraDatos";
            this.btnCierraDatos.Size = new System.Drawing.Size(130, 23);
            this.btnCierraDatos.TabIndex = 11;
            this.btnCierraDatos.Text = "Cerrar";
            this.btnCierraDatos.UseVisualStyleBackColor = true;
            this.btnCierraDatos.Click += new System.EventHandler(this.btnCierraDatos_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Fecha_Hora";
            this.Column1.HeaderText = "Fecha_Hora";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 140;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Gas_Disponible";
            this.Column2.HeaderText = "Gas Disponible";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Carga_Liquida";
            this.Column3.HeaderText = "Carga Liquida";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Carga_Solida";
            this.Column4.HeaderText = "Carga Solida";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // FrmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 491);
            this.Controls.Add(this.panelDatos);
            this.Name = "FrmDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de nuestro Biodigestor";
            this.panelDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.DataGridView dataGridBio;
        private System.Windows.Forms.Button btnCierraDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}