using Calcolatrice.Core;
using System;
using Xunit;

namespace Calcolatrice.Test
{
    public class CalcoliTest
    {
        [Fact]
        public void TestSomma()
        {
            //ARRANGE: predisposizione del test
            Calculator calcolatrice = new Calculator();
            //ACT: chiamata alla funzionalità da testare
            double risultato = calcolatrice.SommaNumeri(1, -3);
            //ASSERT: valutazione del risultato atteso vs restituito
            Assert.Equal(-2, risultato);
        }
        [Fact]
        public void TestDifferenza()
        {
            //ARRANGE: predisposizione del test
            Calculator calcolatrice = new Calculator();
            //ACT: chiamata alla funzionalità da testare
            double risultato = calcolatrice.SottraiNumeri(1, -3);
            //ASSERT: valutazione del risultato atteso vs restituito
            Assert.Equal(4, risultato);
        }
        [Fact]
        public void TestProdotto()
        {
            //ARRANGE: predisposizione del test
            Calculator calcolatrice = new Calculator();
            //ACT: chiamata alla funzionalità da testare
            double risultato = calcolatrice.MoltiplicaNumeri(1, -3);
            //ASSERT: valutazione del risultato atteso vs restituito
            Assert.Equal(-3, risultato);
        }
        [Fact]
        public void TestQuoziente1()
        {
            //ARRANGE: predisposizione del test
            Calculator calcolatrice = new Calculator();
            //ACT: chiamata alla funzionalità da testare
            double? risultato = calcolatrice.DividiNumeri(3, -3);
            //ASSERT: valutazione del risultato atteso vs restituito
            Assert.Equal(-1, risultato);
        }
        [Fact]
        public void TestQuoziente2()
        {
            //ARRANGE: predisposizione del test
            Calculator calcolatrice = new Calculator();
            //ACT: chiamata alla funzionalità da testare
            double? risultato = calcolatrice.DividiNumeri(3, 0);
            //ASSERT: valutazione del risultato atteso vs restituito
            Assert.Null(risultato);
        }

        [Fact]
        public void TestVerificaSeAMaggioreDiB()
        {
            //ARRANGE: predisposizione del test
            Calculator calcolatrice = new Calculator();
            //ACT: chiamata alla funzionalità da testare
            bool risultato = calcolatrice.VerificaSeAMaggioreDiB(3, 1);
            //ASSERT: valutazione del risultato atteso vs restituito
            Assert.True(risultato == true);
        }
        [Fact]
        public void TestVerificaSeAMaggioreDiB2()
        {
            //ARRANGE: predisposizione del test
            Calculator calcolatrice = new Calculator();
            //ACT: chiamata alla funzionalità da testare
            bool risultato = calcolatrice.VerificaSeAMaggioreDiB(3.2, 3.2);
            //ASSERT: valutazione del risultato atteso vs restituito
            Assert.True(risultato == true);                     //capisco che è un maggiore uguale!!
        }
    }
}
