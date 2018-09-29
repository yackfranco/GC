namespace Presentacion
{
    partial class Parametros
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRangoPago = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxValorDiplomado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxComisionMasDeUnaVenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxComisionPrimeraVez = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rango de Pago";
            this.toolTip1.SetToolTip(this.label1, "Rango que se utiliza para poder pagarle a un Asesor");
            // 
            // textBoxRangoPago
            // 
            this.textBoxRangoPago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRangoPago.Location = new System.Drawing.Point(290, 27);
            this.textBoxRangoPago.Name = "textBoxRangoPago";
            this.textBoxRangoPago.Size = new System.Drawing.Size(277, 27);
            this.textBoxRangoPago.TabIndex = 1;
            // 
            // textBoxValorDiplomado
            // 
            this.textBoxValorDiplomado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorDiplomado.Location = new System.Drawing.Point(290, 77);
            this.textBoxValorDiplomado.Name = "textBoxValorDiplomado";
            this.textBoxValorDiplomado.Size = new System.Drawing.Size(277, 27);
            this.textBoxValorDiplomado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor del Diplomado";
            this.toolTip1.SetToolTip(this.label2, "Valor de cada uno de los Diplomados en General");
            // 
            // textBoxComisionMasDeUnaVenta
            // 
            this.textBoxComisionMasDeUnaVenta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComisionMasDeUnaVenta.Location = new System.Drawing.Point(290, 172);
            this.textBoxComisionMasDeUnaVenta.Name = "textBoxComisionMasDeUnaVenta";
            this.textBoxComisionMasDeUnaVenta.Size = new System.Drawing.Size(277, 27);
            this.textBoxComisionMasDeUnaVenta.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Comision por mas de una venta";
            this.toolTip1.SetToolTip(this.label3, "Comision por la venta de un diplomado que ya conocia la empresa y estaba registra" +
        "da en el software");
            // 
            // textBoxComisionPrimeraVez
            // 
            this.textBoxComisionPrimeraVez.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComisionPrimeraVez.Location = new System.Drawing.Point(290, 122);
            this.textBoxComisionPrimeraVez.Name = "textBoxComisionPrimeraVez";
            this.textBoxComisionPrimeraVez.Size = new System.Drawing.Size(277, 27);
            this.textBoxComisionPrimeraVez.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Comision por Primera Venta";
            this.toolTip1.SetToolTip(this.label4, "Comision por la venta de una persona que no conocia la empresa");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Guardar Cambios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Parametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(719, 300);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxComisionMasDeUnaVenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxComisionPrimeraVez);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxValorDiplomado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRangoPago);
            this.Controls.Add(this.label1);
            this.Name = "Parametros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametros";
            this.Load += new System.EventHandler(this.Parametros_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox textBoxRangoPago;
        private System.Windows.Forms.TextBox textBoxValorDiplomado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxComisionMasDeUnaVenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxComisionPrimeraVez;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}