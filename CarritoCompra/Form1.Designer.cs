namespace CarritoCompra
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelSeccion = new System.Windows.Forms.Label();
            this.ofertaSemanalControl1 = new CarritoCompra.OfertaSemanalControl();
            this.menusControl1 = new CarritoCompra.MenusControl();
            this.postresControl1 = new CarritoCompra.PostresControl();
            this.complementosControl1 = new CarritoCompra.ComplementosControl();
            this.bebidasControl1 = new CarritoCompra.BebidasControl();
            this.hamburguesasControl1 = new CarritoCompra.HamburguesasControl();
            this.menuPrincipalControl1 = new CarritoCompra.MenuPrincipalControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 1177);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.labelSeccion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(330, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1746, 192);
            this.panel2.TabIndex = 1;
            // 
            // labelSeccion
            // 
            this.labelSeccion.AutoSize = true;
            this.labelSeccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeccion.Location = new System.Drawing.Point(55, 64);
            this.labelSeccion.Name = "labelSeccion";
            this.labelSeccion.Size = new System.Drawing.Size(336, 55);
            this.labelSeccion.TabIndex = 0;
            this.labelSeccion.Text = "Menú principal";
            // 
            // ofertaSemanalControl1
            // 
            this.ofertaSemanalControl1.Location = new System.Drawing.Point(330, 192);
            this.ofertaSemanalControl1.Name = "ofertaSemanalControl1";
            this.ofertaSemanalControl1.Size = new System.Drawing.Size(1746, 976);
            this.ofertaSemanalControl1.TabIndex = 8;
            // 
            // menusControl1
            // 
            this.menusControl1.Location = new System.Drawing.Point(330, 192);
            this.menusControl1.Name = "menusControl1";
            this.menusControl1.Size = new System.Drawing.Size(1746, 985);
            this.menusControl1.TabIndex = 7;
            // 
            // postresControl1
            // 
            this.postresControl1.Location = new System.Drawing.Point(330, 192);
            this.postresControl1.Name = "postresControl1";
            this.postresControl1.Size = new System.Drawing.Size(1746, 982);
            this.postresControl1.TabIndex = 6;
            // 
            // complementosControl1
            // 
            this.complementosControl1.Location = new System.Drawing.Point(330, 192);
            this.complementosControl1.Name = "complementosControl1";
            this.complementosControl1.Size = new System.Drawing.Size(1746, 985);
            this.complementosControl1.TabIndex = 5;
            // 
            // bebidasControl1
            // 
            this.bebidasControl1.Location = new System.Drawing.Point(330, 192);
            this.bebidasControl1.Name = "bebidasControl1";
            this.bebidasControl1.Size = new System.Drawing.Size(1743, 982);
            this.bebidasControl1.TabIndex = 4;
            // 
            // hamburguesasControl1
            // 
            this.hamburguesasControl1.Location = new System.Drawing.Point(330, 192);
            this.hamburguesasControl1.Name = "hamburguesasControl1";
            this.hamburguesasControl1.Size = new System.Drawing.Size(1743, 982);
            this.hamburguesasControl1.TabIndex = 3;
            // 
            // menuPrincipalControl1
            // 
            this.menuPrincipalControl1.Location = new System.Drawing.Point(330, 192);
            this.menuPrincipalControl1.Name = "menuPrincipalControl1";
            this.menuPrincipalControl1.Size = new System.Drawing.Size(1746, 985);
            this.menuPrincipalControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2076, 1177);
            this.Controls.Add(this.ofertaSemanalControl1);
            this.Controls.Add(this.menusControl1);
            this.Controls.Add(this.postresControl1);
            this.Controls.Add(this.complementosControl1);
            this.Controls.Add(this.bebidasControl1);
            this.Controls.Add(this.hamburguesasControl1);
            this.Controls.Add(this.menuPrincipalControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private MenuPrincipalControl menuPrincipalControl1;
        private System.Windows.Forms.Label labelSeccion;
        private HamburguesasControl hamburguesasControl1;
        private BebidasControl bebidasControl1;
        private ComplementosControl complementosControl1;
        private PostresControl postresControl1;
        private MenusControl menusControl1;
        private OfertaSemanalControl ofertaSemanalControl1;
    }
}

