namespace ICompuesto
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btbfinalizar = new System.Windows.Forms.Button();
            this.btbreiniciar = new System.Windows.Forms.Button();
            this.btcalcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVF = new System.Windows.Forms.TextBox();
            this.txtVP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(369, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "TENGA EN CUENTA QUE LOS DECIMALES SE INGRESAN CON COMAS!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(198, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 26);
            this.label6.TabIndex = 29;
            this.label6.Text = "INTERES COMPUESTO";
            // 
            // btbfinalizar
            // 
            this.btbfinalizar.Location = new System.Drawing.Point(90, 213);
            this.btbfinalizar.Name = "btbfinalizar";
            this.btbfinalizar.Size = new System.Drawing.Size(93, 26);
            this.btbfinalizar.TabIndex = 28;
            this.btbfinalizar.Text = "FINALIZAR";
            this.btbfinalizar.UseVisualStyleBackColor = true;
            this.btbfinalizar.Click += new System.EventHandler(this.btbfinalizar_Click);
            // 
            // btbreiniciar
            // 
            this.btbreiniciar.Location = new System.Drawing.Point(90, 157);
            this.btbreiniciar.Name = "btbreiniciar";
            this.btbreiniciar.Size = new System.Drawing.Size(93, 26);
            this.btbreiniciar.TabIndex = 27;
            this.btbreiniciar.Text = "REINICIAR";
            this.btbreiniciar.UseVisualStyleBackColor = true;
            this.btbreiniciar.Click += new System.EventHandler(this.btbreiniciar_Click);
            // 
            // btcalcular
            // 
            this.btcalcular.Location = new System.Drawing.Point(90, 101);
            this.btcalcular.Name = "btcalcular";
            this.btcalcular.Size = new System.Drawing.Size(93, 26);
            this.btcalcular.TabIndex = 26;
            this.btcalcular.Text = "CALCULAR";
            this.btcalcular.UseVisualStyleBackColor = true;
            this.btcalcular.Click += new System.EventHandler(this.btcalcular_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tiempo:";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(230, 176);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(100, 20);
            this.txtTiempo.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tasa de interes %:";
            // 
            // txtTI
            // 
            this.txtTI.Location = new System.Drawing.Point(400, 176);
            this.txtTI.Name = "txtTI";
            this.txtTI.Size = new System.Drawing.Size(100, 20);
            this.txtTI.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Valor futuro:";
            // 
            // txtVF
            // 
            this.txtVF.Location = new System.Drawing.Point(304, 248);
            this.txtVF.Name = "txtVF";
            this.txtVF.Size = new System.Drawing.Size(100, 20);
            this.txtVF.TabIndex = 20;
            // 
            // txtVP
            // 
            this.txtVP.Location = new System.Drawing.Point(230, 101);
            this.txtVP.Name = "txtVP";
            this.txtVP.Size = new System.Drawing.Size(100, 20);
            this.txtVP.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 39);
            this.label2.TabIndex = 18;
            this.label2.Text = "Valor presente:\r\n\r\n\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Interes Compuesto:";
            // 
            // txtIC
            // 
            this.txtIC.Location = new System.Drawing.Point(400, 101);
            this.txtIC.Name = "txtIC";
            this.txtIC.Size = new System.Drawing.Size(100, 20);
            this.txtIC.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btbfinalizar);
            this.Controls.Add(this.btbreiniciar);
            this.Controls.Add(this.btcalcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVF);
            this.Controls.Add(this.txtVP);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btbfinalizar;
        private System.Windows.Forms.Button btbreiniciar;
        private System.Windows.Forms.Button btcalcular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVF;
        private System.Windows.Forms.TextBox txtVP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIC;
    }
}

