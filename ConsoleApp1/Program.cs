using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Guia 0 Ej 1.1
// Crear una aplicación de consola que…
//Presente el mensaje “Hola mundo” al usuario, espere la presión de una tecla y finalice.Utilizar esta técnica de aquí en más de manera que puedan verse los resultados antes de que se cierre la ventana del programa.
//Solicite el ingreso de un texto cualquiera y lo presente nuevamente al usuario.

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hola Mundo!");
//            Console.ReadLine();

//        }

//    }
//    }





// Guia 0 Ej 1.2
// Crear una aplicación de consola que…
//Solicite el ingreso de un texto cualquiera y lo presente nuevamente al usuario.

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un texto");
            string texto = Console.ReadLine();
            Console.WriteLine(texto);
            Console.ReadLine();

        }

    }
}