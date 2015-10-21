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
                    + txtRemolque.Text + ";"            //1
                    + txtOrigenLugar.Text + ";"         //2
                    + txtOrigenCliente.Text + ";"       //3
                    + txtOrigenDomicilio1.Text + ";"    //4
                    + txtOrigenDomicilio2.Text + ";"    //5
                    + txtOrigenDomicilio3.Text + ";"    //6
                    + txtOrigenFecha1.Text 
                        + txtOrigenFecha2.Text 
                        + txtOrigenFecha3.Text + ";"    //7
                    + txtOrigenHora1.Text
                        + txtOrigenHora2.Text + ";"     //8
                    + txtEscalaLugar1.Text + ";"        //9
                    + txtEscalaLugar2.Text + ";"        //10
                    + txtEscalaLugar3.Text + ";"        //11
                    + txtDestinoLugar.Text + ";"        //12
                    + txtDestinoCliente.Text + ";"      //13
                    + txtDestinoDomicilio1.Text + ";"   //14
                    + txtDestinoDomicilio2.Text + ";"   //15
                    + txtDestinoDomicilio3.Text + ";"   //16
                    + txtDestinoFecha1.Text 
                        + txtDestinoFecha2.Text 
                        + txtDestinoFecha3.Text + ";"   //17
                    + txtDestinoHora1.Text 
                        + txtDestinoHora2.Text + ";"    //18
                    + txtDestinoTiempo1.Text 
                        + txtDestinoTiempo2.Text + ";"  //19
                    + txtDestinoRuta1.Text + ";"        //20
                    + txtDestinoRuta2.Text + ";"        //21
                    + txtDestinoComentarios1.Text + ";" //22
                    + txtDestinoComentarios2.Text + ";" //23
                    + txtDestinoComentarios3.Text + ";" //24
                    + txtEnvía.Text                     //25
                + "'"
                + ", NULL"
                + ")";
                DatabaseHelper.execSPCreate(query);

            }
        }
    }
}
