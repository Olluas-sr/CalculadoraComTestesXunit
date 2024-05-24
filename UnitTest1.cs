using Calculadora_com_testes;

namespace TestCalculadora
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1 ,2, 3)]
        [InlineData(4, 5, 9)]
        public void TestSomar(int fator1, int fator2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int retornoCalc = calc.somar(fator1, fator2);
            Assert.Equal(resultado, retornoCalc);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiplicar(int fator1, int fator2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int retornoCalc = calc.multiplicar(fator1, fator2);
            Assert.Equal(resultado, retornoCalc);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TestDividir(int fator1, int fator2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int retornoCalc = calc.dividir(fator1, fator2);
            Assert.Equal(resultado, retornoCalc);
        }

        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(5, 5, 0)]
        public void TestSubtrair(int fator1, int fator2, int resultado)
        {
            Calculadora calc = new Calculadora();

            int retornoCalc = calc.subtrair(fator1, fator2);
            Assert.Equal(resultado, retornoCalc);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = new Calculadora();

            Assert.Throws<DivideByZeroException>(
                () => calc.dividir(3, 0)
            );
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = new Calculadora();

            calc.somar(1, 2);
            calc.somar(1, 3);
            calc.somar(1, 4);
            calc.somar(1, 5);

            var lista = calc.historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}