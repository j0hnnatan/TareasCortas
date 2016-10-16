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
	Tarea Corta 4
	Estudiante: [Johnnatan Segura Araya]
	
	Enunciado:
	Haga una funcion que identifique si una cadena de caracteres es un palindromo. 
	La funcion debe recibir un string con la palabra y retornar un booleano que indique si es un palindromo o no
	Palindromo: https://es.wikipedia.org/wiki/Pal%C3%ADndromo
*/

//Your code starts here

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasCortas
{
    class TC04
    {
        public bool palindromo(string palabra)
        {
            /* Decidí escoger esta solucion porque me parecio efectiva y simple, ademas que utiliza poco codigo y mas facil entender lo que se quiere hacer.
               en vez de comparar caracter por caracter por me parecio mas dificil de programar.
             */
            string palabraInvertida = new string(palabra.Reverse().ToArray()); // se le asigna a la variable el string por parametro pero invertido.

            if (palabra.ToLower().Equals(palabraInvertida.ToLower())) // se comparan las dos variables,"palabraInvertida" y "palabra".
            {                                                         //poniendo los caracteres de ambas variables en minusculas para que compare si los caracteres son iguales  
                return true;                                          // sin importar si estos estan en mayuscula o minuscula
            }
            else  //si son igules retorna 'true', pero si son diferentes retorna 'false'.
            {
                return false;
            }            
        }
    }
}