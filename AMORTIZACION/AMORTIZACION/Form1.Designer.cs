namespace AMORTIZACION
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
            this.label6 = new System.Windows.Forms.Label();
            this.btbreiniciar = new System.Windows.Forms.Button();
            this.btbfinalizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtVP = new System.Windows.Forms.TextBox();
            this.txttasa = new System.Windows.Forms.TextBox();
            this.txtanual = new System.Windows.Forms.TextBox();
            this.txttiempo = new System.Windows.Forms.TextBox();
            this.btbcalcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsaldo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtinteres = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtamortizacion = new System.Windows.Forms.TextBox();
            this.BTBSALDO = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(126, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 26);
            this.label6.TabIndex = 29;
            this.label6.Text = "AMORTIZACIÓN";
            // 
            // btbreiniciar
            // 
            this.btbreiniciar.Location = new System.Drawing.Point(25, 269);
            this.btbreiniciar.Name = "btbreiniciar";
            this.btbreiniciar.Size = new System.Drawing.Size(100, 23);
            this.btbreiniciar.TabIndex = 28;
            this.btbreiniciar.Text = "REINICIAR";
            this.btbreiniciar.UseVisualStyleBackColor = true;
            this.btbreiniciar.Click += new System.EventHandler(this.btbreiniciar_Click);
            // 
            // btbfinalizar
            // 
            this.btbfinalizar.Location = new System.Drawing.Point(25, 332);
            this.btbfinalizar.Name = "btbfinalizar";
            this.btbfinalizar.Size = new System.Drawing.Size(100, 23);
            this.btbfinalizar.TabIndex = 27;
            this.btbfinalizar.Text = "FINALIZAR";
            this.btbfinalizar.UseVisualStyleBackColor = true;
            this.btbfinalizar.Click += new System.EventHandler(this.btbfinalizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Deuda o valor presente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tasa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Anualidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tiempo:";
            // 
            // txtVP
            // 
            this.txtVP.Location = new System.Drawing.Point(256, 133);
            this.txtVP.Name = "txtVP";
            this.txtVP.Size = new System.Drawing.Size(100, 20);
            this.txtVP.TabIndex = 20;
            // 
            // txttasa
            // 
            this.txttasa.Location = new System.Drawing.Point(256, 191);
            this.txttasa.Name = "txttasa";
            this.txttasa.Size = new System.Drawing.Size(100, 20);
            this.txttasa.TabIndex = 19;
            // 
            // txtanual
            // 
            this.txtanual.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtanual.Location = new System.Drawing.Point(95, 191);
            this.txtanual.Name = "txtanual";
            this.txtanual.Size = new System.Drawing.Size(100, 20);
            this.txtanual.TabIndex = 18;
            // 
            // txttiempo
            // 
            this.txttiempo.Location = new System.Drawing.Point(95, 133);
            this.txttiempo.Name = "txttiempo";
            this.txttiempo.Size = new System.Drawing.Size(100, 20);
            this.txttiempo.TabIndex = 17;
            // 
            // btbcalcular
            // 
            this.btbcalcular.Location = new System.Drawing.Point(25, 298);
            this.btbcalcular.Name = "btbcalcular";
            this.btbcalcular.Size = new System.Drawing.Size(100, 28);
            this.btbcalcular.TabIndex = 16;
            this.btbcalcular.Text = "CALCULAR ";
            this.btbcalcular.UseVisualStyleBackColor = true;
            this.btbcalcular.Click += new System.EventHandler(this.btbcalcular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Saldo:";
            // 
            // txtsaldo
            // 
            this.txtsaldo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtsaldo.Location = new System.Drawing.Point(182, 252);
            this.txtsaldo.Name = "txtsaldo";
            this.txtsaldo.Size = new System.Drawing.Size(100, 20);
            this.txtsaldo.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Interes:";
            // 
            // txtinteres
            // 
            this.txtinteres.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtinteres.Location = new System.Drawing.Point(182, 304);
            this.txtinteres.Name = "txtinteres";
            this.txtinteres.Size = new System.Drawing.Size(100, 20);
            this.txtinteres.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(196, 342);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Amortizacion:";
            // 
            // txtamortizacion
            // 
            this.txtamortizacion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtamortizacion.Location = new System.Drawing.Point(182, 362);
            this.txtamortizacion.Name = "txtamortizacion";
            this.txtamortizacion.Size = new System.Drawing.Size(100, 20);
            this.txtamortizacion.TabIndex = 34;
            // 
            // BTBSALDO
            // 
            this.BTBSALDO.Location = new System.Drawing.Point(314, 269);
            this.BTBSALDO.Name = "BTBSALDO";
            this.BTBSALDO.Size = new System.Drawing.Size(103, 41);
            this.BTBSALDO.TabIndex = 36;
            this.BTBSALDO.Text = "CALCULAR SALDO ";
            this.BTBSALDO.UseVisualStyleBackColor = true;
            this.BTBSALDO.Click += new System.EventHandler(this.BTBSALDO_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 41);
            this.button1.TabIndex = 37;
            this.button1.Text = "CALCULAR AMORTIZACIÓN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTBSALDO);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtamortizacion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtinteres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsaldo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btbreiniciar);
            this.Controls.Add(this.btbfinalizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVP);
            this.Controls.Add(this.txttasa);
            this.Controls.Add(this.txtanual);
            this.Controls.Add(this.txttiempo);
            this.Controls.Add(this.btbcalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btbreiniciar;
        private System.Windows.Forms.Button btbfinalizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVP;
        private System.Windows.Forms.TextBox txttasa;
        private System.Windows.Forms.TextBox txtanual;
        private System.Windows.Forms.TextBox txttiempo;
        private System.Windows.Forms.Button btbcalcular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsaldo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtinteres;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtamortizacion;
        private System.Windows.Forms.Button BTBSALDO;
        private System.Windows.Forms.Button button1;
    }
}

