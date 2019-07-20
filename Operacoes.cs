using System;
using System.Collections.Generic;
using System.Text;

namespace Numbers
{
    class Operacoes
    {
       public void Mudarpar(List<uint> par)
        {
            for (uint i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    par.Add(i - 1);
                    par.Remove(i);
                }
            }
        }
       public void Mudarimpar(List<uint> impar)
        {
            for (uint i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    impar.Add(i + 1);
                    impar.Remove(i);
                }
            }
        }
    }
}
