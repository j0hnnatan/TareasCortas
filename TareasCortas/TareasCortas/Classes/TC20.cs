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
	Identificador de numeros primos, escriba una funcion que indique si un numero recibido es primo o no, tome en cuenta que el numero recibido estará en un rago de 
	1 a 5000.
*/

//Your code starts here

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasCortas
{
    class TC20
    {
        public void numerosPrimos (int numero)
        {
            bool esPrimo = true;
            int contadorDivisores = 0;

            for (int divisor = 1; divisor <= numero; divisor++) //
            {
                if (numero % divisor == 0)  //preguntamos si el numero es divisible entre la variable "divisor"
                {
                    contadorDivisores++;  //si el numero es divisible entre la variable "divisor" se aunmenta en uno el contador de divisores

                    if (contadorDivisores > 2)  //preguntamos si el contador de divisores es mayor a 2,
                    {                           // esto porque un numero primo solo puede tener dos divisores (el 1 y el mismo numero)

                        esPrimo = false; //si existen mas de dos divisores el numero NO es primo, y se le asigna un 'false' a la variable "esPrimo"
                        break;           //por tanto no es necesario realizar mas divisiones.
                    }                    
                }
            }

            //imprimimos el numero, y si dicho numero es primo o no
            //segun la variable "esPrimo"
            if (esPrimo)
            {
                Console.WriteLine("El numero {0} es primo", numero);
            }
            else
            {
                Console.WriteLine("El numero {0} no es primo",numero);
            }
            Console.ReadKey();
        }
    }
}