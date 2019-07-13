# LibraryCalc06
LibraryCalc06

[![Build status](https://ci.appveyor.com/api/projects/status/mcdxfrvgtldn3jb0/branch/master?svg=true)](https://ci.appveyor.com/project/AlexandreCanaa/librarycalc06/branch/master)

## How to install
Install-Package LibraryCalc06 -Version 1.2.0

```cs
using LibraryCalc06
using System

namespace Example
{
    class Program
    {
        static void Main(string [] args)
        {
            var calculadora = new Calculadora();
            
            var x = 5;
            var y = 4;
            
            var result = calculadora.Soma(x, y)
        }
    }
}
