using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace KhumaloRecipeApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Recipe RecipeNO = new Recipe();
            while (true)
            {
                Console.WriteLine("Please enter 1 to enter recipe details");
                Console.WriteLine("Please Enter 2 to display recipe");
                Console.WriteLine("Please enter 3 to scale recipe");
                Console.WriteLine("Please enter 4 to reset the quantities");
                Console.WriteLine("Please enter 5 to clear rge recipe ");
                Console.WriteLine("Please enter 6 to exit the program");
            }
            String option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    RecipeNO.DetailsNeeded();
                    break;
                case "2":
                    RecipeNO.DisplayTheRecipe();
                    break;
                case "3":
                    Console.Write("Please insert scaling factor(0.5,2,3):");

                    double factor = double.Parse(Console.ReadLine());
                    RecipeNO.TheScaleOfRecipe(factor);
                    break;
                case "4":
                    RecipeNO.ResettingQuantities();
                    break;
                case "5":
                    RecipeNO.ClearRecipe();
                    break;
                case "6":
                    Console.WriteLine("Thank you an goodbye.......");
                    return;
                default:
                    Console.WriteLine("Opps wrong choice." +
                        "Please enter a correct option");
                    break;
            }
        }
        class Recipe {
            private String[] NoIngredients;
            private double[] NoQuantities;
            private string[] NoUnits;
            private string[] steps;

            public RecipeNo()
            {
                NoIngredients = new String[0];
                NoQuantities = new double[0];
                NoUnits = new string[0];
                steps = new string[0];
            }
            public void DetailsNeeded()
            {

                Console.Write("Enter the number of needed ingredients:");
                int ingredients = int.Parse(Console.ReadLine());

                NoIngredients = new String[ingredients];
                NoQuantities = new double[ingredients];
                NoUnits = new string[ingredients];


                for (int i = 0; i < ingredients; i++)
                {
                    Console.Write($"Enter details for ingedients to store #{i + 1}:");
                    Console.Write("Name:");
                    NoIngredients[i] = Console.ReadLine();
                    Console.Write("Quatinity :");
                    NoQuantities[i] = double.Parse(Console.ReadLine());
                    Console.Write("Units Measurement: ");
                    NoUnits[i] = Console.ReadLine();
                }

                Console.Write("Enter the number of steps:");
                int NoSteps = int.Parse(Console.ReadLine());

                steps = new String[NoSteps];


                for (int i = 0; i < NoSteps; i++)
                {
                    Console.Write($"Please enter a step #{i + 1}:");
                    steps[i] = Console.ReadLine();
                }
            }

            public void DisplayTheRecipe()
            {


                Console.WriteLine("Ingredients:");
                for (int i = 0; i < NoIngredients.Length; i++)
                {
                    Console.WriteLine($"-{NoQuantities[i]}{NoUnits[i]} of{NoQuantities[i]}");
                }

                Console.WriteLine("Number of steps:");
                for (int i = 0; i < steps.Length; i++)
                {
                    Console.WriteLine($"-{steps[i]}");
                }
            }

            public void TheScaleOfRecipe(double factor)
            {


                for (int i = 0; i < NoQuantities.Length; i++)
                {
                    NoQuantities[i] *= factor;
                }
            }

            public void ResettingQuantities()
            {


                for (int i = 0; i < NoQuantities.Length; i++)
                {
                    NoQuantities[i] /= 2;
                }
            }

            public void ClearRecipe()
            {

                NoIngredients = new string[0];
                NoQuantities = new double[0];
                NoUnits = new string[0];
                steps = new string[0];
            }

        }

    }




}
    

