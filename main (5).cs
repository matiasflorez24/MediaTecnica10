/******************************************************************************
Autor: Matias FLorez A.
Fecha: 30-05-2024
Descripción:
Ejercicio aprendizaje
Dada la nota determinar si pierde o gana
*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("digite la nota");
    Console.Write("nota: ");
    int nota = Int32.Parse(Console.ReadLine());
    switch(nota)
    {
        case 1:
            Console.WriteLine("pierde");
            break;
        case 2:
            Console.WriteLine("pierde");
            break;
        case 3:
            Console.WriteLine("gana");
            break;
        case 4:
            Console.WriteLine("alto");
            break;
        case 5:
            Console.WriteLine("superior");
            break;
        default:
            Console.WriteLine("opcion no valida");
            Console.WriteLine("Saliendo del programa...");
            break;
    }
  }
}