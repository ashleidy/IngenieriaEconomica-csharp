namespace GRADIENTE
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
            this.btbGAL = new System.Windows.Forms.Button();
            this.btbGLD = new System.Windows.Forms.Button();
            this.btbGGE = new System.Windows.Forms.Button();
            this.btbGGD = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btbfinalizar = new System.Windows.Forms.Button();
            this.btbperpetuo = new System.Windows.Forms.Button();
            this.btbaritmetico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btbGAL
            // 
            this.btbGAL.BackColor = System.Drawing.SystemColors.Info;
            this.btbGAL.Location = new System.Drawing.Point(23, 88);
            this.btbGAL.Name = "btbGAL";
            this.btbGAL.Size = new System.Drawing.Size(129, 50);
            this.btbGAL.TabIndex = 0;
            this.btbGAL.Text = "Gradiente aritmetico o lineal";
            this.btbGAL.UseVisualStyleBackColor = false;
            this.btbGAL.Click += new System.EventHandler(this.btbGAL_Click);
            // 
            // btbGLD
            // 
            this.btbGLD.BackColor = System.Drawing.SystemColors.Info;
            this.btbGLD.Location = new System.Drawing.Point(23, 163);
            this.btbGLD.Name = "btbGLD";
            this.btbGLD.Size = new System.Drawing.Size(129, 50);
            this.btbGLD.TabIndex = 1;
            this.btbGLD.Text = "Gradiente lineal decreciente\r\n";
            this.btbGLD.UseVisualStyleBackColor = false;
            this.btbGLD.Click += new System.EventHandler(this.btbGLD_Click);
            // 
            // btbGGE
            // 
            this.btbGGE.BackColor = System.Drawing.SystemColors.Info;
            this.btbGGE.Location = new System.Drawing.Point(178, 88);
            this.btbGGE.Name = "btbGGE";
            this.btbGGE.Size = new System.Drawing.Size(150, 44);
            this.btbGGE.TabIndex = 2;
            this.btbGGE.Text = "Gradiente geometrico exponencial";
            this.btbGGE.UseVisualStyleBackColor = false;
            this.btbGGE.Click += new System.EventHandler(this.btbGGE_Click);
            // 
            // btbGGD
            // 
            this.btbGGD.BackColor = System.Drawing.SystemColors.Info;
            this.btbGGD.Location = new System.Drawing.Point(190, 160);
            this.btbGGD.Name = "btbGGD";
            this.btbGGD.Size = new System.Drawing.Size(138, 50);
            this.btbGGD.TabIndex = 3;
            this.btbGGD.Text = "Gradiente geometrico decreciente";
            this.btbGGD.UseVisualStyleBackColor = false;
            this.btbGGD.Click += new System.EventHandler(this.btbGGD_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(183, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "GRADIENTE\r\n";
            // 
            // btbfinalizar
            // 
            this.btbfinalizar.BackColor = System.Drawing.SystemColors.Info;
            this.btbfinalizar.Location = new System.Drawing.Point(205, 232);
            this.btbfinalizar.Name = "btbfinalizar";
            this.btbfinalizar.Size = new System.Drawing.Size(102, 35);
            this.btbfinalizar.TabIndex = 17;
            this.btbfinalizar.Text = "FINALIZAR";
            this.btbfinalizar.UseVisualStyleBackColor = false;
            this.btbfinalizar.Click += new System.EventHandler(this.btbfinalizar_Click);
            // 
            // btbperpetuo
            // 
            this.btbperpetuo.BackColor = System.Drawing.SystemColors.Info;
            this.btbperpetuo.Location = new System.Drawing.Point(356, 163);
            this.btbperpetuo.Name = "btbperpetuo";
            this.btbperpetuo.Size = new System.Drawing.Size(138, 50);
            this.btbperpetuo.TabIndex = 19;
            this.btbperpetuo.Text = "Gradiente geometrico perpetuo";
            this.btbperpetuo.UseVisualStyleBackColor = false;
            this.btbperpetuo.Click += new System.EventHandler(this.btbperpetuo_Click);
            // 
            // btbaritmetico
            // 
            this.btbaritmetico.BackColor = System.Drawing.SystemColors.Info;
            this.btbaritmetico.Location = new System.Drawing.Point(344, 91);
            this.btbaritmetico.Name = "btbaritmetico";
            this.btbaritmetico.Size = new System.Drawing.Size(150, 44);
            this.btbaritmetico.TabIndex = 18;
            this.btbaritmetico.Text = "Gradiente aritmetico perpetuo";
            this.btbaritmetico.UseVisualStyleBackColor = false;
            this.btbaritmetico.Click += new System.EventHandler(this.btbaritmetico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(521, 291);
            this.Controls.Add(this.btbperpetuo);
            this.Controls.Add(this.btbaritmetico);
            this.Controls.Add(this.btbfinalizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btbGGD);
            this.Controls.Add(this.btbGGE);
            this.Controls.Add(this.btbGLD);
            this.Controls.Add(this.btbGAL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbGAL;
        private System.Windows.Forms.Button btbGLD;
        private System.Windows.Forms.Button btbGGE;
        private System.Windows.Forms.Button btbGGD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btbfinalizar;
        private System.Windows.Forms.Button btbperpetuo;
        private System.Windows.Forms.Button btbaritmetico;
    }
}

