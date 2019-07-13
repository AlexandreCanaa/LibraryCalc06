using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalc06
{
    public class Calculadora : ICalculadora
    {
        public double Dividir(double x, double y) {
            return x / y;
        }

        public int Multiplicar(int x, int y) {
            return x * y;
        }

        public int Somar(int x, int y) {
            return x + y;
        }

        public int Somar(int x, int y, int z)
        {
            return x + y + z;
        }

        public int Subtrair(int x, int y) {
            return x - y;
        }

        public int Subtrair(int x, int y, int z)
        {
            return x - y - z;
        }
    }
}
