
namespace TrocoCaixa
{
    partial class TelaPrincipal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCompra = new System.Windows.Forms.TextBox();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl100 = new System.Windows.Forms.Label();
            this.lbl050 = new System.Windows.Forms.Label();
            this.lbl025 = new System.Windows.Forms.Label();
            this.lbl010 = new System.Windows.Forms.Label();
            this.lbl005 = new System.Windows.Forms.Label();
            this.lbl001 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTitulo.Font = new System.Drawing.Font("Kristen ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(279, 50);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(223, 33);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Caixa Para Troco";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(191, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 121);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(119, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor da Compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(119, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor em dinheiro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tempus Sans ITC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(119, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Troco";
            // 
            // txtCompra
            // 
            this.txtCompra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCompra.Location = new System.Drawing.Point(313, 180);
            this.txtCompra.Name = "txtCompra";
            this.txtCompra.Size = new System.Drawing.Size(138, 27);
            this.txtCompra.TabIndex = 5;
            this.txtCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDinheiro.Location = new System.Drawing.Point(313, 220);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(138, 27);
            this.txtDinheiro.TabIndex = 6;
            this.txtDinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTroco
            // 
            this.txtTroco.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTroco.Location = new System.Drawing.Point(313, 263);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.ReadOnly = true;
            this.txtTroco.Size = new System.Drawing.Size(138, 27);
            this.txtTroco.TabIndex = 7;
            this.txtTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.Location = new System.Drawing.Point(119, 331);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(332, 63);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;

            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(626, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Moedas R$ 1,00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(626, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Moedas R$ 0,05";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(626, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Moedas R$ 0,10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(626, 256);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Moedas R$ 0,25";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(626, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 15);
            this.label9.TabIndex = 13;
            this.label9.Text = "Moedas R$ 0,50";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(626, 369);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "Moedas R$ 0,01";
            // 
            // lbl100
            // 
            this.lbl100.Location = new System.Drawing.Point(576, 187);
            this.lbl100.Name = "lbl100";
            this.lbl100.Size = new System.Drawing.Size(44, 23);
            this.lbl100.TabIndex = 15;
            // 
            // lbl050
            // 
            this.lbl050.Location = new System.Drawing.Point(576, 220);
            this.lbl050.Name = "lbl050";
            this.lbl050.Size = new System.Drawing.Size(44, 23);
            this.lbl050.TabIndex = 16;
            // 
            // lbl025
            // 
            this.lbl025.Location = new System.Drawing.Point(576, 256);
            this.lbl025.Name = "lbl025";
            this.lbl025.Size = new System.Drawing.Size(44, 23);
            this.lbl025.TabIndex = 17;
            // 
            // lbl010
            // 
            this.lbl010.Location = new System.Drawing.Point(576, 296);
            this.lbl010.Name = "lbl010";
            this.lbl010.Size = new System.Drawing.Size(44, 23);
            this.lbl010.TabIndex = 18;
            // 
            // lbl005
            // 
            this.lbl005.Location = new System.Drawing.Point(576, 333);
            this.lbl005.Name = "lbl005";
            this.lbl005.Size = new System.Drawing.Size(44, 23);
            this.lbl005.TabIndex = 19;
            // 
            // lbl001
            // 
            this.lbl001.Location = new System.Drawing.Point(576, 360);
            this.lbl001.Name = "lbl001";
            this.lbl001.Size = new System.Drawing.Size(44, 23);
            this.lbl001.TabIndex = 20;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl001);
            this.Controls.Add(this.lbl005);
            this.Controls.Add(this.lbl010);
            this.Controls.Add(this.lbl025);
            this.Controls.Add(this.lbl050);
            this.Controls.Add(this.lbl100);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.txtDinheiro);
            this.Controls.Add(this.txtCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.label1);
            this.Name = "TelaPrincipal";
            this.ShowIcon = false;
            this.Text = "Caixa :: Troco";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCompra;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl100;
        private System.Windows.Forms.Label lbl050;
        private System.Windows.Forms.Label lbl025;
        private System.Windows.Forms.Label lbl010;
        private System.Windows.Forms.Label lbl005;
        private System.Windows.Forms.Label lbl001;
    }
}