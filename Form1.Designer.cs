namespace practica12
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
            this.label2 = new System.Windows.Forms.Label();
            this.lbConection = new System.Windows.Forms.Label();
            this.lbTemp = new System.Windows.Forms.Label();
            this.tbLimTemp = new System.Windows.Forms.TextBox();
            this.btndesconectar = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(466, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Temperatura:";
            // 
            // lbConection
            // 
            this.lbConection.AutoSize = true;
            this.lbConection.Location = new System.Drawing.Point(170, 253);
            this.lbConection.Name = "lbConection";
            this.lbConection.Size = new System.Drawing.Size(85, 16);
            this.lbConection.TabIndex = 12;
            this.lbConection.Text = "Sin Conexion";
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Location = new System.Drawing.Point(467, 127);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(14, 16);
            this.lbTemp.TabIndex = 11;
            this.lbTemp.Text = "0";
            // 
            // tbLimTemp
            // 
            this.tbLimTemp.Location = new System.Drawing.Point(160, 96);
            this.tbLimTemp.Name = "tbLimTemp";
            this.tbLimTemp.Size = new System.Drawing.Size(120, 22);
            this.tbLimTemp.TabIndex = 10;
            // 
            // btndesconectar
            // 
            this.btndesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndesconectar.ForeColor = System.Drawing.Color.Red;
            this.btndesconectar.Location = new System.Drawing.Point(388, 302);
            this.btndesconectar.Name = "btndesconectar";
            this.btndesconectar.Size = new System.Drawing.Size(182, 92);
            this.btndesconectar.TabIndex = 9;
            this.btndesconectar.Text = "Desconectar";
            this.btndesconectar.UseVisualStyleBackColor = true;
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConectar.Location = new System.Drawing.Point(120, 302);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(186, 92);
            this.btnConectar.TabIndex = 8;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Limite de temperatura:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbConection);
            this.Controls.Add(this.lbTemp);
            this.Controls.Add(this.tbLimTemp);
            this.Controls.Add(this.btndesconectar);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbConection;
        private System.Windows.Forms.Label lbTemp;
        private System.Windows.Forms.TextBox tbLimTemp;
        private System.Windows.Forms.Button btndesconectar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label1;
    }
}

