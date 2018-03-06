using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.FactoryMethod
{
    public static class FactoryMethodPattern
    {
        public static void Run()
        {
            var d1 = new DrinkA();
            var d2 = new DrinkB();

            Console.ReadKey();
        }
    }

    abstract class Ingredient
    {
    }

    class Vodka : Ingredient
    {
    }

    class Whisky : Ingredient
    {
    }

    class Tonic : Ingredient
    {
    }

    class Juce : Ingredient
    {
    }

    abstract class Drink
    {
        public List<Ingredient> ingredients = new List<Ingredient>();

        public Drink()
        {
            this.AddIngredients();
        }

        // factory method
        public abstract void AddIngredients();
    }

    class DrinkA : Drink
    {
        // factory method implementation
        public override void AddIngredients()
        {
            ingredients.Add(new Vodka());
            ingredients.Add(new Juce());
        }
    }

    class DrinkB : Drink
    {
        // factory method implementation
        public override void AddIngredients()
        {
            ingredients.Add(new Whisky());
            ingredients.Add(new Tonic());
        }
    } 
}
