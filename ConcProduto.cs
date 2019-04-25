using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class ConcProduto : ABSProdServ
    {
        private string _nome;
        private int _codBarra;
        private double _Preco;


        public ConcProduto(string nome, int codBarra, double Preco)
        {
            this._nome = nome;
            this._codBarra = codBarra;
            this._Preco = Preco;
        }

        public override ABSProdServ clonar()
        {
            return this.MemberwiseClone() as ABSProdServ;

        }

        public string nome
        {
            get { return this._nome; }
            set { _nome = value; }
        }

        public int codBarra
        {
            get { return this._codBarra; }
            set { _codBarra = value; }
        }

        public double Preco
        {
            get { return this._Preco; }
            set { _Preco = value; }
        }

    }
}
