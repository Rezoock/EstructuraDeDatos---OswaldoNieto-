namespace ProyectoCalculadora
{


    public partial class Form1 : Form
    {
        Calculadora miCalculadora = new Calculadora();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            miCalculadora = new Calculadora();
            miCalculadora.Numero1 = double.Parse(txtNum1.Text);
            miCalculadora.Numero2 = double.Parse(txtNum2.Text);
            if (radSuma.Checked )
            {
               double resultado = miCalculadora.CalcularSuma();
               MessageBox.Show("El resultado de la suma es: " + resultado.ToString());
            }
            if (radResta.Checked)
            {
                double resultado = miCalculadora.CalcularResta();
                MessageBox.Show("El resultado de la resta es: " + resultado.ToString());
            }
            if (radMultiplicacion.Checked)
            {
                double resultado = miCalculadora.CalcularMultiplicacion();
                MessageBox.Show("El resultado de la multiplicacion es: " + resultado.ToString());
            }
            if (radDivision.Checked)
            {
                try
                {
                    double resultado = miCalculadora.CalcularDivision();
                    MessageBox.Show("El resultado de la division es: " + resultado.ToString());
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
