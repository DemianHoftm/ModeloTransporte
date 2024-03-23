using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloTransporte
{
    internal class nodo_class
    {
        private int _num;
        private int _acumulado;
        private List<decimal> _peso_siguientes;
        private List<nodo_class> nodos_siguientes;

        public int Numero { get { return _num; } set { _num = value; } }
        public int Acumulado { get { return _acumulado; } set { _acumulado = value; } }
        public List<decimal> Peso_sig { get { return _peso_siguientes; }set { _peso_siguientes = value;} }
        public List<nodo_class> Nodos_Sig { get { return nodos_siguientes; } set { nodos_siguientes = value; } }

        public nodo_class() {
            Peso_sig = new List<decimal>();
            Nodos_Sig = new List<nodo_class>();
        }
        
    }
}
