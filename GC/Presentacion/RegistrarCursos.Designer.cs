namespace Presentacion
{
    partial class RegistrarCursos
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
            this.panelDatos = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreCursoTextBox = new System.Windows.Forms.TextBox();
            this.NumeroCursoTextBox = new System.Windows.Forms.TextBox();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.EditarButton = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(146, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(278, 269);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // panelDatos
            // 
            this.panelDatos.Controls.Add(this.label2);
            this.panelDatos.Controls.Add(this.label1);
            this.panelDatos.Controls.Add(this.NombreCursoTextBox);
            this.panelDatos.Controls.Add(this.NumeroCursoTextBox);
            this.panelDatos.Enabled = false;
            this.panelDatos.Location = new System.Drawing.Point(30, 12);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(536, 132);
            this.panelDatos.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre del Curso Gratuito";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numero del Curso Gratuito";
            // 
            // NombreCursoTextBox
            // 
            this.NombreCursoTextBox.Location = new System.Drawing.Point(175, 81);
            this.NombreCursoTextBox.Name = "NombreCursoTextBox";
            this.NombreCursoTextBox.Size = new System.Drawing.Size(331, 20);
            this.NombreCursoTextBox.TabIndex = 6;
            // 
            // NumeroCursoTextBox
            // 
            this.NumeroCursoTextBox.Location = new System.Drawing.Point(175, 25);
            this.NumeroCursoTextBox.Name = "NumeroCursoTextBox";
            this.NumeroCursoTextBox.Size = new System.Drawing.Size(100, 20);
            this.NumeroCursoTextBox.TabIndex = 6;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(405, 160);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(62, 63);
            this.EliminarButton.TabIndex = 11;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // EditarButton
            // 
            this.EditarButton.Location = new System.Drawing.Point(318, 160);
            this.EditarButton.Name = "EditarButton";
            this.EditarButton.Size = new System.Drawing.Size(62, 63);
            this.EditarButton.TabIndex = 9;
            this.EditarButton.Text = "Editar";
            this.EditarButton.UseVisualStyleBackColor = true;
            this.EditarButton.Click += new System.EventHandler(this.EditarButton_Click);
            // 
            // CancelarButton
            // 
            this.CancelarButton.Location = new System.Drawing.Point(237, 160);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(62, 63);
            this.CancelarButton.TabIndex = 10;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(159, 160);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(62, 63);
            this.GuardarButton.TabIndex = 7;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(77, 160);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(62, 63);
            this.NuevoButton.TabIndex = 8;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // RegistrarCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 541);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.EditarButton);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Name = "RegistrarCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarCursos";
            this.Load += new System.EventHandler(this.RegistrarCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreCursoTextBox;
        private System.Windows.Forms.TextBox NumeroCursoTextBox;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button EditarButton;
        private System.Windows.Forms.Button CancelarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
    }
}