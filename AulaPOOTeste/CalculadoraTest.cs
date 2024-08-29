using ConceitosPOO;

namespace AulaPOOTeste
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void SomaTest()
        {
            //cenario
            int num1 = 20;
            int num2 = 22;
            int result;
            var calc = new Calculadora();

            //ação
            result = calc.Soma(num1, num2);

            //verificação
            Assert.AreEqual(42, result);
        }
    }
}