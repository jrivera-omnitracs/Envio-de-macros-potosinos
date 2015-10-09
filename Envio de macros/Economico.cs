using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Envio_de_macros
{
    public class Economico
    {
        string eco;

        public Economico(string e)
        {
            Eco = e;
        }

        public override string ToString()
        {
            return Eco;
        }

        public string Eco
        {
            get
            {
                return eco;
            }

            set
            {
                eco = value.ToUpper();
            }
        }


    }
}
