
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
            this.pass = new System.Windows.Forms.TextBox();
            this.dni_ = new System.Windows.Forms.TextBox();
            this.nombre_ = new System.Windows.Forms.TextBox();
            this.apellido_ = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.TextBox();
            this.tipoUsuario = new System.Windows.Forms.ComboBox();
            this.registrarUsuario = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            this.mail_ = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(100, 23);
            this.lblTitulo.TabIndex = 13;
            this.lblTitulo.Text = "Registro de Usuario";
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(43, 115);
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
            this.lblDNI.Location = new System.Drawing.Point(45, 261);
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
            this.lblPwd.Location = new System.Drawing.Point(311, 212);
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
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(498, 209);
            this.pass.Margin = new System.Windows.Forms.Padding(2);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(100, 20);
            this.pass.TabIndex = 0;
            // 
            // dni_
            // 
            this.dni_.Location = new System.Drawing.Point(127, 258);
            this.dni_.Margin = new System.Windows.Forms.Padding(2);
            this.dni_.Name = "dni_";
            this.dni_.Size = new System.Drawing.Size(100, 20);
            this.dni_.TabIndex = 0;
            // 
            // nombre_
            // 
            this.nombre_.Location = new System.Drawing.Point(127, 112);
            this.nombre_.Margin = new System.Windows.Forms.Padding(2);
            this.nombre_.Name = "nombre_";
            this.nombre_.Size = new System.Drawing.Size(100, 20);
            this.nombre_.TabIndex = 0;
            this.nombre_.TextChanged += new System.EventHandler(this.mail_TextChanged);
            // 
            // apellido_
            // 
            this.apellido_.Location = new System.Drawing.Point(127, 160);
            this.apellido_.Margin = new System.Windows.Forms.Padding(2);
            this.apellido_.Name = "apellido_";
            this.apellido_.Size = new System.Drawing.Size(100, 20);
            this.apellido_.TabIndex = 0;
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(127, 112);
            this.dni.Margin = new System.Windows.Forms.Padding(2);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(100, 20);
            this.dni.TabIndex = 0;
            // 
            // tipoUsuario
            // 
            this.tipoUsuario.Items.AddRange(new object[] {
            "Cliente Final",
            "Empresa"});
            this.tipoUsuario.Location = new System.Drawing.Point(498, 159);
            this.tipoUsuario.Name = "tipoUsuario";
            this.tipoUsuario.Size = new System.Drawing.Size(121, 21);
            this.tipoUsuario.TabIndex = 4;
            this.tipoUsuario.SelectedIndexChanged += new System.EventHandler(this.tipoUsuario_SelectedIndexChanged);
            // 
            // registrarUsuario
            // 
            this.registrarUsuario.Location = new System.Drawing.Point(536, 374);
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
            this.volver.Location = new System.Drawing.Point(419, 374);
            this.volver.Margin = new System.Windows.Forms.Padding(2);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(95, 40);
            this.volver.TabIndex = 3;
            this.volver.Text = "Volver Atrás";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // mail_
            // 
            this.mail_.Location = new System.Drawing.Point(354, 112);
            this.mail_.Margin = new System.Windows.Forms.Padding(2);
            this.mail_.Name = "mail_";
            this.mail_.Size = new System.Drawing.Size(100, 20);
            this.mail_.TabIndex = 14;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(354, 112);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(270, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mail";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 453);
            this.Controls.Add(this.mail_);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registrarUsuario);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.tipoUsuario);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.dni_);
            this.Controls.Add(this.nombre_);
            this.Controls.Add(this.apellido_);
            this.Controls.Add(this.dni);
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
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox dni_;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.TextBox nombre_;
        private System.Windows.Forms.TextBox apellido_;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox mail_;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}