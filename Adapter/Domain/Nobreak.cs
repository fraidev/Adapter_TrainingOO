using System;
using System.Collections.Generic;

namespace Adapter.Domain
{
    public class Nobreak:IEntradaAmericana
    {
        public bool EntradaDeTomada { get; set; }
        public bool Luz { get; set; }

        public void LigarNa(Energia energia)
        {
            if (energia.Luz)
            {
                Luz = true;
                Console.WriteLine("O Nobreak ligou!");}
            else
            {
                Luz = false;
                Console.WriteLine("O Nobreak ligou!");
            }
        }
    }
}