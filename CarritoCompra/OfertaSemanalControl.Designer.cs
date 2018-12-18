namespace CarritoCompra
{
    partial class OfertaSemanalControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfertaSemanalControl));
            this.pictureHamburguesas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHamburguesas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureHamburguesas
            // 
            this.pictureHamburguesas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureHamburguesas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureHamburguesas.Image = ((System.Drawing.Image)(resources.GetObject("pictureHamburguesas.Image")));
            this.pictureHamburguesas.Location = new System.Drawing.Point(202, 43);
            this.pictureHamburguesas.Margin = new System.Windows.Forms.Padding(6);
            this.pictureHamburguesas.Name = "pictureHamburguesas";
            this.pictureHamburguesas.Size = new System.Drawing.Size(1358, 888);
            this.pictureHamburguesas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureHamburguesas.TabIndex = 15;
            this.pictureHamburguesas.TabStop = false;
            // 
            // OfertaSemanalControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureHamburguesas);
            this.Name = "OfertaSemanalControl";
            this.Size = new System.Drawing.Size(1772, 976);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHamburguesas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureHamburguesas;
    }
}
