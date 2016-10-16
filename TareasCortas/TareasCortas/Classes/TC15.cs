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
	Tarea Corta 15
	Estudiante: [Johnnatan Segura Araya]
	
	Enunciado:
	Encontrar duplicado: Usted va a recibir un arreglo de 100 elementos, que contiene numeros del 1 al 100, exactamente un elemento esta duplicado, 
	debe retornar el numero duplicado en el arreglo
*/

//Your code starts here

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareasCortas
{
    class TC15
    {
        public int numeroDuplicado (int[] arreglo)
        {
            int resultado = 0;

            List<int> elementosArreglo = new List<int>();

            foreach (int elemento in arreglo) //aqui recorremos todo el arreglo
            {
                if (elementosArreglo.Contains(elemento)) //preguntamos si el elemento del arreglo en el indice especifico existe en la lista
                {
                    resultado = elemento;               //si el caracter exite, se le asigna a la variable "resultado" el elemento duplicado
                }
                else
                {
                    elementosArreglo.Add(elemento);     //si el elemento NO existe, se agrega el elemento a la lista
                }
            }     
            return resultado;
        }
    }
}