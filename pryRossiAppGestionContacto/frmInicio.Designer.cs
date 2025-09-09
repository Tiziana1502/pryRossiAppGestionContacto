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
            SuspendLayout();
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI", 12F);
            lblContacto.Location = new Point(23, 32);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(72, 21);
            lblContacto.TabIndex = 0;
            lblContacto.Text = "Contacto";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 12F);
            lblNumero.Location = new Point(23, 73);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(68, 21);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "Número";
            // 
            // btnAgendar
            // 
            btnAgendar.BackColor = SystemColors.ActiveCaption;
            btnAgendar.Enabled = false;
            btnAgendar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgendar.ForeColor = SystemColors.ControlLightLight;
            btnAgendar.Location = new Point(132, 129);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(92, 40);
            btnAgendar.TabIndex = 4;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = false;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.ActiveCaption;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(34, 129);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(92, 40);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // mtbNumero
            // 
            mtbNumero.Enabled = false;
            mtbNumero.Location = new Point(121, 78);
            mtbNumero.Mask = "(999)000-0000";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(117, 23);
            mtbNumero.TabIndex = 3;
            mtbNumero.MaskInputRejected += mtbNumero_MaskInputRejected;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(121, 32);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(117, 23);
            txtContacto.TabIndex = 1;
            txtContacto.TextChanged += txtContacto_TextChanged;
            // 
            // lstResultado
            // 
            lstResultado.BackColor = SystemColors.ButtonFace;
            lstResultado.FormattingEnabled = true;
            lstResultado.ItemHeight = 15;
            lstResultado.Location = new Point(6, 186);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(232, 64);
            lstResultado.TabIndex = 5;
            // 
            // lblCantContacto
            // 
            lblCantContacto.AutoSize = true;
            lblCantContacto.Location = new Point(12, 264);
            lblCantContacto.Name = "lblCantContacto";
            lblCantContacto.Size = new Size(87, 15);
            lblCantContacto.TabIndex = 6;
            lblCantContacto.Text = "Cant Contacto:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(20, 296);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(79, 15);
            lblFecha.TabIndex = 8;
            lblFecha.Text = "Fecha y Hora:";
            // 
            // mtbContacto
            // 
            mtbContacto.Location = new Point(111, 262);
            mtbContacto.Name = "mtbContacto";
            mtbContacto.Size = new Size(101, 23);
            mtbContacto.TabIndex = 7;
            // 
            // mtbFecha
            // 
            mtbFecha.Location = new Point(111, 296);
            mtbFecha.Mask = "00/00/0000 00:00";
            mtbFecha.Name = "mtbFecha";
            mtbFecha.Size = new Size(101, 23);
            mtbFecha.TabIndex = 9;
            mtbFecha.ValidatingType = typeof(DateTime);
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 329);
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
    }
}
