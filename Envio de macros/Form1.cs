using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Envio_de_macros
{
    public partial class Form1 : Form
    {
        List<Economico> listaEconomicos = new List<Economico>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEconomico(txtEconomico.Text);
        }

        private void AgregarEconomico(string text)
        {
            if(listaEconomicos.Count < 20)
            {
                listaEconomicos.Add(new Economico(text));
                txtEconomico.Text = "";
                txtListaEconomicos.Text = string.Join(", ", listaEconomicos);
            }
            else
            {
                MessageBox.Show("Has alcanzado el límite de destinatarios.\nPrueba generando otro mensaje.");
            }

        }

        private void txtEconomico_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                AgregarEconomico(txtEconomico.Text);
            }
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            if(cbMacros.SelectedIndex == 1)
            {
                Macros.Macro42 myMacro42 = new Macros.Macro42(listaEconomicos);
                this.Hide();
                myMacro42.ShowDialog();
                myMacro42.Close();
                this.Show();
            }
            else if(cbMacros.SelectedIndex == 2)
            {
                Macros.Macro43 myMacro43 = new Macros.Macro43(listaEconomicos);
                this.Hide();
                myMacro43.ShowDialog();
                myMacro43.Close();
                this.Show();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtListaEconomicos.Text = "";
            listaEconomicos.Clear();
        }
    }
}
