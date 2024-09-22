using NewTalents;
using System;
using Xunit;

namespace TesteNewTalents
{
    public class UnitTest1
    {
        public Calculadora Construtor()
        {
            string data = "22/09/2024";
            Calculadora calc = new Calculadora(data);
            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestSomar(int x, int y, int z)
        {
            Calculadora calculadora = Construtor();
            int result =  calculadora.Somar(x, y);
            Assert.Equal(z, result);
        }
        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void TestSubtrair(int x, int y, int z)
        {
            Calculadora calculadora = Construtor();
            int result = calculadora.Subtrair(x, y);
            Assert.Equal(z, result);
        }
        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TestDividir(int x, int y, int z)
        {
            Calculadora calculadora = Construtor();
            int result = calculadora.Dividir(x, y);
            Assert.Equal(z, result);
        }
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiplicar(int x, int y, int z)
        {
            Calculadora calculadora = Construtor();
            int result = calculadora.Multiplicar(x, y);
            Assert.Equal(z, result);
        }
        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calculadora = Construtor();
            Assert.Throws<DivideByZeroException>(
                () => calculadora.Dividir(3, 0)
            );
        }
        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = Construtor();

            calc.Somar(1,2);
            calc.Somar(3,4);
            calc.Somar(4,5);
            calc.Somar(5,6);

            var lista = calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}
