using Adapter.Domain;
using NUnit.Framework;

namespace Adapter.Tests
{
    public class Testes
    {
        //Energia
        [Test]
        public void A_Energia_Deve_Ser_Ligada_Quando_For_Ligada()
        {
            var energia = new Energia();
            energia.LigarLuz();

            Assert.AreEqual(true, energia.Luz);
        }
        
        [Test]
        public void A_Energia_Deve_Ser_Desligada_Quando_For_Desligada()
        {
            var energia = new Energia();
            energia.LigarLuz();
            energia.DesligarLuz();

            Assert.AreEqual(false, energia.Luz);
        }
        
        //Nobreak
        [Test]
        public void O_Nobreak_Deve_Ligar_Quando_For_Ligado_E_Tiver_Luz_Na_Energia()
        {
            var energia = new Energia();
            energia.LigarLuz();
            
            var nobreak = new Nobreak();
            nobreak.LigarNa(energia);

            Assert.AreEqual(true, nobreak.Luz);
        }
        [Test]
        public void O_Nobreak_Deve_Continuar_Desligado_Se_Nao_Tiver_Luz_Na_Energia()
        {
            var energia = new Energia();
            
            var nobreak = new Nobreak();
            nobreak.LigarNa(energia);

            Assert.AreEqual(false, nobreak.Luz);
        }
        
        //Adaptador
        [Test]
        public void O_Adaptador_Deve_Estar_Plugador_E_Entregando_Luz_Se_Foi_Plugado_E_EntradaDeTomada_Deve_Ser_Falsa_E_O_Nobreak_Deve_Ter_Tomada_Ocupada()
        {
            var energia = new Energia();
            energia.LigarLuz();
            
            var nobreak = new Nobreak();
            nobreak.LigarNa(energia);
            
            var adaptadorBrParaUs = new AdaptadorBrParaUs();
            adaptadorBrParaUs.PlugarNo(nobreak);
            
            Assert.AreEqual(true, adaptadorBrParaUs.Plugado);
            Assert.AreEqual(true, adaptadorBrParaUs.Luz);
            Assert.AreEqual(false, adaptadorBrParaUs.EntradaDeTomada);
            Assert.AreEqual(true, nobreak.EntradaDeTomada);
        }
        [Test]
        public void O_Adaptador_Nao_Deve_Estar_Plugador_Se_Nao_Foi_Plugado()
        {
            var energia = new Energia();
            
            var nobreak = new Nobreak();
            nobreak.LigarNa(energia);
            
            var adaptadorBrParaUs = new AdaptadorBrParaUs();
            
            Assert.AreEqual(false, adaptadorBrParaUs.Plugado);
            Assert.AreEqual(false, adaptadorBrParaUs.Luz);
            Assert.AreEqual(false, adaptadorBrParaUs.EntradaDeTomada);
            Assert.AreEqual(false, nobreak.EntradaDeTomada);
        }
        
        // Computador
        [Test]
        public void O_Computador_Ligado_Funciona()
        {
            var energia = new Energia();
            energia.LigarLuz();
            
            var nobreak = new Nobreak();
            nobreak.LigarNa(energia);
            
            var adaptadorBrParaUs = new AdaptadorBrParaUs();
            adaptadorBrParaUs.PlugarNo(nobreak);

            var computador = new Computador();
            computador.PlugarNo(adaptadorBrParaUs);
            computador.Ligar();
            
            Assert.AreEqual(true, adaptadorBrParaUs.EntradaDeTomada);
            Assert.AreEqual(true, computador.Plugado);
            Assert.AreEqual(true, computador.Ligado);
            Assert.AreEqual(true, computador.Luz);
            Assert.AreEqual(7, computador.Calcula(2,5));
        }
        
        [Test]
        public void O_Computador_Desligado_Nao_funciona()
        {
            var energia = new Energia();
            energia.LigarLuz();
            
            var nobreak = new Nobreak();
            nobreak.LigarNa(energia);
            
            var adaptadorBrParaUs = new AdaptadorBrParaUs();
            adaptadorBrParaUs.PlugarNo(nobreak);

            var computador = new Computador();
            
            Assert.AreEqual(false, adaptadorBrParaUs.EntradaDeTomada);
            Assert.AreEqual(false, computador.Plugado);
            Assert.AreEqual(false, computador.Ligado);
            Assert.AreEqual(false, computador.Luz);
            Assert.AreEqual(0, computador.Calcula(2,5));
        }
    }
}