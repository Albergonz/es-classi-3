using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es_classi_3
{
    internal class Documento
    {
        public string Codice { get; set; }
        public string Titolo { get; set; }
        public int Anno{ get; set; }
        public string Settore { get; set; }
        public Stato Stato{ get; set; }
        public List<Autore> Autori { get; set; }
        public Scaffale Scaffale { get; set; }
       
    }
}
