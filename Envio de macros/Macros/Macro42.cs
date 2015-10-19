using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Envio_de_macros.Macros
{
    public partial class Macro42 : Form
    {
        List<Economico> listaEconomicos = new List<Economico>();

        public Macro42()
        {
            InitializeComponent();
        }
        public Macro42(List<Economico> lista)
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

    }

}
