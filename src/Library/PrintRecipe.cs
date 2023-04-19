using System;
using System.Collections;
using System.Linq;
using Full_GRASP_And_SOLID.Library;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter // hicimos esta clase a parte por el  patrón srp, que dice que cada clase debe tener una responsabilidad única y hacerla bien por eso creamos un nueva clase exclusivamente para imprimir los datos de la receta
    {
        public static void PrintRecipe(Recipe recipe)
{
    Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
    foreach (Step step in recipe.GetSteps())
    {
        Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
            $"usando '{step.Equipment.Description}' durante {step.Time}");
    }
}
    }
}
