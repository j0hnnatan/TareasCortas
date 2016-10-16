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
	Tarea Corta 6
	Estudiante: [Johnnatan Segura Araya]
	
	Enunciado:
	El palindromo mas corto, 
	Dado un string S, usted debe formar un palindromo al agregarle caracteres al final, forme el palindromo mas corto posible en base al string S recibido
	"aace" -> aacecaa
	"abcd" -> "abcdcba"
*/

//Your code starts here

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasCortas
{
    class TC06
    {
        public string nuevopalindromo (string cadena)
        {
            string cadenaInvertida = new string(cadena.Reverse().ToArray()); //se invierte la cadena que pasamos por parametro y la asignamos a la variable "cadenaInvertida"

            //aqui formamos el palindromo mas corto posible 
            //concatenando la cadena que pasamos por parametro 
            //y la variable "cadenaInvertida" pero quitandole la primera letra de esta variable, que en este caso seria igual a la  primera letra de la cadena que pasamos por parametro
            //esto para formar el palindromo mas corto
            string nuevaCadenaPalindromo = cadena + cadenaInvertida.TrimStart(cadena[cadena.Length -1]);
                                                                        //   ^      ^      ^
            return nuevaCadenaPalindromo;                               //   |      |      |
                                                                        // primera letra de la cadena que pasamos por parametro
        }
    }
}