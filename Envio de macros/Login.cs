using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Envio_de_macros.Persistencia;

namespace Envio_de_macros
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            bool login = DatabaseHelper.execSPLogin("Usuarios", txtUsuario.Text, txtContraseña.Text);
            if (login)
            {
                Form1 inicio = new Form1();
                MessageBox.Show("Bienvenido");
                this.Hide();
                inicio.ShowDialog();
                inicio.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Verifica tus datos");
                this.txtContraseña.Text = "";
                this.txtUsuario.Text = "";
            }

        }
    }
}
