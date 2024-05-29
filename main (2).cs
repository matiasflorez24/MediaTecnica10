/******************************************************************************
Autor: Matias Florez A.
Fecha: 29-05-2024
Descirpción:
******
    App con Menú
******
    Se solicita creear una minicalculadora que realice:
    - Suma
    - Resta
    - Multiplicación
    - División
    Debe terminar la ejecución al usuario elegir opción "Salir"
*******************************************************************************/
using System;
using System.Threading;
class programa {
  static void Main(string[] args) {
    // 1 Pantalla bienvenidos (imagen ASCII)
    Console.WriteLine("           _       _           _            _           _  ");               
    Console.WriteLine(" _ __ ___ (_)_ __ (_) ___ __ _| | ___ _   _| | __ _  __| | ___  _ __ __ _  ");
    Console.WriteLine("| '_ ` _  | | '_  | |/ __/ _` | |/ __| | | | |/ _` |/ _` |/ _  | '__/ _` | ");
    Console.WriteLine("| | | | | | | | | | | (_| (_| | | (__| |_| | | (_| | (_| | (_) | | | (_| | ");
    Console.WriteLine("|_| |_| |_|_|_| |_|_|___ __,_ |_|___||__,_ |_|__,_ _|__,_  ___/|_|   __,_| ");
    Thread.Sleep(3000); // 3 segundos = 3000 milisegundos
    Console.Clear(); 
    // 2 Mostrar menú de opción
    Console.WriteLine("Menú de opciones");
    Console.WriteLine("Seleccionar la opción deseada:");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Resta");
    Console.WriteLine("3. Multiplicación");
    Console.WriteLine("4. Divisón");
    Console.WriteLine("5. Salir");

    // 3 capturar opción elegida por usuario
    Console.Write("Digitar opción deseada: ");
    int opcion = Int32.Parse(Console.ReadLine());
    if (opcion == 5){
        goto Salir;
    }
    // 3.5 capturar los números elegidos por el usuario
    Console.Write("\nDigitar numero 1: ");
    int numero1 = Int32.Parse(Console.ReadLine());
    Console.Write("\nDigitar numero 2: ");
    int numero2 = Int32.Parse(Console.ReadLine());
    
    // 4 Validar opción elegida
    if( opcion == 1){
        Console.WriteLine("La suma es: " + (numero1+numero2));
    }
    
    if( opcion == 2){
        Console.WriteLine("La resta es: " + (numero1-numero2));
    }
    
    if( opcion == 3){
        Console.WriteLine("La multiplicación es: " + (numero1*numero2));
    }
    
    if( opcion == 4){
        if ( numero1 != 0 && numero2 !=0){
            Console.WriteLine("La división es: " + (numero1/numero2));    
        }
        else{
            Console.WriteLine("No se puede dividir por cero.");    
        }
    }


       // 5 Mostrar resultado o finalizar ejecución
    Salir:
        Console.WriteLine("Saliendo del programa...");

    // 5 Mostrar resultado o finalizar ejecución

    }
}