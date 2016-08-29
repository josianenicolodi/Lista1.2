using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco();
      

            banco.Inicializa();

        

            Console.WriteLine(" Conta de maior saldo : " + banco.MaiorSaldo().NomeCliente );

            Console.ReadLine();
        }
    }
}
