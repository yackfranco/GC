namespace Presentacion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button6 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarAplicativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarDiplomadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCursosGratuitosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAsesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.concluirProcesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.liquidarAsesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(27, 135);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 57);
            this.button6.TabIndex = 4;
            this.button6.Text = "ensayo reporte";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.procesosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(776, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizarBaseDeDatosToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.cerrarAplicativoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // actualizarBaseDeDatosToolStripMenuItem
            // 
            this.actualizarBaseDeDatosToolStripMenuItem.Name = "actualizarBaseDeDatosToolStripMenuItem";
            this.actualizarBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.actualizarBaseDeDatosToolStripMenuItem.Text = "Actualizar Base de Datos";
            this.actualizarBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.actualizarBaseDeDatosToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca De...";
            // 
            // cerrarAplicativoToolStripMenuItem
            // 
            this.cerrarAplicativoToolStripMenuItem.Name = "cerrarAplicativoToolStripMenuItem";
            this.cerrarAplicativoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.cerrarAplicativoToolStripMenuItem.Text = "Cerrar Aplicativo";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarDiplomadosToolStripMenuItem,
            this.registrarCursosGratuitosToolStripMenuItem,
            this.registrarAsesoresToolStripMenuItem,
            this.registrarPersonasToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // registrarDiplomadosToolStripMenuItem
            // 
            this.registrarDiplomadosToolStripMenuItem.Name = "registrarDiplomadosToolStripMenuItem";
            this.registrarDiplomadosToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.registrarDiplomadosToolStripMenuItem.Text = "Registrar Diplomados";
            this.registrarDiplomadosToolStripMenuItem.Click += new System.EventHandler(this.registrarDiplomadosToolStripMenuItem_Click);
            // 
            // registrarCursosGratuitosToolStripMenuItem
            // 
            this.registrarCursosGratuitosToolStripMenuItem.Name = "registrarCursosGratuitosToolStripMenuItem";
            this.registrarCursosGratuitosToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.registrarCursosGratuitosToolStripMenuItem.Text = "Registrar Cursos Gratuitos";
            this.registrarCursosGratuitosToolStripMenuItem.Click += new System.EventHandler(this.registrarCursosGratuitosToolStripMenuItem_Click);
            // 
            // registrarAsesoresToolStripMenuItem
            // 
            this.registrarAsesoresToolStripMenuItem.Name = "registrarAsesoresToolStripMenuItem";
            this.registrarAsesoresToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.registrarAsesoresToolStripMenuItem.Text = "Registrar Asesores";
            this.registrarAsesoresToolStripMenuItem.Click += new System.EventHandler(this.registrarAsesoresToolStripMenuItem_Click);
            // 
            // registrarPersonasToolStripMenuItem
            // 
            this.registrarPersonasToolStripMenuItem.Name = "registrarPersonasToolStripMenuItem";
            this.registrarPersonasToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.registrarPersonasToolStripMenuItem.Text = "Registrar Personas";
            this.registrarPersonasToolStripMenuItem.Click += new System.EventHandler(this.registrarPersonasToolStripMenuItem_Click);
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarPersonaToolStripMenuItem,
            this.concluirProcesoToolStripMenuItem,
            this.liquidarAsesoresToolStripMenuItem});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // registrarPersonaToolStripMenuItem
            // 
            this.registrarPersonaToolStripMenuItem.Name = "registrarPersonaToolStripMenuItem";
            this.registrarPersonaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.registrarPersonaToolStripMenuItem.Text = "Aceptar Matricula ";
            this.registrarPersonaToolStripMenuItem.Click += new System.EventHandler(this.registrarPersonaToolStripMenuItem_Click);
            // 
            // concluirProcesoToolStripMenuItem
            // 
            this.concluirProcesoToolStripMenuItem.Name = "concluirProcesoToolStripMenuItem";
            this.concluirProcesoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.concluirProcesoToolStripMenuItem.Text = "Concluir Proceso ";
            this.concluirProcesoToolStripMenuItem.Click += new System.EventHandler(this.concluirProcesoToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(105, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(545, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Datos Importados Correctamente";
            this.notifyIcon1.BalloonTipTitle = "EXITO";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // liquidarAsesoresToolStripMenuItem
            // 
            this.liquidarAsesoresToolStripMenuItem.Name = "liquidarAsesoresToolStripMenuItem";
            this.liquidarAsesoresToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.liquidarAsesoresToolStripMenuItem.Text = "Liquidar Asesores";
            this.liquidarAsesoresToolStripMenuItem.Click += new System.EventHandler(this.liquidarAsesoresToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(776, 483);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarDiplomadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCursosGratuitosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarAsesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPersonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPersonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarAplicativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem concluirProcesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem liquidarAsesoresToolStripMenuItem;
    }
}