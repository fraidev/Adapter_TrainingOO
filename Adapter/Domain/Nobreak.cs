using System;
using System.Collections.Generic;

namespace Adapter.Domain
{
    public class Nobreak:IEntradaAmericana
    {
        public bool EntradaDeTomada { get; set; } = false;
        public bool EntregaLuz { get; set; }

        public void LigarNa(Energia energia)
        {
            if (energia.Luz)
            {
                EntregaLuz = true;
                Console.WriteLine("O Nobreak ligou!");}
            else
            {
                EntregaLuz = false;
                Console.WriteLine("O Nobreak ligou!");
            }
        }
    }
}