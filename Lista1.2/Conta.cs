using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1._2
{
    class Conta
    {
        string _nomeCliente;
        double saldo = 0;

        public string NomeCliente
        {
            get
            {
                return _nomeCliente;
            }
        }


        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if (value < 0)
                {
                    saldo = value;
                }
            }
        }

        public void Registro(string NomeCliente, double saldo)
        {
            this._nomeCliente = NomeCliente;
            this.saldo = saldo;
        }
    }
}
