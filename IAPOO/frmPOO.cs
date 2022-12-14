using Missatges;
using System.Windows.Forms;

namespace PCBRecuperacio
{
    public partial class frmPOO : Form
    {
        public frmPOO()
        {
            InitializeComponent();
        }
        private void btnHolaOriginal_Click(object sender, System.EventArgs e)
        {
            MensajeHeredado saludosHeredado = new MensajeHeredado();
            string mensaje = saludosHeredado.salutacio();
            MessageBox.Show(mensaje);
        }

        private void btnHola1_Click(object sender, System.EventArgs e)
        {
            MensajeHeredado saludosHeredado = new MensajeHeredado();
            string mensaje = saludosHeredado.salutacioAmbNom(txtNom.Text);
            MessageBox.Show(mensaje);
        }

        private void btnHola2_Click(object sender, System.EventArgs e)
        {
            MensajeHeredado saludosHeredado = new MensajeHeredado();
            string mensaje = saludosHeredado.salutacioAmbNomiBandol(txtNom.Text, cmbBandol.Text);
            MessageBox.Show(mensaje);
        }

        //private void btnHola2_Click(object sender, System.EventArgs e)
        //{
        //    MensajeHeredado saludosHeredado = new MensajeHeredado();
        //    string mensaje = saludosHeredado.salutacio(txtNom.Text + " del grupo de los " + cmbBandol.Text);
        //    string txtNombre = txtNom.Text;
        //    string bando = cmbBandol.Text;
        //    MessageBox.Show(mensaje + " " + txtNombre + " del grupo de los " + bando + ".");
        //}

        private void btnAdeuOriginal_Click(object sender, System.EventArgs e)
        {
            MensajeHeredado despedida = new MensajeHeredado();
            string texto = despedida.comiatCatala();
            MessageBox.Show(texto);
        }

        private void btnAdeu1_Click(object sender, System.EventArgs e)
        {
            MensajeHeredado bye = new MensajeHeredado();
            string text = bye.comiat();
            MessageBox.Show(text);
        }
    }
}
