using EquazioniSecondoGrado.Core;
using System;
using Xunit;

namespace EquazioniSecondoGrado.Test
{
    public class EquazioneTest
    {
        [Fact]
        public void Test1() //per convenzione iniziano con Should - ShouldDoStuff()
        {
            //fase 1: ARRANGE   (predisposizione, preparazione al test)
            double a = 1;
            double b = -3; //questi glieli potevamo passare anche direttamente nel'act....
            double c = 2;
            Equation equazione = new Equation(); //IMPO!! mi serve un oggetto equazione da cui richiamare il metodo che testiamo

            //fase 2: ACT       (chiamata alla funzionalità da testare)
            double [] risultato = equazione.RisolviEquazioneDiSecondoGrado(a, b, c);

            //fase 3: ASSERT    (valutazione del risultato restituito vs risultato atteso)
            Assert.True(risultato.Length == 2);
            Assert.Equal(1, risultato[0]);  //    analogo a   Assert.True(risultato[0] == 1);
            Assert.Equal(2, risultato[1]);
        }

        [Fact]
        public void Test2()
        {
            Equation equazione = new Equation();
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(1, -5, 6);
            Assert.True(risultato.Length == 2);
            Assert.Equal(2, risultato[0]);  
            Assert.Equal(3, risultato[1]);
                    }
        
        [Fact]
        public void Test3()
        {
            Equation equazione = new Equation();
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(1,2,1);
            Assert.True(risultato.Length == 1);
            Assert.Equal(-1, risultato[0]);  
        }

        [Fact]
        public void Test4()
        {
            Equation equazione = new Equation();
            double[] risultato = equazione.RisolviEquazioneDiSecondoGrado(1,-3,10);
            Assert.Null(risultato);
        }
    }
}
