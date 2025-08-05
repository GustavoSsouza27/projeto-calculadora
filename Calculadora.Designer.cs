namespace Calculadora
{
    partial class Calculadora
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
            lblNumero1 = new Label();
            txtNumero1 = new TextBox();
            lblNumero2 = new Label();
            txtNumero2 = new TextBox();
            btnSomar = new Button();
            btnSubtrair = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Location = new Point(12, 23);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(60, 15);
            lblNumero1.TabIndex = 0;
            lblNumero1.Text = "Número 1";
            // 
            // txtNumero1
            // 
            txtNumero1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumero1.Location = new Point(12, 41);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 29);
            txtNumero1.TabIndex = 1;
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Location = new Point(216, 23);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(60, 15);
            lblNumero2.TabIndex = 2;
            lblNumero2.Text = "Número 2";
            // 
            // txtNumero2
            // 
            txtNumero2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumero2.Location = new Point(199, 41);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 29);
            txtNumero2.TabIndex = 3;
            // 
            // btnSomar
            // 
            btnSomar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSomar.Location = new Point(22, 96);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(75, 23);
            btnSomar.TabIndex = 4;
            btnSomar.Text = "Somar";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(120, 96);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(75, 23);
            btnSubtrair.TabIndex = 5;
            btnSubtrair.Text = "Subtrair";
            btnSubtrair.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(216, 96);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(75, 23);
            btnMultiplicar.TabIndex = 6;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(311, 96);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(75, 23);
            btnDividir.TabIndex = 7;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(340, 55);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(23, 25);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "0";
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 484);
            Controls.Add(lblResultado);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnSubtrair);
            Controls.Add(btnSomar);
            Controls.Add(txtNumero2);
            Controls.Add(lblNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(lblNumero1);
            Name = "Calculadora";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero1;
        private TextBox txtNumero1;
        private Label lblNumero2;
        private TextBox txtNumero2;
        private Button btnSomar;
        private Button btnSubtrair;
        private Button btnMultiplicar;
        private Button btnDividir;
        private Label lblResultado;
    }
}
