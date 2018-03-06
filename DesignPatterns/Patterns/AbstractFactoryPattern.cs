using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns
{
    // klient przyjmuje abstrakcje fabryki. dzieki temu możemy przekazać mu dowolną konkretną fabrykę dziedziczącą po tej abstrakcji
    // abstrakcyjna klasa tworzy abstrakcyjne obiekty
    // w konkretnych klasach trzeba stworzyć konkretne obiekty OVERRIDUJAC abstrakcyjne metody tworzenia

    // Abstract class
    abstract class FoodFactory
    {
        public abstract Food CreateFood();
        public abstract Drink CreateDrink();
    }

    // concrete factories
    class GoodFoodFactory : FoodFactory
    {
        public override Food CreateFood()
        {
            return new Hamburger();
        }

        public override Drink CreateDrink()
        {
            return new Cola();
        }
    }

    class HealthyFoodFactory : FoodFactory
    {
        public override Food CreateFood()
        {
            return new Salad();
        }

        public override Drink CreateDrink()
        {
            return new Water();
        }
    }

    // classes
    abstract class Food
    {
        
    }

    abstract class Drink
    {

    }

    class Hamburger : Food
    {

    }

    class Salad : Food
    {

    }

    class Cola : Drink
    {

    }

    class Water : Drink
    {

    }

    // factory user
    class Meal
    {
        public Food _food;
        public Drink _drink;

        public Meal(FoodFactory factory)
        {
            _food = factory.CreateFood();
            _drink = factory.CreateDrink();
        }       
    }

    // test - set the breakpoint on ReadKey and see the meals
    public static class AbstractFactoryPattern
    {
        public static void Run()
        {
            FoodFactory goodFoodFacory = new GoodFoodFactory();
            Meal m1 = new Meal(goodFoodFacory);

            FoodFactory healthyFoodFactory = new HealthyFoodFactory();
            Meal m2 = new Meal(healthyFoodFactory);

            Console.ReadKey();
        }
    }

}
