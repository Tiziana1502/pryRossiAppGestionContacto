namespace pryRossiAppGestionContacto
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        private void txtContacto_TextChanged(object sender, EventArgs e)
        {
            if (txtContacto.Text != "")
            {
                mtbNumero.Enabled = true;
            }
            else
            {
                mtbNumero.Enabled = false;
            }
        }

        private void mtbNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbNumero.Text != "")
            {
                btnAgendar.Enabled = true;
            }
            else
            {
                btnAgendar.Enabled = false;
            }
        }

        string vContacto = "";
        string vNumero = "";

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            vContacto = txtContacto.Text;
            vNumero = mtbNumero.Text;

            lstResultado.Items.Add("Contacto: " + vContacto
                + " Número:" + vNumero);

            //limpiar controles
            txtContacto.Text = "";
            mtbNumero.Text = "";
        }

        int vContador = 0;

        private void mtbContacto_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (txtContacto.Text != "")
            {
                vContador = vContador + 1;          
                mtbContacto.Text = vContador;
            }
        }
    }
}
