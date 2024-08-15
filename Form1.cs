using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            string Nombre = TextNombre.Text.Trim();
            string Email = TextCorreo.Text.Trim();
            string Mensaje = TextTelefono.Text.Trim();

            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Mensaje))
            {
                LabelConfirmacion.Text = "Por favor complete los campos.";
            }
            else
            {

                LabelConfirmacion.Text = "Formulario enviado correctamente.";


            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            TextNombre.Clear();
            TextCorreo.Clear();
            TextTelefono.Clear();
        }

   
    }
}
