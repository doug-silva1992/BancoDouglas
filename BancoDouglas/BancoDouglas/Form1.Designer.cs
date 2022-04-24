namespace BancoDouglas
{
    partial class Banco
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Sacar_Click = new System.Windows.Forms.Button();
            this.Depositar_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textValor = new System.Windows.Forms.TextBox();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.textSaldo = new System.Windows.Forms.TextBox();
            this.textTitular = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textTitular);
            this.groupBox1.Controls.Add(this.textSaldo);
            this.groupBox1.Controls.Add(this.textNumero);
            this.groupBox1.Controls.Add(this.textValor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Depositar_Click);
            this.groupBox1.Controls.Add(this.Sacar_Click);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            // 
            // Sacar_Click
            // 
            this.Sacar_Click.Location = new System.Drawing.Point(38, 183);
            this.Sacar_Click.Name = "Sacar_Click";
            this.Sacar_Click.Size = new System.Drawing.Size(75, 23);
            this.Sacar_Click.TabIndex = 0;
            this.Sacar_Click.Text = "Sacar";
            this.Sacar_Click.UseVisualStyleBackColor = true;
            // 
            // Depositar_Click
            // 
            this.Depositar_Click.Location = new System.Drawing.Point(192, 183);
            this.Depositar_Click.Name = "Depositar_Click";
            this.Depositar_Click.Size = new System.Drawing.Size(75, 23);
            this.Depositar_Click.TabIndex = 1;
            this.Depositar_Click.Text = "Depositar";
            this.Depositar_Click.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valor";
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(89, 130);
            this.textValor.Name = "textValor";
            this.textValor.Size = new System.Drawing.Size(164, 23);
            this.textValor.TabIndex = 6;
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(89, 69);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(164, 23);
            this.textNumero.TabIndex = 7;
            // 
            // textSaldo
            // 
            this.textSaldo.Location = new System.Drawing.Point(89, 101);
            this.textSaldo.Name = "textSaldo";
            this.textSaldo.Size = new System.Drawing.Size(164, 23);
            this.textSaldo.TabIndex = 8;
            // 
            // textTitular
            // 
            this.textTitular.Location = new System.Drawing.Point(89, 40);
            this.textTitular.Name = "textTitular";
            this.textTitular.Size = new System.Drawing.Size(164, 23);
            this.textTitular.TabIndex = 9;
            // 
            // Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 253);
            this.Controls.Add(this.groupBox1);
            this.Name = "Banco";
            this.Text = "Banco";
            this.Load += new System.EventHandler(this.Banco_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textTitular;
        private TextBox textSaldo;
        private TextBox textNumero;
        private TextBox textValor;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Depositar_Click;
        private Button Sacar_Click;
    }
}