namespace Practica_tercer_trimestre
{
    partial class AñadirClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bAñadirCliente = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bAñadirCliente
            // 
            this.bAñadirCliente.Location = new System.Drawing.Point(530, 78);
            this.bAñadirCliente.Name = "bAñadirCliente";
            this.bAñadirCliente.Size = new System.Drawing.Size(124, 68);
            this.bAñadirCliente.TabIndex = 0;
            this.bAñadirCliente.Text = "AÑADIR";
            this.bAñadirCliente.UseVisualStyleBackColor = true;
            this.bAñadirCliente.Click += new System.EventHandler(this.bAñadirCliente_Click);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(210, 101);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 22);
            this.textNombre.TabIndex = 1;
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(210, 202);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(100, 22);
            this.textTelefono.TabIndex = 2;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(210, 260);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(100, 22);
            this.textEmail.TabIndex = 3;
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(210, 148);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(100, 22);
            this.textDireccion.TabIndex = 4;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(99, 101);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 17);
            this.labelNombre.TabIndex = 5;
            this.labelNombre.Text = "Nombre";
            // 
            // Direccion
            // 
            this.Direccion.AutoSize = true;
            this.Direccion.Location = new System.Drawing.Point(99, 151);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(67, 17);
            this.Direccion.TabIndex = 6;
            this.Direccion.Text = "Direccion";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(99, 263);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(42, 17);
            this.Email.TabIndex = 8;
            this.Email.Text = "Email";
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Location = new System.Drawing.Point(99, 205);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(64, 17);
            this.Telefono.TabIndex = 7;
            this.Telefono.Text = "Telefono";
            // 
            // AñadirClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.bAñadirCliente);
            this.Name = "AñadirClientes";
            this.Text = "AñadirClientes";
            this.Load += new System.EventHandler(this.AñadirClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAñadirCliente;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label Direccion;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Telefono;
    }
}