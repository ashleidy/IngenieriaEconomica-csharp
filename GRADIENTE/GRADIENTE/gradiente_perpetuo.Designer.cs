namespace GRADIENTE
{
    partial class gradiente_perpetuo
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
            this.txtprimeracuota = new System.Windows.Forms.TextBox();
            this.btbreiniciar = new System.Windows.Forms.Button();
            this.btbfinalizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVP = new System.Windows.Forms.TextBox();
            this.txttasaefectiva = new System.Windows.Forms.TextBox();
            this.txttasanominal = new System.Windows.Forms.TextBox();
            this.btbcalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(394, 64);
            this.label7.TabIndex = 68;
            this.label7.Text = "GRADIENTE GEOMETRICO \r\nPERPETUO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 236);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 67;
            this.label6.Text = "Primera cutota:";
            // 
            // txtprimeracuota
            // 
            this.txtprimeracuota.Location = new System.Drawing.Point(263, 256);
            this.txtprimeracuota.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtprimeracuota.Name = "txtprimeracuota";
            this.txtprimeracuota.Size = new System.Drawing.Size(132, 22);
            this.txtprimeracuota.TabIndex = 66;
            // 
            // btbreiniciar
            // 
            this.btbreiniciar.Location = new System.Drawing.Point(28, 324);
            this.btbreiniciar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btbreiniciar.Name = "btbreiniciar";
            this.btbreiniciar.Size = new System.Drawing.Size(136, 34);
            this.btbreiniciar.TabIndex = 65;
            this.btbreiniciar.Text = "REINICIAR";
            this.btbreiniciar.UseVisualStyleBackColor = true;
            this.btbreiniciar.Click += new System.EventHandler(this.btbreiniciar_Click);
            // 
            // btbfinalizar
            // 
            this.btbfinalizar.Location = new System.Drawing.Point(355, 324);
            this.btbfinalizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btbfinalizar.Name = "btbfinalizar";
            this.btbfinalizar.Size = new System.Drawing.Size(141, 34);
            this.btbfinalizar.TabIndex = 64;
            this.btbfinalizar.Text = "FINALIZAR";
            this.btbfinalizar.UseVisualStyleBackColor = true;
            this.btbfinalizar.Click += new System.EventHandler(this.btbfinalizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 62;
            this.label4.Text = "Valor presente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 61;
            this.label3.Text = "Tasa efectiva:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 156);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 60;
            this.label2.Text = "Tasa nominal:";
            // 
            // txtVP
            // 
            this.txtVP.Location = new System.Drawing.Point(275, 180);
            this.txtVP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVP.Name = "txtVP";
            this.txtVP.Size = new System.Drawing.Size(132, 22);
            this.txtVP.TabIndex = 57;
            // 
            // txttasaefectiva
            // 
            this.txttasaefectiva.Location = new System.Drawing.Point(91, 262);
            this.txttasaefectiva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttasaefectiva.Name = "txttasaefectiva";
            this.txttasaefectiva.Size = new System.Drawing.Size(132, 22);
            this.txttasaefectiva.TabIndex = 56;
            // 
            // txttasanominal
            // 
            this.txttasanominal.Location = new System.Drawing.Point(91, 181);
            this.txttasanominal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttasanominal.Name = "txttasanominal";
            this.txttasanominal.Size = new System.Drawing.Size(132, 22);
            this.txttasanominal.TabIndex = 55;
            // 
            // btbcalcular
            // 
            this.btbcalcular.Location = new System.Drawing.Point(179, 324);
            this.btbcalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btbcalcular.Name = "btbcalcular";
            this.btbcalcular.Size = new System.Drawing.Size(133, 34);
            this.btbcalcular.TabIndex = 53;
            this.btbcalcular.Text = "CALCULAR";
            this.btbcalcular.UseVisualStyleBackColor = true;
            this.btbcalcular.Click += new System.EventHandler(this.btbcalcular_Click);
            // 
            // gradiente_perpetuo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 406);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtprimeracuota);
            this.Controls.Add(this.btbreiniciar);
            this.Controls.Add(this.btbfinalizar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVP);
            this.Controls.Add(this.txttasaefectiva);
            this.Controls.Add(this.txttasanominal);
            this.Controls.Add(this.btbcalcular);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "gradiente_perpetuo";
            this.Text = "gradiente_perpetuo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtprimeracuota;
        private System.Windows.Forms.Button btbreiniciar;
        private System.Windows.Forms.Button btbfinalizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVP;
        private System.Windows.Forms.TextBox txttasaefectiva;
        private System.Windows.Forms.TextBox txttasanominal;
        private System.Windows.Forms.Button btbcalcular;
    }
}