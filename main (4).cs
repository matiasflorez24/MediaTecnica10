/******************************************************************************
                Ejercicio estructura de decisión múltiple
Autor:          Nicolle Zapata M.
Fecha:          29-05-2024
Descripción:    Ejercicio estructura de decisión múltiple
Se desea un programa que ayude diciendo
las preferencias según el género:
- Si es un hombre menor de edad sus preferencias son:
    Figuras de acción, Caricaturas, Series TV
- Si es un hombre mayor de edad sus preferencias son:
    cine, picnic y filantropía
- Si es una mujer menor de edad sus preferencias son:
    Muñecas, Maquillaje, Series TV
- Si es una mujer mayor de edad sus preferencias son:
    Maquillaje, Series TV, Cine, filantropía
*******************************************************************************/
using System;
class Program
{
      static void Main(string[] args)
      {
       Console.WriteLine("preferencias según el género (hombre/mujer)");
       Console.Write("ingrese el género: ");
        string genero = Console.ReadLine();
       
        Console.Write("ingrese su edad: ");
        int edad = Int32.Parse(Console.ReadLine());
       
        Console.WriteLine("sus preferencias son: ");
        if (genero == "hombre"){
           if (edad < 18){
        
            Console.WriteLine("Figuras de acción");
            Console.WriteLine("Caricaturas");
            Console.WriteLine("Series TV");
            }
        
        if (edad >= 18)
        {

            Console.WriteLine("cine");
            Console.WriteLine("picnic");
            Console.WriteLine("filantropía");
        }
        }
        if (genero == "mujer"){
            if (edad < 18){
        
            Console.WriteLine("Muñecas");
            Console.WriteLine("Maquillaje");
            Console.WriteLine("Series TV");
            }
        
        if (edad >= 18){
            
            Console.WriteLine("Maquillaje");
            Console.WriteLine("Series TV");
            Console.WriteLine("Cine");
            Console.WriteLine("Filantropía");
        }
        
        }
      }
}