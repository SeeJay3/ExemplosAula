using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financeiro
{
    public class Conta
    {
        private decimal _saldo;
        public decimal Saldo 
        { 
          get
          {
            return _saldo;
          }
          private set
          {
            _saldo = value;
          }
        }
       
        public void Sacar(decimal valor)
        {
            Saldo -= valor; //Saldo = Saldo - valor;
        }
        public void Depositar(decimal valor)
        {
            Saldo += valor; //Saldo = Saldo + valor;
        }
    }
}
