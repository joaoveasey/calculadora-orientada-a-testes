using New_Talents___Testes;
using System.Security.Cryptography.X509Certificates;

namespace TestsNewTalent
{
    public class UnitTest1
    {
        [Theory]
        [InlineData (1,2,3)]
        [InlineData (4,5,9)]
        [InlineData (6,12,18)]
        [InlineData (90,30,120)]
        [InlineData (103,60,163)]
        public void TesteSomar(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.Somar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        [InlineData(6, 3, 18)]
        [InlineData(90, 2, 180)]
        [InlineData(103, 3, 309)]
        public void TesteMultiplicar(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.Multiplicar(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(4, 2, 2)]
        [InlineData(6, 6, 1)]
        [InlineData(90, 2, 45)]
        [InlineData(100, 5, 20)]
        public void TesteDividir(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.Dividir(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(4, 2, 2)]
        [InlineData(6, 6, 0)]
        [InlineData(90, 2, 88)]
        [InlineData(100, 5, 95)]
        public void TesteSubtrair(int val1, int val2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int resultadoCalculadora = calc.Subtrair(val1, val2);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPor0()
        {
            Calculadora calc = new Calculadora();

            Assert.Throws<DivideByZeroException>(() => calc.Dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = new Calculadora();

            calc.Somar(1, 2);
            calc.Somar(2, 8);
            calc.Somar(1, 6);
            calc.Somar(7, 6);

            var lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count); 
        }
    }
}