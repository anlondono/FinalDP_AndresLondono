using System;
using System.Collections.Generic;
using System.Text;

namespace AndresLondono.Core.Services
{
    class CalcularPrimosService : ICalcularPrimosService
    {

        private bool EsPrimo(int n)
        {
            for (int x = 2; x < n; x++)
            {
                if (n % x == 0)
                {
                    return false;
                }

            }
            return true;
        }
        public string VerPrimo(int cantidad)
        {
            string cadena = "";
            int n = 2;
            for (int i = 1; i <= cantidad; i++)
            {
                bool esPrimo = false;
                while (!esPrimo)
                {
                    esPrimo = EsPrimo(n);
                    if (!esPrimo)
                    {
                        n++;
                    }
                }
                cadena += $"{n}, ";
            }
            return cadena;
        }
    }
}