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
	Tarea Corta 10
	Estudiante: [Johnnatan Segura Araya]
	
	Enunciado:
	Inversion de un string: Al recibir un string S, retornar un string cuyas palabras estan invertidas, sin invertir el orden de las palabras.
	"The Sky is Blue" -> "ehT ykS si eulB"
*/

//Your code starts here

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasCortas
{
    class TC10
    {
        public string palabrasInvertidas (string cadena)
        {
            string[] palabras = cadena.Split(' '); //separamos el string que pasamos por parametro, y almacenamos cada palabra en un espacio de un array
            string nuevaCadena = "";   //variable donde se almacena el nuevo string con las palabras invertidas

            //recorremos cada campo del array
            //para invertir cada palabra que se encuentra en cada campo del array
            for (int i = 0; i < palabras.Length; i++)
            {
                //a la variable "palabras_invertidas" se le asigna la palabra almacenada en el indice especifico del campo del array
                //pero dichas palabras las almacena de forma invertida 
                string palabras_invertidas = new string( palabras[i].Reverse().ToArray());

                nuevaCadena += palabras_invertidas +  " "; // se concatena cada palabra invertida
            }
            return nuevaCadena;
        }
    }
}