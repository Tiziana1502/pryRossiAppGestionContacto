namespace pryRossiAppGestionContacto
{
    partial class frmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            lblContacto = new Label();
            lblNumero = new Label();
            btnAgendar = new Button();
            btnCancelar = new Button();
            mtbNumero = new MaskedTextBox();
            txtContacto = new TextBox();
            lstResultado = new ListBox();
            lblCantContacto = new Label();
            lblFecha = new Label();
            mtbContacto = new MaskedTextBox();
            mtbFecha = new MaskedTextBox();
            btnMostrar = new Button();
            lstDatos = new ListBox();
            SuspendLayout();
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI", 12F);
            lblContacto.Location = new Point(26, 43);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(92, 28);
            lblContacto.TabIndex = 0;
            lblContacto.Text = "Contacto";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 12F);
            lblNumero.Location = new Point(26, 97);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(84, 28);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "Número";
            // 
            // btnAgendar
            // 
            btnAgendar.BackColor = SystemColors.ActiveCaption;
            btnAgendar.Enabled = false;
            btnAgendar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnAgendar.ForeColor = SystemColors.ControlLightLight;
            btnAgendar.Location = new Point(151, 157);
            btnAgendar.Margin = new Padding(3, 4, 3, 4);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(98, 38);
            btnAgendar.TabIndex = 4;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = false;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ActiveCaption;
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(49, 157);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(98, 38);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // mtbNumero
            // 
            mtbNumero.Enabled = false;
            mtbNumero.Location = new Point(138, 104);
            mtbNumero.Margin = new Padding(3, 4, 3, 4);
            mtbNumero.Mask = "(999)000-0000";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(133, 27);
            mtbNumero.TabIndex = 3;
            mtbNumero.MaskInputRejected += mtbNumero_MaskInputRejected;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(138, 43);
            txtContacto.Margin = new Padding(3, 4, 3, 4);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(133, 27);
            txtContacto.TabIndex = 1;
            txtContacto.TextChanged += txtContacto_TextChanged;
            // 
            // lstResultado
            // 
            lstResultado.BackColor = SystemColors.ButtonFace;
            lstResultado.FormattingEnabled = true;
            lstResultado.Location = new Point(26, 221);
            lstResultado.Margin = new Padding(3, 4, 3, 4);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(265, 84);
            lstResultado.TabIndex = 5;
            // 
            // lblCantContacto
            // 
            lblCantContacto.AutoSize = true;
            lblCantContacto.Location = new Point(43, 332);
            lblCantContacto.Name = "lblCantContacto";
            lblCantContacto.Size = new Size(106, 20);
            lblCantContacto.TabIndex = 6;
            lblCantContacto.Text = "Cant Contacto:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(53, 375);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(98, 20);
            lblFecha.TabIndex = 8;
            lblFecha.Text = "Fecha y Hora:";
            // 
            // mtbContacto
            // 
            mtbContacto.Location = new Point(157, 329);
            mtbContacto.Margin = new Padding(3, 4, 3, 4);
            mtbContacto.Name = "mtbContacto";
            mtbContacto.Size = new Size(115, 27);
            mtbContacto.TabIndex = 7;
            // 
            // mtbFecha
            // 
            mtbFecha.Location = new Point(157, 375);
            mtbFecha.Margin = new Padding(3, 4, 3, 4);
            mtbFecha.Mask = "00/00/0000 00:00";
            mtbFecha.Name = "mtbFecha";
            mtbFecha.Size = new Size(115, 27);
            mtbFecha.TabIndex = 9;
            mtbFecha.ValidatingType = typeof(DateTime);
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = SystemColors.ActiveCaption;
            btnMostrar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnMostrar.ForeColor = SystemColors.ControlLightLight;
            btnMostrar.Location = new Point(153, 421);
            btnMostrar.Margin = new Padding(3, 4, 3, 4);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(96, 37);
            btnMostrar.TabIndex = 10;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lstDatos
            // 
            lstDatos.BackColor = SystemColors.ButtonFace;
            lstDatos.FormattingEnabled = true;
            lstDatos.Location = new Point(26, 479);
            lstDatos.Margin = new Padding(3, 4, 3, 4);
            lstDatos.Name = "lstDatos";
            lstDatos.Size = new Size(265, 84);
            lstDatos.TabIndex = 11;
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 576);
            Controls.Add(lstDatos);
            Controls.Add(btnMostrar);
            Controls.Add(mtbFecha);
            Controls.Add(mtbContacto);
            Controls.Add(lblFecha);
            Controls.Add(lblCantContacto);
            Controls.Add(lstResultado);
            Controls.Add(txtContacto);
            Controls.Add(mtbNumero);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgendar);
            Controls.Add(lblNumero);
            Controls.Add(lblContacto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmInicio";
            Text = "AGENDA CONTACTO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContacto;
        private Label lblNumero;
        private Button btnAgendar;
        private Button btnCancelar;
        private MaskedTextBox mtbNumero;
        private TextBox txtContacto;
        private ListBox lstResultado;
        private Label lblCantContacto;
        private Label lblFecha;
        private MaskedTextBox mtbContacto;
        private MaskedTextBox mtbFecha;
        private Button btnMostrar;
        private ListBox lstDatos;
    }
}
