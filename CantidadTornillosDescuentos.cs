/******************************************************************************
Autor:              Matias Florez A.
Fecha:              2024-05-22
Descripción:
Tony Stark, Iron Man, quiere saber cuánto dinero debe
tener para comprar X tornillos c/u a $300, pero en la tienda 
le dan descuentos según cantidad comprada.
Crea un algoritmo que ayude a calcular si compra:
    1 sin descuento,
    5 descuento del 30%,
    10 descuento del 50%
*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      
        int cantidadTornillos;
        int valorTornillos;
        
        Console.WriteLine("Digite la cantidad de los tornillos: ");
        cantidadTornillos = Int32.Parse(Console.ReadLine());
        valorTornillos = 300;
        
        //validación
        if(valorTornillos >= 1){ 
        if(valorTornillos >= 5){ 
        if(valorTornillos >= 10){ 
        Console.WriteLine("la cantidad que usted va a pagar por los tornillos es: " + (valorTornillos * 0));
        Console.WriteLine("la cantidad que usted va a pagar por los tornillos es: " + (valorTornillos * 0.70)); 
        Console.WriteLine("la cantidad que usted va a pagar por los tornillos es: " + (valorTornillos * 0.50)); 
        
    else{ 
     Console.WriteLine("cantidad que usted va a pagar por los tornillos" + (valorTornillos + 0)); 
    }
    else{ 
     Console.WriteLine("cantidad que usted va a pagar por los tornillos" + (valorTornillos + 0.70)); 
    }
    Console.WriteLine("Finalizada la ejecución");
         }
        }
      }
    }
