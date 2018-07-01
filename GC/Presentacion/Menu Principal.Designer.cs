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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.RegistrarPersonasButton = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Actualizar Base de Datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 57);
            this.button2.TabIndex = 0;
            this.button2.Text = "registrar Diplomados";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(269, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 57);
            this.button3.TabIndex = 1;
            this.button3.Text = "registrar Cursos Gratuitos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(373, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 57);
            this.button4.TabIndex = 2;
            this.button4.Text = "registrar Asesores";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // RegistrarPersonasButton
            // 
            this.RegistrarPersonasButton.Location = new System.Drawing.Point(488, 47);
            this.RegistrarPersonasButton.Name = "RegistrarPersonasButton";
            this.RegistrarPersonasButton.Size = new System.Drawing.Size(72, 57);
            this.RegistrarPersonasButton.TabIndex = 2;
            this.RegistrarPersonasButton.Text = "registrar Personas";
            this.RegistrarPersonasButton.UseVisualStyleBackColor = true;
            this.RegistrarPersonasButton.Click += new System.EventHandler(this.RegistrarPersonasButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(590, 47);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 57);
            this.button5.TabIndex = 3;
            this.button5.Text = "Aceptar Estudiante";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(27, 135);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 57);
            this.button6.TabIndex = 4;
            this.button6.Text = "Aceptar Estudiante";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(590, 135);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 57);
            this.button7.TabIndex = 5;
            this.button7.Text = "Terminar Proceso Estudiantes";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 383);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.RegistrarPersonasButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button RegistrarPersonasButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}