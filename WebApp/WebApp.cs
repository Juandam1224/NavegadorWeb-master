using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebApp
{
    public partial class WebApp : Form
    {
        List<string> Favoritos = new List<string>();
        public WebApp()
        {
            InitializeComponent();
        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtURL.Text);
        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            Favoritos.Add(webBrowser1.Url.ToString());
            Actualizcbo();
        }
        private void Actualizcbo()
        {
            foreach (string direccion in Favoritos)
            {
                cboFavoritos.Items.Add(direccion);
            }
        }

        private void cboFavoritos_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(cboFavoritos.SelectedItem.ToString());
        }
    }
}
