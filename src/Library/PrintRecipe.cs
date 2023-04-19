using System;
using System.Collections;
using System.Linq;
using Full_GRASP_And_SOLID.Library;

namespace Full_GRASP_And_SOLID
{
    public class ConsolePrinter
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