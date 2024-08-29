using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosPOO
{
    public class Util
    {
        public bool VerificaPrimo(int valor)
        {
            for (int i = 2; i <= valor / 2; i++)
            {
                if (valor % i == 0)
                    return false;
            }
            return true;
        }
    }
}
