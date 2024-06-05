/******************************************************************************
Autor: Matias Florez A.
Fecha: 2024-06-05
Descripción: El Rey León: 
    Las manadas de la Roca del Rey están compitiendo 
    por el control de las Tierras del Reino. 
    Pide al usuario la fuerza de al menos 5 
    clanes diferentes y usa estructuras "si" 
    para determinar clasificación de fuerza.
    
*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      
    // variables
    int fuerza = 0;
    
    // bienvenidos a la app
    
    Console.WriteLine("Bienvenido a miniApp para fuerza.");
    
    // estructura loop
    
    for (int i= 0; i<= 4; i++)
     {
        Console.WriteLine("ingrese cantidad de fuerza del 1 al 5: " + " luego presionar enter");
        
        fuerza = Int32.Parse(Console.ReadLine());
        
     
        if (fuerza == 1){
            Console.WriteLine("\ncebra");
        }
        if (fuerza == 5){
            Console.WriteLine("\nelefante");
        }
        if (fuerza == 4){
            Console.WriteLine("\nleón");
        }
        if (fuerza == 3){
            Console.WriteLine("\nhipopotamo");
        }
        if (fuerza == 2){
            Console.WriteLine("\nhienas");    
        }
     }
  }
}