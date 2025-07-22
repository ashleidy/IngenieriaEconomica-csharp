namespace GRADIENTE
{
    partial class gradiente_decreciente
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtcuota = new System.Windows.Forms.TextBox();
            this.btbcuota = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtgradiente = new System.Windows.Forms.TextBox();
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(220, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Cuota:";
            // 
            // txtcuota
            // 
            this.txtcuota.Location = new System.Drawing.Point(199, 225);
            this.txtcuota.Name = "txtcuota";
            this.txtcuota.Size = new System.Drawing.Size(100, 20);
            this.txtcuota.TabIndex = 51;
            // 
            // btbcuota
            // 
            this.btbcuota.Location = new System.Drawing.Point(333, 136);
            this.btbcuota.Name = "btbcuota";
            this.btbcuota.Size = new System.Drawing.Size(87, 58);
            this.btbcuota.TabIndex = 50;
            this.btbcuota.Text = "CALCULAR CUOTA";
            this.btbcuota.UseVisualStyleBackColor = true;
            this.btbcuota.Click += new System.EventHandler(this.btbcuota_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(90, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(305, 26);
            this.label7.TabIndex = 49;
            this.label7.Text = "GRADIENTE DECRECIENTE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Gradiente:";
            // 
            // txtgradiente
            // 
            this.txtgradiente.Location = new System.Drawing.Point(71, 258);
            this.txtgradiente.Name = "txtgradiente";
            this.txtgradiente.Size = new System.Drawing.Size(100, 20);
            this.txtgradiente.TabIndex = 47;
            // 
            // btbreiniciar
            // 
            this.btbreiniciar.Location = new System.Drawing.Point(69, 306);
            this.btbreiniciar.Name = "btbreiniciar";
            this.btbreiniciar.Size = new System.Drawing.Size(102, 28);
            this.btbreiniciar.TabIndex = 46;
            this.btbreiniciar.Text = "REINICIAR";
            this.btbreiniciar.UseVisualStyleBackColor = true;
            this.btbreiniciar.Click += new System.EventHandler(this.btbreiniciar_Click);
            // 
            // btbfinalizar
            // 
            this.btbfinalizar.Location = new System.Drawing.Point(314, 306);
            this.btbfinalizar.Name = "btbfinalizar";
            this.btbfinalizar.Size = new System.Drawing.Size(106, 28);
            this.btbfinalizar.TabIndex = 45;
            this.btbfinalizar.Text = "FINALIZAR";
            this.btbfinalizar.UseVisualStyleBackColor = true;
            this.btbfinalizar.Click += new System.EventHandler(this.btbfinalizar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Valor futuro:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Valor presente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Tasa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Anualidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tiempo:";
            // 
            // txtVF
            // 
            this.txtVF.Location = new System.Drawing.Point(199, 174);
            this.txtVF.Name = "txtVF";
            this.txtVF.Size = new System.Drawing.Size(100, 20);
            this.txtVF.TabIndex = 39;
            // 
            // txtVP
            // 
            this.txtVP.Location = new System.Drawing.Point(199, 116);
            this.txtVP.Name = "txtVP";
            this.txtVP.Size = new System.Drawing.Size(100, 20);
            this.txtVP.TabIndex = 38;
            // 
            // txttasa
            // 
            this.txttasa.Location = new System.Drawing.Point(71, 202);
            this.txttasa.Name = "txttasa";
            this.txttasa.Size = new System.Drawing.Size(100, 20);
            this.txttasa.TabIndex = 37;
            // 
            // txtanual
            // 
            this.txtanual.Location = new System.Drawing.Point(71, 136);
            this.txtanual.Name = "txtanual";
            this.txtanual.Size = new System.Drawing.Size(100, 20);
            this.txtanual.TabIndex = 36;
            // 
            // txttiempo
            // 
            this.txttiempo.Location = new System.Drawing.Point(71, 78);
            this.txttiempo.Name = "txttiempo";
            this.txttiempo.Size = new System.Drawing.Size(100, 20);
            this.txttiempo.TabIndex = 35;
            // 
            // btbcalcular
            // 
            this.btbcalcular.Location = new System.Drawing.Point(182, 306);
            this.btbcalcular.Name = "btbcalcular";
            this.btbcalcular.Size = new System.Drawing.Size(100, 28);
            this.btbcalcular.TabIndex = 34;
            this.btbcalcular.Text = "CALCULAR";
            this.btbcalcular.UseVisualStyleBackColor = true;
            this.btbcalcular.Click += new System.EventHandler(this.btbcalcular_Click);
            // 
            // gradiente_decreciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(489, 345);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcuota);
            this.Controls.Add(this.btbcuota);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtgradiente);
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
            this.Name = "gradiente_decreciente";
            this.Text = "gradiente_decreciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcuota;
        private System.Windows.Forms.Button btbcuota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtgradiente;
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