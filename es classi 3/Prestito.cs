using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_classi_3
{
    internal class Prestito
    {
        public string Numero { get; set; }
        public DateTime Dal { get; set; }
        public DateTime Al { get; set; }
        public Utente Utente { get; set; }
        public Documento Documento { get; set; }

}
}
