namespace ProyectoCarro
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
            lblMarca = new Label();
            lblModelo = new Label();
            lblVelocidad = new Label();
            txtMarca = new TextBox();
            txtModelo = new TextBox();
            txtVelocidad = new TextBox();
            btnAcelerar = new Button();
            btnFrenar = new Button();
            btnMostrar = new Button();
            SuspendLayout();
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(84, 88);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(50, 20);
            lblMarca.TabIndex = 0;
            lblMarca.Text = "Marca";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(75, 132);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(61, 20);
            lblModelo.TabIndex = 1;
            lblModelo.Text = "Modelo";
            // 
            // lblVelocidad
            // 
            lblVelocidad.AutoSize = true;
            lblVelocidad.Location = new Point(57, 176);
            lblVelocidad.Name = "lblVelocidad";
            lblVelocidad.Size = new Size(75, 20);
            lblVelocidad.TabIndex = 2;
            lblVelocidad.Text = "Velocidad";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(140, 88);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(125, 27);
            txtMarca.TabIndex = 3;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(142, 132);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(125, 27);
            txtModelo.TabIndex = 4;
            // 
            // txtVelocidad
            // 
            txtVelocidad.Location = new Point(140, 176);
            txtVelocidad.Name = "txtVelocidad";
            txtVelocidad.Size = new Size(125, 27);
            txtVelocidad.TabIndex = 5;
            // 
            // btnAcelerar
            // 
            btnAcelerar.Location = new Point(57, 268);
            btnAcelerar.Name = "btnAcelerar";
            btnAcelerar.Size = new Size(94, 42);
            btnAcelerar.TabIndex = 6;
            btnAcelerar.Text = "Acelerar";
            btnAcelerar.UseVisualStyleBackColor = true;
            btnAcelerar.Click += btnAcelerar_Click;
            // 
            // btnFrenar
            // 
            btnFrenar.Location = new Point(230, 268);
            btnFrenar.Name = "btnFrenar";
            btnFrenar.Size = new Size(94, 42);
            btnFrenar.TabIndex = 7;
            btnFrenar.Text = "Frenar";
            btnFrenar.UseVisualStyleBackColor = true;
            btnFrenar.Click += btnFrenar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(57, 366);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(284, 60);
            btnMostrar.TabIndex = 8;
            btnMostrar.Text = "Mostrar Informacion";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 450);
            Controls.Add(btnMostrar);
            Controls.Add(btnFrenar);
            Controls.Add(btnAcelerar);
            Controls.Add(txtVelocidad);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(lblVelocidad);
            Controls.Add(lblModelo);
            Controls.Add(lblMarca);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMarca;
        private Label lblModelo;
        private Label lblVelocidad;
        private TextBox txtMarca;
        private TextBox txtModelo;
        private TextBox txtVelocidad;
        private Button btnAcelerar;
        private Button btnFrenar;
        private Button btnMostrar;
    }
}
