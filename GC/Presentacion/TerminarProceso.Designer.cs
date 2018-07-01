namespace Presentacion
{
    partial class TerminarProceso
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.BuscarTextBox = new System.Windows.Forms.TextBox();
            this.DesertarButton = new System.Windows.Forms.Button();
            this.CertificarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 76);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(581, 398);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Persona";
            // 
            // BuscarTextBox
            // 
            this.BuscarTextBox.Location = new System.Drawing.Point(183, 23);
            this.BuscarTextBox.Name = "BuscarTextBox";
            this.BuscarTextBox.Size = new System.Drawing.Size(303, 20);
            this.BuscarTextBox.TabIndex = 2;
            this.BuscarTextBox.TextChanged += new System.EventHandler(this.BuscarTextBox_TextChanged);
            // 
            // DesertarButton
            // 
            this.DesertarButton.Location = new System.Drawing.Point(661, 160);
            this.DesertarButton.Name = "DesertarButton";
            this.DesertarButton.Size = new System.Drawing.Size(80, 51);
            this.DesertarButton.TabIndex = 3;
            this.DesertarButton.Text = "Desertar Estudiante";
            this.DesertarButton.UseVisualStyleBackColor = true;
            // 
            // CertificarButton
            // 
            this.CertificarButton.Location = new System.Drawing.Point(661, 87);
            this.CertificarButton.Name = "CertificarButton";
            this.CertificarButton.Size = new System.Drawing.Size(80, 51);
            this.CertificarButton.TabIndex = 4;
            this.CertificarButton.Text = "Certificar Estudiante";
            this.CertificarButton.UseVisualStyleBackColor = true;
            this.CertificarButton.Click += new System.EventHandler(this.CertificarButton_Click);
            // 
            // TerminarProceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 510);
            this.Controls.Add(this.CertificarButton);
            this.Controls.Add(this.DesertarButton);
            this.Controls.Add(this.BuscarTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "TerminarProceso";
            this.Text = "TerminarProceso";
            this.Load += new System.EventHandler(this.TerminarProceso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BuscarTextBox;
        private System.Windows.Forms.Button DesertarButton;
        private System.Windows.Forms.Button CertificarButton;
    }
}