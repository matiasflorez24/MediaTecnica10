/******************************************************************************
Autor:              Matias Florez A.
Fecha:              2024-05-22
Descripción         programa con decisiones para
                    habilitar votación de personas y
                    descuento matricula estudio.
*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
        //variable
        int edad;
        int valorMatricula;
        //petición de datos
        Console.WriteLine("Digite su edad: ");
        edad = Int32.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite su valor de matricula: ");
        valorMatricula = Int32.Parse(Console.ReadLine());
        //validación
        if ( edad >= 18 ){
            Console.WriteLine("Felicidades, usted puede votar");
            Console.WriteLine("Usted pagará de matricula: " + (valorMatricula * 0.85));
        }
    }
}
