namespace Proyecto_Lista_Promedio
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
            grpDatos = new GroupBox();
            txtSalario = new TextBox();
            txtNombre = new TextBox();
            lblSalario = new Label();
            lblNombre = new Label();
            dgEmpleado = new DataGridView();
            btnCalcular = new Button();
            btnInsertar = new Button();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgEmpleado).BeginInit();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(txtSalario);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(lblSalario);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Location = new Point(21, 57);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(250, 125);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos del empleado";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(95, 71);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(125, 27);
            txtSalario.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(95, 38);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 2;
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Location = new Point(28, 71);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(55, 20);
            lblSalario.TabIndex = 1;
            lblSalario.Text = "Salario";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(28, 41);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // dgEmpleado
            // 
            dgEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgEmpleado.Location = new Point(21, 220);
            dgEmpleado.Name = "dgEmpleado";
            dgEmpleado.RowHeadersWidth = 51;
            dgEmpleado.Size = new Size(421, 188);
            dgEmpleado.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(291, 33);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(151, 54);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular promedio de sueldos";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(291, 153);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(151, 61);
            btnInsertar.TabIndex = 3;
            btnInsertar.Text = "Insertar empleado a la lista";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 450);
            Controls.Add(btnInsertar);
            Controls.Add(btnCalcular);
            Controls.Add(dgEmpleado);
            Controls.Add(grpDatos);
            Name = "Form1";
            Text = "Empresa";
            Load += Form1_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgEmpleado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private TextBox txtSalario;
        private TextBox txtNombre;
        private Label lblSalario;
        private Label lblNombre;
        private DataGridView dgEmpleado;
        private Button btnCalcular;
        private Button btnInsertar;
    }
}
