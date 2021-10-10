
namespace Slc_Mercado
{
    partial class FAdmin
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
            this.tabla = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tablaDatos = new System.Windows.Forms.ComboBox();
            this.agregar = new System.Windows.Forms.Button();
            this.suprimir = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla
            // 
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Location = new System.Drawing.Point(20, 77);
            this.tabla.Margin = new System.Windows.Forms.Padding(2);
            this.tabla.Name = "tabla";
            this.tabla.RowHeadersWidth = 51;
            this.tabla.RowTemplate.Height = 29;
            this.tabla.Size = new System.Drawing.Size(1114, 512);
            this.tabla.TabIndex = 0;
            this.tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bienvenido usuario: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // tablaDatos
            // 
            this.tablaDatos.FormattingEnabled = true;
            this.tablaDatos.Items.AddRange(new object[] {
            "Tabla_Usuarios",
            "Tabla_Productos",
            "Tabla_Categorias",
            "Tabla_Compras"});
            this.tablaDatos.Location = new System.Drawing.Point(303, 38);
            this.tablaDatos.Name = "tablaDatos";
            this.tablaDatos.Size = new System.Drawing.Size(121, 21);
            this.tablaDatos.TabIndex = 4;
            this.tablaDatos.SelectedIndexChanged += new System.EventHandler(this.tablaDatosRefresh);
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(509, 38);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 5;
            this.agregar.Text = "Agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregarObj);
            // 
            // suprimir
            // 
            this.suprimir.Location = new System.Drawing.Point(605, 38);
            this.suprimir.Name = "suprimir";
            this.suprimir.Size = new System.Drawing.Size(75, 23);
            this.suprimir.TabIndex = 6;
            this.suprimir.Text = "Suprimir";
            this.suprimir.UseVisualStyleBackColor = true;
            this.suprimir.Click += new System.EventHandler(this.suprimirObj);
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(702, 38);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 7;
            this.modificar.Text = "Modificar";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificarObj);
            // 
            // FAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 600);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.suprimir);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.tablaDatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tablaDatos;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button suprimir;
        private System.Windows.Forms.Button modificar;
    }
}