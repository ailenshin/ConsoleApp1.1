using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Guia 0 Ej 1
//Crear una aplicación de consola que…
//1.	Presente el mensaje “Hola mundo” al usuario, espere la presión de una tecla y finalice.Utilizar esta técnica de aquí en más de manera que puedan verse los resultados antes de que se cierre la ventana del programa.
//2.	Solicite el ingreso de un texto cualquiera y lo presente nuevamente al usuario.


//0.1.1

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hola Mundo!");
//            Console.ReadKey();

//        }

//    }
//}


//0.1.2

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Ingrese un texto");
//            string texto = Console.ReadLine();
//            Console.WriteLine(texto);
//            Console.ReadKey();

//        }

//    }
//}



//Guia 0 Ej 2
//Crear una aplicación de consola que…
//1.	Solicite el ingreso de dos valores enteros(a y b) al usuario y muestre sucesivamente:
//a.La suma
//b.La resta
//c.El producto
//d.La potencia(a elevado a la potencia b)
//e.El módulo(resto) de a/b.
//2.	Solicite el ingreso de dos valores decimales al usuario y muestre sucesivamente:
//a.La suma
//b.La resta
//c.El producto
//d.La potencia(a elevado a la potencia b)
//e.El módulo(resto) de a/b.
//f.A / B
//g.B / A
//Nota: probar especialmente los puntos f y g, utilizando valores enteros y con decimales mezclados.Pueden surgir efectos inesperados.



//0.2.1

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            Console.WriteLine("Ingrese primer numero");
//            int a = int.Parse(Console.ReadLine());
//            Console.WriteLine("Ingrese segundo numero");
//            int b = int.Parse(Console.ReadLine());


//            Console.WriteLine($" Suma = {a + b}");
//            Console.WriteLine($" Resta = {a - b}");
//            Console.WriteLine($" Producto = {a * b}");
//            Console.WriteLine($" Potencia = {Math.Pow(a, b)}");
//            Console.WriteLine($" Modulo = {a % b}");

//            Console.ReadKey();

//        }

//    }
//}




////0.2.2

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            Console.WriteLine("Ingrese primer numero");
//            var a = decimal.Parse(Console.ReadLine());
//            Console.WriteLine("Ingrese segundo numero");
//            var b = decimal.Parse(Console.ReadLine());

//            Console.WriteLine($" Suma = {a + b}");
//            Console.WriteLine($" Resta = {a - b}");
//            Console.WriteLine($" Producto = {a * b}");
//            Console.WriteLine($" Potencia = {Math.Pow(Convert.ToDouble(a), Convert.ToDouble(b))}");
//            Console.WriteLine($" Modulo = {a % b}");
//            Console.WriteLine($" A/B = {a / b}");
//            Console.WriteLine($" B/A = {b / a}");

//            Console.ReadKey();

//        }

//    }
//}



//Guia 0 Ej 3
//3.	Manejo de cadenas
//Crear una aplicación de consola que…
//1.	Solicite al usuario el ingreso de su apellido y nombre(por separado) y presente el mensaje(por ejemplo): “Su nombre completo es Juan Perez”.
//2.	Solicite al usuario el ingreso de su apellido y nombre(por separado) y presente el mensaje(por ejemplo): “Su nombre es Juan y su apellido Perez.”
//3.	Solicite el ingreso de una cadena al usuario y determine si está vacía o no, presentando un mensaje con el resultado.
//4.	Solicite el ingreso de una cadena al usuario y determine si está está vacía (o contiene sólo caracteres en blanco), o no, y presente un mensaje con el resultado.
//5.	Solicite el ingreso de una cadena al usuario y muestre el mensaje (por ejemplo): “La longitud del texto ingresado es 4”.
//6.	Solicite el ingreso de una cadena al usuario y determine si contiene la letra “a”, presentando un mensaje con el resultado.
//7.	Solicite el ingreso de dos cadenas al usuario y determine si la segunda está incluida dentro de la primera.
//8.	Realice los ejercicios 6 y 7 sin diferenciar mayúsculas de minúsculas.
//9.	Solicite el ingreso de una cadena al usuario. Verifique que contenga al menos 5 caracteres (si no es así, presente un mensaje y finalice) y muestre el resultado de extraer los dos primeros y los dos últimos caracteres de la cadena.
//10.	Solicite el ingreso de una cadena al usuario y elimine de ella todos los espacios en blanco, mostrando el resultado.


//0.3.1
//0.3.2

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            Console.WriteLine("Ingrese su apellido");
//            string apellido = Console.ReadLine();
//            Console.WriteLine("Ingrese su nombre");
//            string nombre = Console.ReadLine();

//            Console.WriteLine($"Su nombre completo es {nombre} {apellido}");
//            Console.WriteLine($"Su nombre es {nombre} y su apellido {apellido}");


//            Console.ReadKey();

//        }

//    }
//}



//0.3.2

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            Console.WriteLine("Ingrese una cadena de texto");
//            string texto = Console.ReadLine();

//            if (string.IsNullOrEmpty (texto))
//            {
//                Console.WriteLine("No hay ingresado una cadena de texto");
//            }
//            else
//            {
//                Console.WriteLine("Ha ingresado una cadena de texto");
//            }

//            Console.ReadKey();

//        }

//    }
//}


//0.3.4
//0.3.5

//namespace ConsoleApp1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            Console.WriteLine("Ingrese una cadena de texto");
//            string texto = Console.ReadLine();

//            if (string.IsNullOrWhiteSpace(texto))
//            {
//                if (string.IsNullOrEmpty(texto))
//                {
//                    Console.WriteLine("No hay ingresado ningún valor");
//                }
//                else
//                {
//                    Console.WriteLine("Solo ha ingresado caracteres en blanco");
//                }

//            }
//            else
//            {
//                Console.WriteLine("Ha ingresado una cadena de texto");
//                Console.WriteLine($"La longitud del texto ingresado es {texto.Length}");
//                if (texto.Contains("a"))
//                {
//                    Console.WriteLine("El texto ingresado contiene la letra a");
//                }
//                else
//                {
//                    Console.WriteLine("El texto ingresado no contiene el caracter a");
//                }

//            }

//            Console.ReadKey();

//        }

//    }
//}



//0.3.6

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Ingrese una cadena de texto");
            string texto = Console.ReadLine();
            Console.WriteLine("Ingrese otra cadena de texto");
            string texto2 = Console.ReadLine();


            if (texto.Contains(texto2))
            {
                Console.WriteLine("Primera cadena incluye segunda cadena");
            }
            else
            {
                Console.WriteLine("Primera cadena no incluye segunda cadena");
            }

            Console.ReadKey();

        }

    }
}