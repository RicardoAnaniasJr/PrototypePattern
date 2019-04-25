using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerenciador_Prods gerenciador = new Gerenciador_Prods();

            //Inicializa o gerenciado com as cores padrão
            gerenciador["Produto1"] = new ConcProduto("Vape",123,200.00);
            gerenciador["Produto2"] = new ConcProduto("Skate", 456, 150.00);
            gerenciador["Produto3"] = new ConcProduto("Moto", 789, 20000.00);

            //Adiciar cores personalizadas
            gerenciador["Servico1"] = new ConcServ("Limpeza",698,50.00,2);



            //As cores são clonadas para novos objetos
            ConcServ serv = gerenciador["Servico1"].clonar() as ConcServ;
            ConcProduto prod1 = gerenciador["Produto1"].clonar() as ConcProduto;
            ConcProduto prod2 = gerenciador["Produto2"].clonar() as ConcProduto;
            


            Console.ReadKey();
            Console.WriteLine("prod1: ({0},{1},{2})", prod1.nome,prod1.codBarra, prod1.Preco);
            Console.WriteLine("prod2: ({0},{1},{2})", prod2.nome, prod2.codBarra, prod2.Preco);
            Console.WriteLine("serv1: ({0},{1},{2},{3},{4})", serv.nome, serv.codBarra, serv.Preco, serv.qtd, serv.Total);

            Console.ReadKey();

        }


    }
}

