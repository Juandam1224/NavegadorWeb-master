namespace WebApp
{
    partial class WebApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebApp));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRetroceder = new System.Windows.Forms.ToolStripButton();
            this.btnAvanzar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.btnHome = new System.Windows.Forms.ToolStripButton();
            this.txtURL = new System.Windows.Forms.ToolStripTextBox();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.cboFavoritos = new System.Windows.Forms.ToolStripComboBox();
            this.btnFavoritos = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRetroceder,
            this.btnAvanzar,
            this.btnActualizar,
            this.btnHome,
            this.txtURL,
            this.btnBuscar,
            this.cboFavoritos,
            this.btnFavoritos});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(895, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRetroceder.Image = ((System.Drawing.Image)(resources.GetObject("btnRetroceder.Image")));
            this.btnRetroceder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(23, 22);
            this.btnRetroceder.Text = "Retroceder";
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAvanzar.Image = ((System.Drawing.Image)(resources.GetObject("btnAvanzar.Image")));
            this.btnAvanzar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(23, 22);
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(23, 22);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnHome
            // 
            this.btnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(23, 22);
            this.btnHome.Text = "Home";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // txtURL
            // 
            this.txtURL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(600, 25);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(23, 22);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cboFavoritos
            // 
            this.cboFavoritos.Name = "cboFavoritos";
            this.cboFavoritos.Size = new System.Drawing.Size(121, 25);
            this.cboFavoritos.SelectedIndexChanged += new System.EventHandler(this.cboFavoritos_SelectedIndexChanged);
            // 
            // btnFavoritos
            // 
            this.btnFavoritos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFavoritos.Image = ((System.Drawing.Image)(resources.GetObject("btnFavoritos.Image")));
            this.btnFavoritos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFavoritos.Name = "btnFavoritos";
            this.btnFavoritos.Size = new System.Drawing.Size(23, 22);
            this.btnFavoritos.Text = "Favoritos";
            this.btnFavoritos.Click += new System.EventHandler(this.btnFavoritos_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 25);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(895, 469);
            this.webBrowser1.TabIndex = 1;
            // 
            // WebApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 494);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WebApp";
            this.Text = "Navegador web";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRetroceder;
        private System.Windows.Forms.ToolStripButton btnAvanzar;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripButton btnHome;
        private System.Windows.Forms.ToolStripTextBox txtURL;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripComboBox cboFavoritos;
        private System.Windows.Forms.ToolStripButton btnFavoritos;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

