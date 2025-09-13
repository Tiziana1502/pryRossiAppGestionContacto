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
        int indice = 0;

        //VECTORES
        string[] vecTelefono = new string[5];
        string[] vecContacto = new string[5];


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
            if (mtbNumero.Text == "")
            {
                btnAgendar.Enabled = false;
            }
            else
            {
                btnAgendar.Enabled = true;
            }
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            vecContacto[indice] = mtbContacto.Text;
            vecTelefono[indice] = mtbNumero.Text;
            vContacto = txtContacto.Text;
            vNumero = mtbNumero.Text;

            lstResultado.Items.Add("Contacto: " + vContacto
                + " Número:" + vNumero);


            //Mostrar resultados usando un contador que acumula
            vContador = vContador + 1;
            mtbContacto.Text = Convert.ToString(vContador);
            mtbFecha.Text = Convert.ToString(vFecha);

            //limpiar controles
            txtContacto.Text = "";
            mtbNumero.Text = "";

            indice++;
            txtContacto.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtContacto.Text = "";
            mtbNumero.Text = "";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            indice = 0;
            while (indice < 5)
            {
                if (vecContacto[indice] != null)
                {
                    lstDatos.Items.Add(vecContacto[indice] + " | " + vecTelefono[indice]);
                }
                indice++;
            }
            for (int indice = 0; indice < 5; indice++)
            {
                vecContacto[indice] = null;
                vecTelefono[indice] = null;
            }
        }
      
    }
}
