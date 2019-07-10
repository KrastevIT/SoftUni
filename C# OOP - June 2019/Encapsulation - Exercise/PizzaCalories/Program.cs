using System;

namespace PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaArgs = Console.ReadLine().Split();

                string pizzaName = pizzaArgs[1];

                string[] inputArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string flourType = inputArgs[1];
                string bakingTechnique = inputArgs[2];
                double weight = double.Parse(inputArgs[3]);

                Dough dough = new Dough(flourType, bakingTechnique, weight);

                Pizza pizza = new Pizza(pizzaName, dough);

                string inputLine = Console.ReadLine();

                while (inputLine != "END")
                {

                    string[] toppingArgs = inputLine.Split();

                    string toppingType = toppingArgs[1];
                    double weightTopping = double.Parse(toppingArgs[2]);

                    Topping topping = new Topping(toppingType, weightTopping);

                    pizza.AddTopping(topping);

                    inputLine = Console.ReadLine();
                }

                Console.WriteLine($"{pizza.Name} - {pizza.GetTotalCalories().ToString("F2")} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
