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

namespace Envio_de_macros.Macros
{
    public partial class Macro43 : Form
    {
        List<Economico> listaEconomicos = new List<Economico>();

        public Macro43()
        {
            InitializeComponent();
        }
        public Macro43(List<Economico> lista)
        {
            InitializeComponent();
            ListaEconomicos = lista;
            ListaATxt(lista, txtDestinatarios);
        }

        private void ListaATxt(List<Economico> lista, TextBox text)
        {
            text.Text = string.Join(", ", lista);
        }

        internal List<Economico> ListaEconomicos
        {
            get
            {
                return listaEconomicos;
            }

            set
            {
                listaEconomicos = value;
            }
        }



        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string query;
            foreach (Economico economico in listaEconomicos)
            {
                query = "INSERT EnviaMensajes VALUES ("
                + "1"
                + ", '" + economico.Eco + "'"
                + ", 43"
                + ", NULL"
                + ", '" 
                    + txtMensaje1.Text + ";"
                    + txtMensaje2.Text + ";"
                    + txtMensaje3.Text + ";"
                    + txtMensaje4.Text + ";"
                    + txtMensaje5.Text + ";"
                    + txtMensaje6.Text
                + "'"
                + ", NULL"
                + ")";
                DatabaseHelper.execSPCreate(query);
                //MessageBox.Show(query);
                this.Close();
            }
            
        }
    }
}
