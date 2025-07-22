namespace SERIES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label6 = new System.Windows.Forms.Label();
            this.btbanualidad = new System.Windows.Forms.Button();
            this.btbanualidadA = new System.Windows.Forms.Button();
            this.btbfinalizar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btbanualidadD = new System.Windows.Forms.Button();
            this.anualidadP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(136, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "ANUALIDADES";
            // 
            // btbanualidad
            // 
            this.btbanualidad.Location = new System.Drawing.Point(55, 91);
            this.btbanualidad.Name = "btbanualidad";
            this.btbanualidad.Size = new System.Drawing.Size(117, 33);
            this.btbanualidad.TabIndex = 16;
            this.btbanualidad.Text = "Anualidad";
            this.btbanualidad.UseVisualStyleBackColor = true;
            this.btbanualidad.Click += new System.EventHandler(this.btbanualidad_Click);
            // 
            // btbanualidadA
            // 
            this.btbanualidadA.Location = new System.Drawing.Point(55, 130);
            this.btbanualidadA.Name = "btbanualidadA";
            this.btbanualidadA.Size = new System.Drawing.Size(117, 33);
            this.btbanualidadA.TabIndex = 17;
            this.btbanualidadA.Text = "Anualidad Anticipada";
            this.btbanualidadA.UseVisualStyleBackColor = true;
            this.btbanualidadA.Click += new System.EventHandler(this.btbanualidadA_Click);
            // 
            // btbfinalizar
            // 
            this.btbfinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btbfinalizar.Location = new System.Drawing.Point(73, 263);
            this.btbfinalizar.Name = "btbfinalizar";
            this.btbfinalizar.Size = new System.Drawing.Size(83, 32);
            this.btbfinalizar.TabIndex = 20;
            this.btbfinalizar.Text = "FINALIZAR";
            this.btbfinalizar.UseVisualStyleBackColor = false;
            this.btbfinalizar.Click += new System.EventHandler(this.btbfinalizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(203, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 189);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btbanualidadD
            // 
            this.btbanualidadD.Location = new System.Drawing.Point(55, 169);
            this.btbanualidadD.Name = "btbanualidadD";
            this.btbanualidadD.Size = new System.Drawing.Size(117, 35);
            this.btbanualidadD.TabIndex = 22;
            this.btbanualidadD.Text = "Anualidad diferida";
            this.btbanualidadD.UseVisualStyleBackColor = true;
            this.btbanualidadD.Click += new System.EventHandler(this.btbanualidadD_Click);
            // 
            // anualidadP
            // 
            this.anualidadP.Location = new System.Drawing.Point(55, 210);
            this.anualidadP.Name = "anualidadP";
            this.anualidadP.Size = new System.Drawing.Size(117, 35);
            this.anualidadP.TabIndex = 23;
            this.anualidadP.Text = "Anualidad perpetua";
            this.anualidadP.UseVisualStyleBackColor = true;
            this.anualidadP.Click += new System.EventHandler(this.anualidadP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(470, 344);
            this.Controls.Add(this.anualidadP);
            this.Controls.Add(this.btbanualidadD);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btbfinalizar);
            this.Controls.Add(this.btbanualidadA);
            this.Controls.Add(this.btbanualidad);
            this.Controls.Add(this.label6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btbanualidad;
        private System.Windows.Forms.Button btbanualidadA;
        private System.Windows.Forms.Button btbfinalizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btbanualidadD;
        private System.Windows.Forms.Button anualidadP;
    }
}

