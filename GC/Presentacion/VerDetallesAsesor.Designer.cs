namespace Presentacion
{
    partial class VerDetallesAsesor
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
            this.labelValorDiplo = new System.Windows.Forms.Label();
            this.labelComisionAsesor = new System.Windows.Forms.Label();
            this.labelNombreAsesor = new System.Windows.Forms.Label();
            this.labelCodigoAsesor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(826, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelValorDiplo
            // 
            this.labelValorDiplo.AutoSize = true;
            this.labelValorDiplo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorDiplo.Location = new System.Drawing.Point(372, 294);
            this.labelValorDiplo.Name = "labelValorDiplo";
            this.labelValorDiplo.Size = new System.Drawing.Size(235, 23);
            this.labelValorDiplo.TabIndex = 1;
            this.labelValorDiplo.Text = "Total Valor Diplomados: ";
            // 
            // labelComisionAsesor
            // 
            this.labelComisionAsesor.AutoSize = true;
            this.labelComisionAsesor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComisionAsesor.Location = new System.Drawing.Point(372, 334);
            this.labelComisionAsesor.Name = "labelComisionAsesor";
            this.labelComisionAsesor.Size = new System.Drawing.Size(238, 23);
            this.labelComisionAsesor.TabIndex = 2;
            this.labelComisionAsesor.Text = "Total Comision a Asesor: ";
            // 
            // labelNombreAsesor
            // 
            this.labelNombreAsesor.AutoSize = true;
            this.labelNombreAsesor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreAsesor.Location = new System.Drawing.Point(334, 9);
            this.labelNombreAsesor.Name = "labelNombreAsesor";
            this.labelNombreAsesor.Size = new System.Drawing.Size(229, 22);
            this.labelNombreAsesor.TabIndex = 3;
            this.labelNombreAsesor.Text = "Total Valor Diplomados: ";
            // 
            // labelCodigoAsesor
            // 
            this.labelCodigoAsesor.AutoSize = true;
            this.labelCodigoAsesor.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoAsesor.Location = new System.Drawing.Point(351, 45);
            this.labelCodigoAsesor.Name = "labelCodigoAsesor";
            this.labelCodigoAsesor.Size = new System.Drawing.Size(152, 22);
            this.labelCodigoAsesor.TabIndex = 4;
            this.labelCodigoAsesor.Text = "Codigo Asesor: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Valor Diplomados: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(137, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total Comision a Asesor: ";
            // 
            // VerDetallesAsesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCodigoAsesor);
            this.Controls.Add(this.labelNombreAsesor);
            this.Controls.Add(this.labelComisionAsesor);
            this.Controls.Add(this.labelValorDiplo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VerDetallesAsesor";
            this.Text = "VerDetallesAsesor";
            this.Load += new System.EventHandler(this.VerDetallesAsesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelValorDiplo;
        private System.Windows.Forms.Label labelComisionAsesor;
        private System.Windows.Forms.Label labelNombreAsesor;
        private System.Windows.Forms.Label labelCodigoAsesor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}