namespace SERIES
{
    partial class anualidad_perpetua
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
            this.label6 = new System.Windows.Forms.Label();
            this.btbreiniciar = new System.Windows.Forms.Button();
            this.btbfinalizar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVF = new System.Windows.Forms.TextBox();
            this.txtVP = new System.Windows.Forms.TextBox();
            this.txttasa = new System.Windows.Forms.TextBox();
            this.txtanual = new System.Windows.Forms.TextBox();
            this.txttiempo = new System.Windows.Forms.TextBox();
            this.btbcalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 26);
            this.label6.TabIndex = 29;
            this.label6.Text = "ANUALIDAD PERPETUA";
            // 
            // btbreiniciar
            // 
            this.btbreiniciar.Location = new System.Drawing.Point(19, 279);
            this.btbreiniciar.Name = "btbreiniciar";
            this.btbreiniciar.Size = new System.Drawing.Size(100, 23);
            this.btbreiniciar.TabIndex = 28;
            this.btbreiniciar.Text = "REINICIAR";
            this.btbreiniciar.UseVisualStyleBackColor = true;
            this.btbreiniciar.Click += new System.EventHandler(this.btbreiniciar_Click);
            // 
            // btbfinalizar
            // 
            this.btbfinalizar.Location = new System.Drawing.Point(264, 279);
            this.btbfinalizar.Name = "btbfinalizar";
            this.btbfinalizar.Size = new System.Drawing.Size(100, 23);
            this.btbfinalizar.TabIndex = 27;
            this.btbfinalizar.Text = "FINALIZAR";
            this.btbfinalizar.UseVisualStyleBackColor = true;
            this.btbfinalizar.Click += new System.EventHandler(this.btbfinalizar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Valor futuro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Valor presente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tasa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Anualidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tiempo:";
            // 
            // txtVF
            // 
            this.txtVF.Location = new System.Drawing.Point(233, 159);
            this.txtVF.Name = "txtVF";
            this.txtVF.Size = new System.Drawing.Size(100, 20);
            this.txtVF.TabIndex = 21;
            // 
            // txtVP
            // 
            this.txtVP.Location = new System.Drawing.Point(233, 101);
            this.txtVP.Name = "txtVP";
            this.txtVP.Size = new System.Drawing.Size(100, 20);
            this.txtVP.TabIndex = 20;
            // 
            // txttasa
            // 
            this.txttasa.Location = new System.Drawing.Point(160, 216);
            this.txttasa.Name = "txttasa";
            this.txttasa.Size = new System.Drawing.Size(100, 20);
            this.txttasa.TabIndex = 19;
            // 
            // txtanual
            // 
            this.txtanual.Location = new System.Drawing.Point(72, 159);
            this.txtanual.Name = "txtanual";
            this.txtanual.Size = new System.Drawing.Size(100, 20);
            this.txtanual.TabIndex = 18;
            // 
            // txttiempo
            // 
            this.txttiempo.Location = new System.Drawing.Point(72, 101);
            this.txttiempo.Name = "txttiempo";
            this.txttiempo.Size = new System.Drawing.Size(100, 20);
            this.txttiempo.TabIndex = 17;
            // 
            // btbcalcular
            // 
            this.btbcalcular.Location = new System.Drawing.Point(141, 276);
            this.btbcalcular.Name = "btbcalcular";
            this.btbcalcular.Size = new System.Drawing.Size(100, 26);
            this.btbcalcular.TabIndex = 16;
            this.btbcalcular.Text = "CALCULAR";
            this.btbcalcular.UseVisualStyleBackColor = true;
            this.btbcalcular.Click += new System.EventHandler(this.btbcalcular_Click);
            // 
            // anualidad_perpetua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(394, 341);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btbreiniciar);
            this.Controls.Add(this.btbfinalizar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVF);
            this.Controls.Add(this.txtVP);
            this.Controls.Add(this.txttasa);
            this.Controls.Add(this.txtanual);
            this.Controls.Add(this.txttiempo);
            this.Controls.Add(this.btbcalcular);
            this.Name = "anualidad_perpetua";
            this.Text = "anualidad_perpetua";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btbreiniciar;
        private System.Windows.Forms.Button btbfinalizar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVF;
        private System.Windows.Forms.TextBox txtVP;
        private System.Windows.Forms.TextBox txttasa;
        private System.Windows.Forms.TextBox txtanual;
        private System.Windows.Forms.TextBox txttiempo;
        private System.Windows.Forms.Button btbcalcular;
    }
}