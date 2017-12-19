using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class Mensaje
    {
        public DateTime Fecha { get; set; }
        public string Texto { get; set; }
        public Usuario Receptor { get; set; }
        public Usuario Emisor { get; set; }
    }
}
