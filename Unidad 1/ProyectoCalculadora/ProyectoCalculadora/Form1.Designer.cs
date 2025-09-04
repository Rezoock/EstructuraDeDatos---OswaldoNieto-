namespace ProyectoCalculadora
{
    partial class Form1
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
            grpNumeros = new GroupBox();
            txtNum2 = new TextBox();
            txtNum1 = new TextBox();
            lblNumero2 = new Label();
            lblNumero1 = new Label();
            grpOperacion = new GroupBox();
            radDivision = new RadioButton();
            radMultiplicacion = new RadioButton();
            radResta = new RadioButton();
            radSuma = new RadioButton();
            btnCalcular = new Button();
            grpNumeros.SuspendLayout();
            grpOperacion.SuspendLayout();
            SuspendLayout();
            // 
            // grpNumeros
            // 
            grpNumeros.Controls.Add(txtNum2);
            grpNumeros.Controls.Add(txtNum1);
            grpNumeros.Controls.Add(lblNumero2);
            grpNumeros.Controls.Add(lblNumero1);
            grpNumeros.Location = new Point(12, 37);
            grpNumeros.Name = "grpNumeros";
            grpNumeros.Size = new Size(318, 125);
            grpNumeros.TabIndex = 0;
            grpNumeros.TabStop = false;
            grpNumeros.Text = "inserte los numeros que desea calcular";
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(96, 81);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(125, 27);
            txtNum2.TabIndex = 3;
            txtNum2.TextChanged += txtNum2_TextChanged;
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(96, 34);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(125, 27);
            txtNum1.TabIndex = 2;
            txtNum1.TextChanged += txtNum1_TextChanged;
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Location = new Point(15, 81);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(75, 20);
            lblNumero2.TabIndex = 1;
            lblNumero2.Text = "Numero 2";
            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Location = new Point(15, 37);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(75, 20);
            lblNumero1.TabIndex = 0;
            lblNumero1.Text = "Numero 1";
            // 
            // grpOperacion
            // 
            grpOperacion.Controls.Add(radDivision);
            grpOperacion.Controls.Add(radMultiplicacion);
            grpOperacion.Controls.Add(radResta);
            grpOperacion.Controls.Add(radSuma);
            grpOperacion.Location = new Point(27, 188);
            grpOperacion.Name = "grpOperacion";
            grpOperacion.Size = new Size(250, 167);
            grpOperacion.TabIndex = 1;
            grpOperacion.TabStop = false;
            grpOperacion.Text = "Seleccione la operacion a realizar";
            // 
            // radDivision
            // 
            radDivision.AutoSize = true;
            radDivision.Location = new Point(15, 116);
            radDivision.Name = "radDivision";
            radDivision.Size = new Size(83, 24);
            radDivision.TabIndex = 5;
            radDivision.TabStop = true;
            radDivision.Text = "Division";
            radDivision.UseVisualStyleBackColor = true;
            // 
            // radMultiplicacion
            // 
            radMultiplicacion.AutoSize = true;
            radMultiplicacion.Location = new Point(15, 86);
            radMultiplicacion.Name = "radMultiplicacion";
            radMultiplicacion.Size = new Size(124, 24);
            radMultiplicacion.TabIndex = 4;
            radMultiplicacion.TabStop = true;
            radMultiplicacion.Text = "Multiplicacion";
            radMultiplicacion.UseVisualStyleBackColor = true;
            // 
            // radResta
            // 
            radResta.AutoSize = true;
            radResta.Location = new Point(15, 56);
            radResta.Name = "radResta";
            radResta.Size = new Size(66, 24);
            radResta.TabIndex = 3;
            radResta.TabStop = true;
            radResta.Text = "Resta";
            radResta.UseVisualStyleBackColor = true;
            // 
            // radSuma
            // 
            radSuma.AutoSize = true;
            radSuma.Location = new Point(15, 26);
            radSuma.Name = "radSuma";
            radSuma.Size = new Size(67, 24);
            radSuma.TabIndex = 2;
            radSuma.TabStop = true;
            radSuma.Text = "Suma";
            radSuma.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(352, 84);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(121, 89);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 450);
            Controls.Add(btnCalcular);
            Controls.Add(grpOperacion);
            Controls.Add(grpNumeros);
            Name = "Form1";
            Text = "Calculadora";
            grpNumeros.ResumeLayout(false);
            grpNumeros.PerformLayout();
            grpOperacion.ResumeLayout(false);
            grpOperacion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpNumeros;
        private TextBox txtNum2;
        private TextBox txtNum1;
        private Label lblNumero2;
        private Label lblNumero1;
        private GroupBox grpOperacion;
        private RadioButton radDivision;
        private RadioButton radMultiplicacion;
        private RadioButton radResta;
        private RadioButton radSuma;
        private Button btnCalcular;
    }
}
