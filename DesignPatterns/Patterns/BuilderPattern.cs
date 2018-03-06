using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns
{
    // podobny do fabryki potrzebny wtedy, gdy obiekt nie może być stworzony w jednym kroku (w factory może) wtedy builder ukrywa skomplikowaną implementację tworzenia. Możemy overridować poszczególne kroki
    // builder dziedziczy po abstrakcyjnej klasie z abstrakcyjnymi krokami
    // trzeba overridować kroki
    // taki konkretny builder można przekazać do klienta, który przyjmuje abstrakcyjny builder

    // builder user
    class Kitchen
    {
        public Soup Cook(SoupBuilder soupBuilder)
        {
            soupBuilder.AddWater();
            soupBuilder.AddBase();
            soupBuilder.AddSeasoning();
            return soupBuilder.Serve();
        }

    }
    // builder
    abstract class SoupBuilder
    {
        protected Soup soup;

        public Soup Soup
        {
            get { return soup; }
        }

        // abstract build methods
        public abstract void AddWater();
        public abstract void AddBase();
        public abstract void AddSeasoning();

        public abstract Soup Serve();
    }

    class TomatoSoupBuilder : SoupBuilder
    {
        public TomatoSoupBuilder()
        {
            soup = new Soup("tomato soup");
        }

        public override void AddWater()
        {
            soup.ingridients["water"] = "2l";
        }

        public override void AddBase()
        {
            soup.ingridients["base"] = "tomatoes";
        }

        public override void AddSeasoning()
        {
            soup.ingridients["seasoning"] = "salt";
        }

        public override Soup Serve()
        {
            return soup;
        }
    }

    class CornSoupBuilder : SoupBuilder
    {
        public CornSoupBuilder()
        {
            soup = new Soup("corn soup");
        }

        public override void AddWater()
        {
            soup.ingridients["water"] = "1l";
        }

        public override void AddBase()
        {
            soup.ingridients["base"] = "corn";
        }

        public override void AddSeasoning()
        {
            soup.ingridients["seasoning"] = "pepper";
        }

        public override Soup Serve()
        {
            return soup;
        }
    }

    class Soup
    {
        private string _name;
        public Dictionary<string, string> ingridients = new Dictionary<string, string>();

        public Soup(string name)
        {
            _name = name;
        }
    }

    // test
    public static class BuilderPattern
    {
        public static void Run()
        {
            Kitchen kitchen = new Kitchen();

            var tomatoSoup = kitchen.Cook(new TomatoSoupBuilder());

            var cornSoup = kitchen.Cook(new CornSoupBuilder());

            Console.ReadKey();
        }
    }
}
