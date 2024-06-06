/******************************************************************************

Autor:          Matias Florez A.
Fecha:          06-06-2024
Descripción:    Toy Story
     Los juguetes de Andy están 
     jugando a las escondidas. Pide al 
     usuario las ubicaciones donde buscar 
     y usa estructuras "si" para determinar 
     si los juguetes están en la ubicación 
     correcta o no. Reportar la cantidad 
     total de juguetes que fueron encontrados 
     al finalizar 4 rondas.

*******************************************************************************/
using System;

class HelloWorld {
    static void Main() {
        // Variables
        int juguetesEncontrados = 0;
        
        // Estructura repetitiva o cíclica
        for (int i = 0; i < 4; i++) { // 4 rondas
            
            // Preguntar ubicaciones al usuario
            Console.WriteLine("Ronda " + (i+1) + ": ¿Dónde deberíamos buscar?");
            Console.WriteLine("Opciones: habitación, sala de estar, cocina, baño, atico");
            string ubicacion = Console.ReadLine().ToLower();
            
            // Validar ubicaciones con estructura IF
            if (ubicacion == "habitacion") {
                Console.WriteLine("¡Encontramos dos juguete en la habitacion!");
                juguetesEncontrados++;
                juguetesEncontrados++;
            }
            else if (ubicacion == "sala de estar") {
                Console.WriteLine("No hay juguetes en la sala de estar.");
            }
            else if (ubicacion == "cocina") {
                Console.WriteLine("No hay juguetes en la cocina.");
            }
            else if (ubicacion == "baño") {
                Console.WriteLine("¡Encontramos un juguete en el baño!");
                juguetesEncontrados++;
            }
            else if (ubicacion == "atico") {
                Console.WriteLine("No hay juguetes en el atico");
            }
            else {
                Console.WriteLine("Ubicación no válida.");
            }
        }
        
        // Mostrar juguetes encontrados
        Console.WriteLine("Total de juguetes encontrados: " + juguetesEncontrados);
    }
}
