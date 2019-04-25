using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class Gerenciador_Prods
    {
        private Dictionary<string, ABSProdServ> _prods = new Dictionary<string, ABSProdServ>();
        
        //Indexador
        public ABSProdServ this[string key]
        {
            get { return _prods[key]; }
            set { _prods.Add(key, value); }
        }

    }
}
