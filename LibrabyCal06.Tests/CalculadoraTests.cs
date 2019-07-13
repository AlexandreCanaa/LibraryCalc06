using LibraryCalc06;
using System;
using Xunit;

namespace LibrabyCal06.Tests
{
    public class CalculadoraTests
    {
        // InlineData
        #region
        [Theory]
        [InlineData(3, 0)]
        [InlineData(1, 2)]
        [InlineData(5, 8)]
        [InlineData(7, 16)]
        [InlineData(12, 43)]
        [InlineData(27, 256)]
        #endregion
        public void SomaSucesso(int x, int y)
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Somar(x, y);

            Assert.True((x + y) == resultado);
        }

        // InlineData
        #region
        [Theory]
        [InlineData(3, 0)]
        [InlineData(1, 2)]
        [InlineData(5, 8)]
        [InlineData(7, 16)]
        [InlineData(12, 43)]
        [InlineData(27, 256)]
        #endregion
        public void SomaFalha(int x, int y)
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Somar(x, y);

            Assert.False((x + y) != resultado);
        }

        // InlineData
        #region
        [Theory]
        [InlineData(3, 0)]
        [InlineData(1, 2)]
        [InlineData(5, 8)]
        [InlineData(7, 16)]
        [InlineData(12, 43)]
        [InlineData(27, 256)]
        #endregion
        public void Subtra��oSucesso(int x, int y)
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Subtrair(x, y);

            Assert.True((x - y) == resultado);
        }

        // InlineData
        #region
        [Theory]
        [InlineData(3, 0)]
        [InlineData(1, 2)]
        [InlineData(5, 8)]
        [InlineData(7, 16)]
        [InlineData(12, 43)]
        [InlineData(27, 256)]
        #endregion
        public void Subtra��oFalha(int x, int y)
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Subtrair(x, y);

            Assert.False((x - y) != resultado);
        }

        // InlineData
        #region
        [Theory]
        [InlineData(3, 0)]
        [InlineData(1, 2)]
        [InlineData(5, 8)]
        [InlineData(7, 16)]
        [InlineData(12, 43)]
        [InlineData(27, 256)]
        #endregion 
        public void Multiplica��oSucesso(int x, int y)
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Multiplicar(x, y);

            Assert.True((x * y) == resultado);
        }

        // InlineData
        #region
        [Theory]
        [InlineData(3, 0)]
        [InlineData(1, 2)]
        [InlineData(5, 8)]
        [InlineData(7, 16)]
        [InlineData(12, 43)]
        [InlineData(27, 256)]
        #endregion
        public void Multiplica��oFalha(int x, int y)
        {
            var calculadora = new Calculadora();

            var resultado = calculadora.Multiplicar(x, y);

            Assert.False((x * y) != resultado);
        }

        // InlineData
        #region
        [Theory]
        [InlineData(3.0, 0.0)]
        [InlineData(1.0, 2.0)]
        [InlineData(5.0, 8.0)]
        [InlineData(7.0, 16.0)]
        [InlineData(12.0, 43.0)]
        [InlineData(27.0, 256.0)]
        #endregion
        public void Divis�oSucesso(double x, double y)
        {
            //var xd = Convert.ToDouble(x);
            //var yd = Convert.ToDouble(y);

            var calculadora = new Calculadora();

            var resultado = calculadora.Dividir(x, y);

            Assert.True((x / y) == resultado);
        }

        // InlineData
        #region
        [Theory]
        [InlineData(3, 0)]
        [InlineData(1, 2)]
        [InlineData(5, 8)]
        [InlineData(7, 16)]
        [InlineData(12, 43)]
        [InlineData(27, 256)]
        #endregion
        public void Divis�oFalha(double x, double y)
        {
            //var xd = Convert.ToDouble(x);
            //var yd = Convert.ToDouble(y);

            var calculadora = new Calculadora();

            var resultado = calculadora.Dividir(x, y);

            Assert.False((x / y) != resultado);
        }
    }
}
