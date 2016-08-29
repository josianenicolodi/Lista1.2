using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1._2
{
    class Banco
    {
        Conta[] contas;
        int qt;

        public void Inicializa()
        {
            Console.WriteLine("Quantas contas deve ter?");
            qt = Convert.ToInt32(Console.ReadLine());
            contas = new Conta[qt];
            string nome;
            double saldo;
            for (int i = 0; i < qt; i++)
            {
                contas[i] = new Conta();

                Console.WriteLine("Informe o nome do usuario:");
                
                nome = Console.ReadLine();
                Console.WriteLine("Informe o saldo da conta:");
                
                saldo = Convert.ToInt32(Console.ReadLine());

                contas[i].Registro(nome, saldo);
            }
        }

        public Conta MaiorSaldo()
        {
            Conta maior = contas[0];


            for (int i = 1; i < contas.Length; i++)
            {
                if (contas[i].Saldo > maior.Saldo)
                {
                    maior = contas[i];
                }
            }

            return maior ;
        }


    }
}
