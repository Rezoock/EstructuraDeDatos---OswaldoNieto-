namespace ProyectoLibro
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
            lblTitulo = new Label();
            lblAutor = new Label();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            btnMostrar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(77, 49);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(47, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(77, 101);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(46, 20);
            lblAutor.TabIndex = 1;
            lblAutor.Text = "Autor";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(133, 46);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(125, 27);
            txtTitulo.TabIndex = 2;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(133, 101);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(125, 27);
            txtAutor.TabIndex = 3;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(67, 154);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(209, 58);
            btnMostrar.TabIndex = 4;
            btnMostrar.Text = "Mostrar Informacion";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 237);
            Controls.Add(btnMostrar);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(lblAutor);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblAutor;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private Button btnMostrar;
    }
}
