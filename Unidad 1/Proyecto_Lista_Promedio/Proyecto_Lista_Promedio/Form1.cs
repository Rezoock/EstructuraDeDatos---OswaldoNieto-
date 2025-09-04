namespace Proyecto_Lista_Promedio
{
    public partial class Form1 : Form
    {
       Empleado administrador = new Empleado();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgEmpleado.Columns.Add("Nombre", "Nombre");
            dgEmpleado.Columns.Add("Sueldo", "Sueldo");
            dgEmpleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            

        }
        private void MostrarDatos()
        {
            int intRenglon = 0;


            dgEmpleado.Rows.Clear();

            foreach (Empleado unEmpleado in administrador.ListaEmpleados)
            {
                intRenglon = (dgEmpleado.Rows.Count - 1 > 0) ? dgEmpleado.Rows.Count - 1 : 0;
                dgEmpleado.Rows.Add(1);
                dgEmpleado.Rows[intRenglon].Cells[0].Value = unEmpleado.Nombre;
                dgEmpleado.Rows[intRenglon].Cells[1].Value = unEmpleado.Salario;


            }

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            
            Empleado miEmpleado = new Empleado();
            {
                miEmpleado.Nombre = txtNombre.Text;
                miEmpleado.Salario = double.Parse(txtSalario.Text);
                
            }
            administrador.InsertarEmpleado(miEmpleado);
            MessageBox.Show("Empleado agregado ");
            MostrarDatos();

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
           double Resultado = administrador.PromedioDeSueldoDeEmpleados();
            MessageBox.Show("El promedio de sueldos es: " + Resultado.ToString());
        }
    }
}
