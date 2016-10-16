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
	Tarea Corta 5
	Estudiante: [Johnnatan Segura Araya]
	
	Enunciado:
	Haga una funcion que compare versiones, retornando -1 si el primer numero es mayor, 1 si el segundo numero es mayor y 0 y son iguales.
	Pueden asumir que los strings solo contienen numeros y el caracter '.'
	No hay un limite para la cantidad de subversiones que se pueden enviar: 1.1.1.1.1.1.1.1.1.1 es valido.
	0.1 < 1.0 < 1.0.1
	
*/

//Your code starts here

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TareasCortas
{
    class TC05
    {
        public int compararVersiones (string version1,string version2)
        {
            /*decidí utilizar la clase Version, y luego comparar las dos versiones con le metodo CompareTo porque eso me elimina el problema de comparar cada substring
             * de cada cadena sin que se salga del rango si alguna version tiene mas numeros que la otra version
             */
            int retorno = 0;
            Version version_1 = new Version(version1); // asigna a la variable de tipo Version el primer parametro
            Version version_2 = new Version(version2); // asigna a la variable de tipo Version el segundo parametro

            switch (version_2.CompareTo(version_1)) //compara las dos versiones y devuelve un entero dependiendo del resultado de la comparacion 
            {                                       //que se sera utilizado para entra a alguno de los casos del switch


                case 0: retorno = 0; break;         //si ls versiones son iguales devuelve cero
                case 1: retorno = 1; break;         //si "version_1" es mayor que "version_2" devuelve -1
                case -1: retorno = -1; break;       //si "version_1" es menor que "version_2" devuelve 1
            }
            return retorno; 
        }
    }
}