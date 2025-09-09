namespace pryRossiAppGestionContacto
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        //Definición de variables globales
        string vContacto = "";
        string vNumero = "";
        int vContador = 0;
        DateTime vFecha = DateTime.Now;

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

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            vContacto = txtContacto.Text;
            vNumero = mtbNumero.Text;

            lstResultado.Items.Add("Contacto: " + vContacto
                + " Número:" + vNumero);

            //limpiar controles
            txtContacto.Text = "";
            mtbNumero.Text = "";

            //Mostrar resultados usando un contador que acumula
            vContador = vContador + 1;
            mtbContacto.Text = ("Cantidad de Contactos" + vContador);
            mtbFecha.Text = ("Fecha y Hora" + vFecha);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtContacto.Text = "";
            mtbNumero.Text = "";
        }
    }
}
