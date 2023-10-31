using TesteUnitario.Console;
namespace TesteUnitario.Test
{
    public class CalculadoraTest
    {
        public Calculadora construirCalculadora()
        {
            string data = DateTime.Now.ToShortDateString();
            Calculadora calc = new Calculadora(data);
            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TesteSomar(int x, int y, int resultado)
        {
            Calculadora calc = construirCalculadora();

            int resultadoCalculadora = calc.Somar(x, y);

            Assert.Equal(resultado, resultadoCalculadora);

        }


        [Theory]
        [InlineData(2, 1, 1)]
        [InlineData(10, 5, 5)]
        public void TestSubtrair(int x, int y, int resultado)
        {
            Calculadora calc = construirCalculadora();

            int resultadoCalculadora = calc.Subtrair(x, y);

            Assert.Equal(resultado, resultadoCalculadora);

        }

        [Theory]
        [InlineData(2, 5, 10)]
        [InlineData(3, 4, 12)]
        public void TestMultiplicar(int x, int y, int resultado)
        {
            Calculadora calc = construirCalculadora();

            int resultadoCalculadora = calc.Multiplicar(x, y);

            Assert.Equal(resultado, resultadoCalculadora);

        }


        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(10, 2, 5)]
        public void TestDividir(int x, int y, int resultado)
        {
            Calculadora calc = construirCalculadora();

            int resultadoCalculadora = calc.Dividir(x, y);

            Assert.Equal(resultado, resultadoCalculadora);

        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = construirCalculadora();
            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3, 0)
                );
        }


        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = construirCalculadora();
            calc.Somar(2, 3);
            calc.Somar(1, 5);
            calc.Subtrair(5, 3);
            calc.Multiplicar(6, 50);
            calc.Dividir(50, 10);
            var lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}