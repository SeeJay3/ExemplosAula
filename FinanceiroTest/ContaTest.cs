using Financeiro;

namespace FinanceiroTest


{
    [TestClass]
    public class ContaTest
    {
        [TestMethod]
        public void SacarValorMenorSaldoTest()
        {
            //cenario
            decimal valorSaque = 100.50m;
            decimal saldoInicial = 1000.50m;
            decimal saldoFinal = 900;
            Conta conta1 = new Conta();
            conta1.Depositar(saldoInicial);

            //a��o
            conta1.Sacar(valorSaque);

            //verifica��o
            Assert.AreEqual(saldoFinal, conta1.Saldo);
        }
    }
}