namespace TASAS
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTE = new System.Windows.Forms.TextBox();
            this.txtVP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmeses = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttiempo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btbfinalizar = new System.Windows.Forms.Button();
            this.btbreiniciar = new System.Windows.Forms.Button();
            this.btcalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tasa nominal:";
            // 
            // txtTN
            // 
            this.txtTN.Location = new System.Drawing.Point(31, 97);
            this.txtTN.Name = "txtTN";
            this.txtTN.Size = new System.Drawing.Size(100, 20);
            this.txtTN.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tasa efectiva:";
            // 
            // txtTE
            // 
            this.txtTE.Location = new System.Drawing.Point(31, 184);
            this.txtTE.Name = "txtTE";
            this.txtTE.Size = new System.Drawing.Size(100, 20);
            this.txtTE.TabIndex = 3;
            // 
            // txtVP
            // 
            this.txtVP.Location = new System.Drawing.Point(171, 184);
            this.txtVP.Name = "txtVP";
            this.txtVP.Size = new System.Drawing.Size(100, 20);
            this.txtVP.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor presente:";
            // 
            // txtVF
            // 
            this.txtVF.Location = new System.Drawing.Point(171, 97);
            this.txtVF.Name = "txtVF";
            this.txtVF.Size = new System.Drawing.Size(100, 20);
            this.txtVF.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor futuro:";
            // 
            // txtmeses
            // 
            this.txtmeses.Location = new System.Drawing.Point(319, 184);
            this.txtmeses.Name = "txtmeses";
            this.txtmeses.Size = new System.Drawing.Size(100, 20);
            this.txtmeses.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(332, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Meses:";
            // 
            // txttiempo
            // 
            this.txttiempo.Location = new System.Drawing.Point(319, 97);
            this.txttiempo.Name = "txttiempo";
            this.txttiempo.Size = new System.Drawing.Size(100, 20);
            this.txttiempo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tiempo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(120, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "TASAS DE INTERES";
            // 
            // btbfinalizar
            // 
            this.btbfinalizar.Location = new System.Drawing.Point(319, 230);
            this.btbfinalizar.Name = "btbfinalizar";
            this.btbfinalizar.Size = new System.Drawing.Size(93, 26);
            this.btbfinalizar.TabIndex = 18;
            this.btbfinalizar.Text = "FINALIZAR";
            this.btbfinalizar.UseVisualStyleBackColor = true;
            this.btbfinalizar.Click += new System.EventHandler(this.btbfinalizar_Click);
            // 
            // btbreiniciar
            // 
            this.btbreiniciar.Location = new System.Drawing.Point(182, 230);
            this.btbreiniciar.Name = "btbreiniciar";
            this.btbreiniciar.Size = new System.Drawing.Size(93, 26);
            this.btbreiniciar.TabIndex = 17;
            this.btbreiniciar.Text = "REINICIAR";
            this.btbreiniciar.UseVisualStyleBackColor = true;
            this.btbreiniciar.Click += new System.EventHandler(this.btbreiniciar_Click);
            // 
            // btcalcular
            // 
            this.btcalcular.Location = new System.Drawing.Point(43, 230);
            this.btcalcular.Name = "btcalcular";
            this.btcalcular.Size = new System.Drawing.Size(93, 26);
            this.btcalcular.TabIndex = 16;
            this.btcalcular.Text = "CALCULAR";
            this.btcalcular.UseVisualStyleBackColor = true;
            this.btcalcular.Click += new System.EventHandler(this.btcalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(492, 293);
            this.Controls.Add(this.btbfinalizar);
            this.Controls.Add(this.btbreiniciar);
            this.Controls.Add(this.btcalcular);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtmeses);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txttiempo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtVP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTN);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTE;
        private System.Windows.Forms.TextBox txtVP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmeses;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttiempo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btbfinalizar;
        private System.Windows.Forms.Button btbreiniciar;
        private System.Windows.Forms.Button btcalcular;
    }
}

