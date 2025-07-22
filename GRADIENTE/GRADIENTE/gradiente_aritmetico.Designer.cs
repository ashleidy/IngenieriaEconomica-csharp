namespace GRADIENTE
{
    partial class gradiente_aritmetico
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtgradiente = new System.Windows.Forms.TextBox();
            this.btbreiniciar = new System.Windows.Forms.Button();
            this.btbfinalizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVP = new System.Windows.Forms.TextBox();
            this.txttasa = new System.Windows.Forms.TextBox();
            this.txtanual = new System.Windows.Forms.TextBox();
            this.btbcalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(418, 26);
            this.label7.TabIndex = 68;
            this.label7.Text = "Gradiente aritmetico perpetuo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Gradiente:";
            // 
            // txtgradiente
            // 
            this.txtgradiente.Location = new System.Drawing.Point(83, 83);
            this.txtgradiente.Name = "txtgradiente";
            this.txtgradiente.Size = new System.Drawing.Size(100, 20);
            this.txtgradiente.TabIndex = 66;
            // 
            // btbreiniciar
            // 
            this.btbreiniciar.Location = new System.Drawing.Point(28, 200);
            this.btbreiniciar.Name = "btbreiniciar";
            this.btbreiniciar.Size = new System.Drawing.Size(102, 28);
            this.btbreiniciar.TabIndex = 65;
            this.btbreiniciar.Text = "REINICIAR";
            this.btbreiniciar.UseVisualStyleBackColor = true;
            this.btbreiniciar.Click += new System.EventHandler(this.btbreiniciar_Click);
            // 
            // btbfinalizar
            // 
            this.btbfinalizar.Location = new System.Drawing.Point(273, 200);
            this.btbfinalizar.Name = "btbfinalizar";
            this.btbfinalizar.Size = new System.Drawing.Size(106, 28);
            this.btbfinalizar.TabIndex = 64;
            this.btbfinalizar.Text = "FINALIZAR";
            this.btbfinalizar.UseVisualStyleBackColor = true;
            this.btbfinalizar.Click += new System.EventHandler(this.btbfinalizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Valor presente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Tasa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Anualidad:";
            // 
            // txtVP
            // 
            this.txtVP.Location = new System.Drawing.Point(220, 83);
            this.txtVP.Name = "txtVP";
            this.txtVP.Size = new System.Drawing.Size(100, 20);
            this.txtVP.TabIndex = 57;
            // 
            // txttasa
            // 
            this.txttasa.Location = new System.Drawing.Point(220, 141);
            this.txttasa.Name = "txttasa";
            this.txttasa.Size = new System.Drawing.Size(100, 20);
            this.txttasa.TabIndex = 56;
            // 
            // txtanual
            // 
            this.txtanual.Location = new System.Drawing.Point(83, 141);
            this.txtanual.Name = "txtanual";
            this.txtanual.Size = new System.Drawing.Size(100, 20);
            this.txtanual.TabIndex = 55;
            // 
            // btbcalcular
            // 
            this.btbcalcular.Location = new System.Drawing.Point(141, 200);
            this.btbcalcular.Name = "btbcalcular";
            this.btbcalcular.Size = new System.Drawing.Size(100, 28);
            this.btbcalcular.TabIndex = 53;
            this.btbcalcular.Text = "CALCULAR";
            this.btbcalcular.UseVisualStyleBackColor = true;
            this.btbcalcular.Click += new System.EventHandler(this.btbcalcular_Click);
            // 
            // gradiente_aritmetico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 259);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtgradiente);
            this.Controls.Add(this.btbreiniciar);
            this.Controls.Add(this.btbfinalizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVP);
            this.Controls.Add(this.txttasa);
            this.Controls.Add(this.txtanual);
            this.Controls.Add(this.btbcalcular);
            this.Name = "gradiente_aritmetico";
            this.Text = "gradiente_aritmetico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtgradiente;
        private System.Windows.Forms.Button btbreiniciar;
        private System.Windows.Forms.Button btbfinalizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVP;
        private System.Windows.Forms.TextBox txttasa;
        private System.Windows.Forms.TextBox txtanual;
        private System.Windows.Forms.Button btbcalcular;
    }
}