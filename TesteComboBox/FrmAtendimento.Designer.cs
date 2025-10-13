namespace TesteComboBox
{
    partial class FrmAtendimento
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
            lblCodigoCliente = new Label();
            txtCodigoCliente = new TextBox();
            lblCliente = new Label();
            cbxClientes = new ComboBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // lblCodigoCliente
            // 
            lblCodigoCliente.AutoSize = true;
            lblCodigoCliente.Location = new Point(12, 9);
            lblCodigoCliente.Name = "lblCodigoCliente";
            lblCodigoCliente.Size = new Size(69, 15);
            lblCodigoCliente.TabIndex = 0;
            lblCodigoCliente.Text = "Cód.Cliente";
            // 
            // txtCodigoCliente
            // 
            txtCodigoCliente.Location = new Point(12, 27);
            txtCodigoCliente.Name = "txtCodigoCliente";
            txtCodigoCliente.Size = new Size(121, 23);
            txtCodigoCliente.TabIndex = 1;
            txtCodigoCliente.TextChanged += txtCodigoCliente_SelectedIndexChanged;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(148, 9);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(49, 15);
            lblCliente.TabIndex = 2;
            lblCliente.Text = "Clientes";
            // 
            // cbxClientes
            // 
            cbxClientes.FormattingEnabled = true;
            cbxClientes.Location = new Point(148, 27);
            cbxClientes.Name = "cbxClientes";
            cbxClientes.Size = new Size(409, 23);
            cbxClientes.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(573, 27);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(141, 23);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FrmAtendimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(cbxClientes);
            Controls.Add(lblCliente);
            Controls.Add(txtCodigoCliente);
            Controls.Add(lblCodigoCliente);
            Name = "FrmAtendimento";
            Text = "Atendimento";
            Load += FrmAtendimento_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigoCliente;
        private TextBox txtCodigoCliente;
        private Label lblCliente;
        private ComboBox cbxClientes;
        private Button btnSalvar;
    }
}
