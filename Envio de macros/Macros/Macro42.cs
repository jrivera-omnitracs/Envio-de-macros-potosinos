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

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string query;
            foreach (Economico economico in listaEconomicos)
            {
                query = "INSERT EnviaMensajes VALUES ("
                + "1"
                + ", '" + economico.Eco + "'"
                + ", 42"
                + ", NULL"
                + ", '"
                    + txtRemolque.Text + ","
                    + txtOrigenLugar.Text + ","
                    + txtOrigenCliente.Text + ","
                    + txtOrigenDomicilio1.Text + ","
                    + txtOrigenDomicilio2.Text + ","
                    + txtOrigenDomicilio3.Text + ","
                    + txtOrigenFecha1.Text + ","
                    + txtOrigenFecha2.Text + ","
                    + txtOrigenFecha3.Text + ","
                    + txtOrigenHora1.Text + ","
                    + txtOrigenHora2.Text + ","
                    + txtEscalaLugar1.Text + ","
                    + txtEscalaLugar2.Text + ","
                    + txtEscalaLugar3.Text + ","
                    + txtDestinoLugar.Text + ","
                    + txtDestinoCliente.Text + ","
                    + txtDestinoDomicilio1.Text + ","
                    + txtDestinoDomicilio2.Text + ","
                    + txtDestinoDomicilio3.Text + ","
                    + txtDestinoFecha1.Text + ","
                    + txtDestinoFecha2.Text + ","
                    + txtDestinoFecha3.Text + ","
                    + txtDestinoHora1.Text + ","
                    + txtDestinoHora2.Text + ","
                    + txtDestinoTiempo1.Text + ","
                    + txtDestinoTiempo2.Text + ","
                    + txtDestinoRuta1.Text + ","
                    + txtDestinoRuta2.Text + ","
                    + txtDestinoComentarios1.Text + ","
                    + txtDestinoComentarios2.Text + ","
                    + txtDestinoComentarios3.Text + ","
                    + txtEnvía.Text
                + "'"
                + ", NULL"
                + ")";
                DatabaseHelper.execSPCreate(query);

            }
        }
    }
}
