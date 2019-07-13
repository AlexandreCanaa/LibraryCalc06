using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryCalc06
{
    /// <summary>
    /// Provê a interface de uma calculadora.
    /// </summary>
    public interface ICalculadora {

        /// <summary>
        /// Soma de valores
        /// </summary>
        /// <param name="x">Valor Inteiro</param>
        /// <param name="y">Valor Inteiro</param>
        /// <returns>Resultado da Soma</returns>
        int Somar(int x, int y);

        /// <summary>
        /// Soma de valores, 3 parâmetros
        /// </summary>
        /// <param name="x">Valor Inteiro</param>
        /// <param name="y">Valor Inteiro</param>
        /// <returns>Resultado da Soma</returns>
        int Somar(int x, int y, int z);

        /// <summary>
        /// Subtração de valores
        /// </summary>
        /// <param name="x">Valor Inteiro</param>
        /// <param name="y">Valor Inteiro</param>
        /// <returns>Resultado da Subtração</returns>
        int Subtrair(int x, int y);

        /// <summary>
        /// Subtração de valores, 3 parâmetros
        /// </summary>
        /// <param name="x">Valor Inteiro</param>
        /// <param name="y">Valor Inteiro</param>
        /// <param name="z">Valor Inteiro</param>
        /// <returns></returns>
        int Subtrair(int x, int y, int z);

        /// <summary>
        /// Multiplicação de valores
        /// </summary>
        /// <param name="x">Valor Inteiro</param>
        /// <param name="y">Valor Inteiro</param>
        /// <returns>Resultado da Multiplicação</returns>
        int Multiplicar(int x, int y);

        /// <summary>
        /// Divisão de valores
        /// </summary>
        /// <param name="x">Valor de ponto flutuante(double)</param>
        /// <param name="y">Valor de ponto flutuante(double)</param>
        /// <returns>Resultado da Divisão</returns>
        double Dividir(double x, double y);

        /// <summary>
        /// Potenciação de Valores
        /// </summary>
        /// <param name="x">Valor de ponto flutuante(double)</param>
        /// <param name="y">Valor de ponto flutuante(double)</param>
        /// <returns></returns>
        double Potencia(double x, double y);

    }
}
