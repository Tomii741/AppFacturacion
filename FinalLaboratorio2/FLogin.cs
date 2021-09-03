using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalLaboratorio2
{
    public partial class FLogin : Form
    {
        FCuenta logeado;

        public FLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            if((txtUsuario.Text != "") && (txtContrasena.Text != ""))
            {
                if((txtUsuario.Text == "Tomas") && (txtContrasena.Text == "pass"))
                {
                    logeado = new FCuenta();
                    logeado.Show();
                    this.Hide();
                }
            }
        }
    }
}
