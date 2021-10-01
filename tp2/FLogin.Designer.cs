
namespace Plataforma_TP2
{
    partial class FLogin
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
            this.login = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.pwd = new System.Windows.Forms.TextBox();
            this.registro = new System.Windows.Forms.Button();
            this.configurar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(179, 311);
            this.login.Margin = new System.Windows.Forms.Padding(2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(95, 40);
            this.login.TabIndex = 0;
            this.login.Text = "Iniciar Sesion";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(321, 256);
            this.username.Margin = new System.Windows.Forms.Padding(2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(95, 20);
            this.username.TabIndex = 1;
            // 
            // pwd
            // 
            this.pwd.Location = new System.Drawing.Point(321, 197);
            this.pwd.Margin = new System.Windows.Forms.Padding(2);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(95, 20);
            this.pwd.TabIndex = 2;
            // 
            // registro
            // 
            this.registro.Location = new System.Drawing.Point(321, 311);
            this.registro.Margin = new System.Windows.Forms.Padding(2);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(95, 40);
            this.registro.TabIndex = 3;
            this.registro.Text = "Registrarse";
            this.registro.UseVisualStyleBackColor = true;
            this.registro.Click += new System.EventHandler(this.registro_Click);
            // 
            // configurar
            // 
            this.configurar.Location = new System.Drawing.Point(461, 311);
            this.configurar.Margin = new System.Windows.Forms.Padding(2);
            this.configurar.Name = "configurar";
            this.configurar.Size = new System.Drawing.Size(95, 40);
            this.configurar.TabIndex = 4;
            this.configurar.Text = "Configurar";
            this.configurar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(318, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese usuario (n° DNI)";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(318, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingrese contraseña";
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.configurar);
            this.Controls.Add(this.registro);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.username);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox pwd;
        private System.Windows.Forms.Button registro;
        private System.Windows.Forms.Button configurar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}