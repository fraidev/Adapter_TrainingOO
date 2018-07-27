using System;

namespace Adapter.Domain
{
    public class Energia
    {
        public bool Luz { get; set; }

        public void LigarLuz()
        {
            Luz = true;
            Console.WriteLine("A Luz da energia ligou");
        }
        public void DesligarLuz()
        {
            Luz = false;
            Console.WriteLine("A Luz da energia Desligou");
        }
    }
}