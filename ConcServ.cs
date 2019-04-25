using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class ConcServ : ABSProdServ
    {
        private string _nome;
        private int _codBarra;
        private double _Preco;
        private int _qtd;
        private double _ValorTotal;
        
        public ConcServ(string nome,int codBarra, double Preco, int qtd )
        {
            this._nome = nome;
            this._codBarra = codBarra;
            this._Preco = Preco;
            this._qtd = qtd;
            this._ValorTotal = qtd * Preco;
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
        public int qtd
        {
            get { return this._qtd; }
            set { _qtd = value; }
        }
        public double Total
        {
            get { return this._ValorTotal; }
            
        }
        



    }
}
