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
	Tarea Corta 19
	Estudiante: [Johnnatan Segura Araya]
	
	Enunciado:
	Retorne la combinacion de los elementos unicos de dos arreglos de enteros
	Ejemplo
	[1,2,3,4,5,6],[5,6,7,8,9] -> [1,2,3,4,5,6,7,8,9]
	
*/

//Your code starts here

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasCortas
{
    class TC19
    {
        public int[] elementosUnicos(int[] arreglo_1, int[] arreglo_2)
        {
            //variable tipo List donde vamos a almacenar todos caracteres del arreglo que pasamos por parametro.
            List<int> elementos_unicos = new List<int>();

            foreach (var elemento in arreglo_1) //recorremos el primer arreglo
            {
                if (!elementos_unicos.Contains(elemento)) //preguntamos si el elemento no esta en la lista
                {
                    elementos_unicos.Add(elemento); //si el elemento NO se econtro, se agrega el elemento a la lista
                }
            }

            foreach (var elemento in arreglo_2) //recorremos el segundo arreglo
            {
                if (!elementos_unicos.Contains(elemento)) //preguntamos si el elemento no esta en la lista
                {
                    elementos_unicos.Add(elemento); //si el elemento NO se econtro, se agrega el elemento a la lista
                }
            }

            //a la variable "listaOrdenAscendiente" se le pasan los datos de la lista(elementos_unicos), pero en orden ascendiente
            var listaOrdenAscendiente = from Pair in elementos_unicos orderby Pair ascending select Pair;

            //se le asingan los numeros de la lista al nuevo arreglo
            int[] resultado = listaOrdenAscendiente.ToArray();

            return resultado;
        }
    }
}