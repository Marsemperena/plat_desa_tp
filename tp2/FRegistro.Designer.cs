
namespace Plataforma_TP2
{
    partial class FRegistro
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.mail = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.tipoUsuario = new System.Windows.Forms.ComboBox();
            this.registrarUsuario = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            this.cuil_cuit = new System.Windows.Forms.TextBox();
            this.lblCuil_cuit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(43, 37);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(100, 23);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Registro de Usuario";
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(43, 100);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 23);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.Location = new System.Drawing.Point(43, 163);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(100, 23);
            this.lblApellido.TabIndex = 10;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDNI
            // 
            this.lblDNI.Location = new System.Drawing.Point(43, 225);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(217, 23);
            this.lblDNI.TabIndex = 9;
            this.lblDNI.Text = "DNI";
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.Location = new System.Drawing.Point(308, 163);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(206, 23);
            this.lblTipoUsuario.TabIndex = 8;
            this.lblTipoUsuario.Text = "Seleccione el tipo de usuario:";
            // 
            // lblPwd
            // 
            this.lblPwd.Location = new System.Drawing.Point(308, 222);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(308, 23);
            this.lblPwd.TabIndex = 7;
            this.lblPwd.Text = "Ingrese la contraseña";
            // 
            // lblMail
            // 
            this.lblMail.Location = new System.Drawing.Point(214, 404);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(100, 23);
            this.lblMail.TabIndex = 5;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(498, 222);
            this.nombre.Margin = new System.Windows.Forms.Padding(2);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 0;
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(127, 222);
            this.apellido.Margin = new System.Windows.Forms.Padding(2);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(100, 20);
            this.apellido.TabIndex = 0;
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(127, 97);
            this.mail.Margin = new System.Windows.Forms.Padding(2);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(100, 20);
            this.mail.TabIndex = 0;
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(127, 159);
            this.pwd.Margin = new System.Windows.Forms.Padding(2);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(100, 20);
            this.pwd.TabIndex = 0;
            // 
            // tipoUsuario
            // 
            this.tipoUsuario.Items.AddRange(new object[] {
            "Cliente Final",
            "Empresa"});
            this.tipoUsuario.Location = new System.Drawing.Point(498, 159);
            this.tipoUsuario.Name = "tipoUsuario";
            this.tipoUsuario.Size = new System.Drawing.Size(100, 21);
            this.tipoUsuario.TabIndex = 4;
            // 
            // registrarUsuario
            // 
            this.registrarUsuario.Location = new System.Drawing.Point(535, 314);
            this.registrarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.registrarUsuario.Name = "registrarUsuario";
            this.registrarUsuario.Size = new System.Drawing.Size(95, 40);
            this.registrarUsuario.TabIndex = 3;
            this.registrarUsuario.Text = "Registrar Usuario";
            this.registrarUsuario.UseVisualStyleBackColor = true;
            this.registrarUsuario.Click += new System.EventHandler(this.registrarUsuario_Click);
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(419, 314);
            this.volver.Margin = new System.Windows.Forms.Padding(2);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(95, 40);
            this.volver.TabIndex = 3;
            this.volver.Text = "Volver Atrás";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // cuil_cuit
            // 
            this.cuil_cuit.Location = new System.Drawing.Point(498, 97);
            this.cuil_cuit.Margin = new System.Windows.Forms.Padding(2);
            this.cuil_cuit.Name = "cuil_cuit";
            this.cuil_cuit.Size = new System.Drawing.Size(100, 20);
            this.cuil_cuit.TabIndex = 14;
            // 
            // lblCuil_cuit
            // 
            this.lblCuil_cuit.Location = new System.Drawing.Point(308, 100);
            this.lblCuil_cuit.Name = "lblCuil_cuit";
            this.lblCuil_cuit.Size = new System.Drawing.Size(140, 23);
            this.lblCuil_cuit.TabIndex = 15;
            this.lblCuil_cuit.Text = "Ingrese el CUIT/CUIL";
            // 
            // FRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 453);
            this.Controls.Add(this.lblCuil_cuit);
            this.Controls.Add(this.cuil_cuit);
            this.Controls.Add(this.registrarUsuario);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.tipoUsuario);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.apellido);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRegistro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRegistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button registrarUsuario;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.ComboBox tipoUsuario;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox cuil_cuit;
        private System.Windows.Forms.Label lblCuil_cuit;
    }
}