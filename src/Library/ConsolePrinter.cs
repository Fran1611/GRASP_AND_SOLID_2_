using System;

/*
Single Responsibility Principle
Lo podemos definir de dos posibles maneras:
- una clase o metodo no tendria mas de una razon para cambiar
- una clase o metodo tendria que tener una sola responsabilidad
Si una clase tiene varias responsabilidades habria varias razones para modificarla.

Nuestra clase ConsolePrinter tiene la unica responsabilidad de imprimir la receta por consola.
Esto ayuda a reducir la complejidad del codigo, y que sea mas sencillo de mantener y leer. 
*/

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        // Metodo para imprimir la receta por consola.
        public void PrintRecipe(string recipeToPrint)
        {
            Console.WriteLine(recipeToPrint);
        }
    }
}
