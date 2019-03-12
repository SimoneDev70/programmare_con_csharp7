﻿/*
 * Programmare con C# 7 guida completa
 * Autore: Antonio Pelleriti
 * Capitolo 12: await in catch (C# 6)
 */


using System;
using System.Threading.Tasks;

namespace AwaitInCatch
{
    //await in catch finally
    class Program
    {
        static void Main(string[] args)
        {
            new Test().Method();
        }
    }

    class Test
    {
        public async void Method()
        {
            Logger logger = new Logger();
            try
            {
                int a = 0;
                int b = 10 / a;

            }
            catch (Exception ex)
            {
                await logger.LogAsync(ex); //in C# 6 è possibile
            }
        }
    }


    class Logger
    {
        public async Task LogAsync(Exception ex)
        {
            await Task.Run(() => Console.WriteLine(ex.Message));
        }
    }
}
