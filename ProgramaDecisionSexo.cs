/******************************************************************************
Autor:              Matias Florez A.
Fecha:              2024-05-22
Descripción         programa con decisiones para
                    determinar el sexo de un usuario

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    // variable
    bool sexoMascilino;
    //capturar información del usuario
    Console.Write("Digite true si es hombre:");
    sexoMascilino = Convert.ToBoolean(Console.ReadLine());
    // validación
    if (sexoMascilino == true)
    { 
     Console.WriteLine("Felicidades, es hombre");
    } 
    else{
        Console.WriteLine("Felicidades, es mujer")
    }
    Console.WriteLine("Finalizada la ejecución");
  }
}
