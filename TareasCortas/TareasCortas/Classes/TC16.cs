/*
Tarea Corta
Las tareas cortas consisten de resolver simples problemas de programacion, para buscar que los estudiantes 
desarrollen su logica de programacion y logica matematica.
Cada tarea tendra un id, el metodo de entrega sera el siguiente:
1. Los estudiantes deben crear un proyecto en github, al que subiran todas las tareas que deseen sean evaluadas.
2. Los estudiantes van a crear un board en waffle, las tareas que esten en waffle seran revisadas por el profesor.
3. Las tareas serán asignadas al profesron una vez que el código sea terminado por el estudiante, en ese momento el profesor procederá a revisarlas y asignarles una calificación
4. Las tareas son simples, por lo que se requerirá que el entregable sea un solo archivo .cs, en dicho archivo debe estar el presente encabezado
5. El estudiante debe rellenar el encabezado posterior al presente con sus datos personales.\\
6. Junto con el codigo, en comentarios de la documentacion interna debe haber una explicacion de porque escogieron esa solucion, y porque creen que esa es la solucion optima
7. De existir otras soluciones, especificar porque no se utilizaron.
8. Pueden utilizar cualquier funcion que las librerias de .Net ofrezcan, pero deben especificar porque la utilizacion de esas librerias mejoran el rendimiento de su solucion.
*/

/*
	Tarea Corta 1
	Estudiante: [Johnnatan Segura Araya]
	
	Enunciado:
	Haga una funcion que imprima los primeros 100 elementos de la secuencia de fibonacci
	Fibonacci -> https://en.wikipedia.org/wiki/Fibonacci_number
*/

//Your code starts here

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TareasCortas
{
    class TC16
    {
        public void fibonacci()
        {
            //se declaran las variables de tipo "BigInteger" para que se les pueda asignar numeros de gran tamaño
            BigInteger numeroTrasanterior = 0;
            BigInteger numeroAnterior = 1;
            BigInteger numeroFibonacci = 0;

            Console.WriteLine("{0}", numeroTrasanterior);
            Console.WriteLine("{0}", numeroAnterior);

            for (int contador = 2; contador < 100; contador++) //recorre la cantidad de veces que queremos en la secuencia fibonacci
            {
                numeroFibonacci = numeroTrasanterior + numeroAnterior;
                Console.WriteLine("{0}", numeroFibonacci); // se imprimen los numeros de la secuencia

                numeroTrasanterior = numeroAnterior; //a la variable "numeroTrasanterior" se le asigna el valor de la varible "numeroAnterior"
                numeroAnterior = numeroFibonacci;    //a la variable "numeroAnterior" se le asigna el valor de la variable "numeroFibonacci", para convertirse en el numero anterior de la siguiente secuencia
            }
            Console.ReadKey();
        }
    }
}