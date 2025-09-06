namespace ProyectoLibro
{
    public partial class Form1 : Form
    {
        Libro miLibro;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            miLibro = new Libro();
            miLibro.Titulo = txtTitulo.Text;
            miLibro.Autor = txtAutor.Text;
            MessageBox.Show(miLibro.ToString());

        }
    }
}
