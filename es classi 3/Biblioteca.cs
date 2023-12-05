using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace es_classi_3
{
    internal class Biblioteca
    {
        public string Nome {  get; set; }
        public List<Documento> Documenti { get; set; }
        public List<Prestito> Prestiti { get; set; }
        public List<Utente> Utenti { get; set; }

      
    }
}
