﻿/*
 * Programmare con C# 7 guida completa
 * Autore: Antonio Pelleriti
 * Capitolo 6: tipi nested
 */

using System;

namespace TipiInnestati
{

    class Program
    {
        static void Main(string[] args)
        {
            SmartPhone sp = new SmartPhone();
            Console.WriteLine(sp.battery.PercentualeCarica);
        }
    }
}
