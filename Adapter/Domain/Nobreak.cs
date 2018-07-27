using System;
using System.Collections.Generic;

namespace Adapter.Domain
{
    public class Nobreak:IEntradaAmericana
    {
        public bool EntradaDeTomada { get; set; }
        public Energia Energia { get; set; }

        public void LigarNa(Energia energia)
        {
            if (energia.Luz)
            {
                Energia = energia;
                Console.WriteLine("O Nobreak ligou!");}
            else
            {
                Energia = energia;
                Console.WriteLine("O Nao ligou Nobreak!");
            }
        }
    }
}