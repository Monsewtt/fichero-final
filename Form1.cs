namespace Fichero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btngenerardocumento_Click(object sender, EventArgs e)
        {
            string texto1 = txtnombre.Text.Trim();
            string texto2 = txtapellidopaterno.Text.Trim();
            string texto3 = txtapellidomaterno.Text.Trim();

            string contenido = texto1 + Environment.NewLine + Environment.NewLine +
                               texto2 + Environment.NewLine + Environment.NewLine +
                               texto3;

            try
            {
                File.WriteAllText("FicheroFinal.txt", contenido);
                MessageBox.Show("Se guardó correctamente el archivo como 'FicheroFinal.txt'", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar el archivo:\n" + ex.Message, "Error");
            }
        }
    }
}
