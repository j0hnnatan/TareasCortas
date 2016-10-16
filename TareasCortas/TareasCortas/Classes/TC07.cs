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
	Tarea Corta 7
	Estudiante: [Johnnatan Segura Araya]
	
	Enunciado:
	Dado un arreglo de longitud N, retornar un arreglo que contenga los K caracteres mas frecuentes.
	Ejemplo:
	[1,2,3,4,3,2,5], 2 -> Queremos los dos caracteres mas frecuentes del arrelgo
	Resultado -> [2,3] 
*/

//Your code starts here

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasCortas
{
    class TC07
    {
        public object caracteresFrecuetes(object[] arreglo, int k)
        {
            object[] resultado = new object[k]; // variable donde vamos a almacenar los 'K' caracteres mas frecuentes, y que luego retornaremos.

            //variable tipo Dictionary donde vamos a almacenar todos caracteres del arreglo que pasamos por parametro.
            //donde guardaremos tanto los caracteres como la cantidad de veces que cada caracter se repite en el arreglo
            Dictionary<object, int> caracteresRepetidos = new Dictionary<object, int>();
            int contador = 0;

            foreach (object caracter in arreglo) //aqui recorremos todo el arreglo
            {
                if (caracteresRepetidos.ContainsKey(caracter)) //preguntamos si el caracter del arreglo en el indice especifico existe en el diccionario
                {
                    caracteresRepetidos[caracter]++;            //si el caracter exite, se le suma 1 al 'value' que en este caso será el contador de dicho caracter
                }
                else
                {
                    caracteresRepetidos.Add(caracter, 1);       //si el caracter NO existe, se agrega el caracter al diccionario
                }
            }

            //a la variable "diccionarioOrdenDescendiente" se le pasan los datos del diccionario(caracteresRepetidos), pero en orden descendiente
            var diccionarioOrdenDescendiente = from Pair in caracteresRepetidos orderby Pair.Value descending select Pair;
            

            foreach (var item in diccionarioOrdenDescendiente) //recorremos el diccionario de orden descendiente
            {
                if(contador < k)                           //para obtener los 'K' caracteres, utilizamos un contador que nos permite obtener el caracter
                {                                           //en el indice respectivo del diccionario(item),
                    resultado[contador] = item.Key;         //almacenamos los 'K' cantidad de caracteres mas frecuentes en la variable "resultado"
                    
                }
                contador++;
            }
            return resultado;
        }  
    }
}