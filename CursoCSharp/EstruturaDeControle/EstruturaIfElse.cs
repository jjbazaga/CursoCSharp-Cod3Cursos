﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaIfElse {
        public static void Executar() {

            Console.Write("Entre com sua nota: ");
            Double.TryParse(Console.ReadLine(), out double nota);

            if(nota >= 7.0) {
                Console.WriteLine("Aprovado");
                Console.WriteLine("Não fez mais do que sua obrigação...");
            } else {
                Console.WriteLine("Recuperação");
                Console.WriteLine("Não fez sua obrigação...");
            }
        }
    }
}
