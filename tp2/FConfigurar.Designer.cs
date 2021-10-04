
namespace Slc_Mercado
{
    partial class FConfigurar
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
            this.label1 = new System.Windows.Forms.Label();
            this.seleccionar = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            this.ruta = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la ruta indicada para guardar los archivos";
            // 
            // seleccionar
            // 
            this.seleccionar.Location = new System.Drawing.Point(340, 66);
            this.seleccionar.Name = "seleccionar";
            this.seleccionar.Size = new System.Drawing.Size(75, 23);
            this.seleccionar.TabIndex = 1;
            this.seleccionar.Text = "Seleccionar";
            this.seleccionar.UseVisualStyleBackColor = true;
            this.seleccionar.Click += new System.EventHandler(this.seleccionar_Click);
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(140, 151);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(138, 46);
            this.volver.TabIndex = 2;
            this.volver.Text = "Volver atrás";
            this.volver.UseVisualStyleBackColor = true;
            // 
            // ruta
            // 
            this.ruta.Location = new System.Drawing.Point(24, 68);
            this.ruta.Name = "ruta";
            /// ESTOY HAY QUE ARREGLARLO
            this.ruta.Text = "";
            this.ruta.Size = new System.Drawing.Size(285, 20);
            this.ruta.TabIndex = 3;
            // 
            // FConfigurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 268);
            this.Controls.Add(this.ruta);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.seleccionar);
            this.Controls.Add(this.label1);
            this.Name = "FConfigurar";
            this.Text = "FConfigurar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.Button seleccionar;
        private System.Windows.Forms.TextBox ruta;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}