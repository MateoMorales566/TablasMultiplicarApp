namespace TablasMultiplicarApp
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mostrarTablasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show(
                "¿Seguro que deseas salir?",
                "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (r == DialogResult.Yes)
                Application.Exit();
        }

        private void botonPractica_Click(object sender, EventArgs e)
        {

            var frm = new Practica();
            frm.FormClosed += (s, args) => this.Show();
            this.Hide();
            frm.Show();
        }

        private void botonLista_Click(object sender, EventArgs e)
        {
            var frm = new Tabla();
            frm.FormClosed += (s, args) => this.Show(); 
            this.Hide();
            frm.Show();
        }
    }
}
