namespace ProyectoCarro
{
    public partial class Form1 : Form
    {
        Carro miCarro = new Carro();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            miCarro = new Carro();
            miCarro.Marca = txtMarca.Text;
            miCarro.Modelo = txtModelo.Text;
            miCarro.Velocidad = double.Parse(txtVelocidad.Text);    
            MessageBox.Show(miCarro.Acelerar());
        }

        private void btnFrenar_Click(object sender, EventArgs e)
        {
            miCarro = new Carro();
            miCarro.Marca = txtMarca.Text;
            miCarro.Modelo = txtModelo.Text;
            miCarro.Velocidad = double.Parse(txtVelocidad.Text);
            MessageBox.Show(miCarro.Frenar());
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            miCarro = new Carro();
            miCarro.Marca = txtMarca.Text;
            miCarro.Modelo = txtModelo.Text;
            miCarro.Velocidad = double.Parse(txtVelocidad.Text);
            MessageBox.Show(miCarro.ToString());
        }
    }
}
