namespace CalcularRadio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtradio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblradio = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnir
            // 
            this.btnir.Location = new System.Drawing.Point(493, 214);
            this.btnir.Name = "btnir";
            this.btnir.Size = new System.Drawing.Size(75, 23);
            this.btnir.TabIndex = 0;
            this.btnir.Text = "Ir";
            this.btnir.UseVisualStyleBackColor = true;
            this.btnir.Click += new System.EventHandler(this.btnir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite el radio:";
            // 
            // txtradio
            // 
            this.txtradio.Location = new System.Drawing.Point(376, 219);
            this.txtradio.Name = "txtradio";
            this.txtradio.Size = new System.Drawing.Size(100, 20);
            this.txtradio.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Area:";
            // 
            // lblradio
            // 
            this.lblradio.AutoSize = true;
            this.lblradio.Location = new System.Drawing.Point(376, 271);
            this.lblradio.Name = "lblradio";
            this.lblradio.Size = new System.Drawing.Size(35, 13);
            this.lblradio.TabIndex = 4;
            this.lblradio.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblradio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtradio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtradio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblradio;
    }
}

