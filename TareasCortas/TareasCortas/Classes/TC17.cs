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
	Tarea Corta 17
	Estudiante: [Johnnatan Segura Araya]
	
	Enunciado:
	Dado un string S, encuentre todos los caracteres repetidos en el string, imprima una linea con cada caracter repetido y cuantas veces aparece
	Ejemplo:
	"abcdabeacd"
	>a,3
	>b,2
	>c,2
	>d,2
*/

//Your code starts here

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasCortas
{
    class TC17
    {
        public void caracteresRepetidos(string cadena)
        {
            //variable tipo Dictionary donde vamos a almacenar todos caracteres de la cadena que pasamos por parametro.
            //donde guardaremos tanto los caracteres como la cantidad de veces que cada caracter se repite en el arreglo
            Dictionary<object, int> caracteresRepetidos = new Dictionary<object, int>();

            foreach (object caracter in cadena) //aqui recorremos todo la cadena, caracter por caracter
            {
                if (caracteresRepetidos.ContainsKey(caracter)) //preguntamos si el caracter de la cadena existe en el diccionario
                {
                    caracteresRepetidos[caracter]++;            //si el caracter exite, se le suma 1 al 'value' que en este caso será el contador de dicho caracter
                }
                else
                {
                    caracteresRepetidos.Add(caracter, 1);       //si el caracter NO existe, se agrega el caracter al diccionario
                }
            }

            foreach (var item in caracteresRepetidos) //recorremos el diccionario 
            {
                //preguntamos si el caracter(item.value) de la cadena esta repetido,
                //osea el contador de dicho caracter(item.key) es mayor que 1,
                if (caracteresRepetidos[item.Key] > 1)   
                {                                       
                    Console.WriteLine("{0} => {1}",item.Key,item.Value); // se imprime el caracter y las veces que se repite en la cadena
                }
            }
            Console.ReadKey();
        }
    }
}