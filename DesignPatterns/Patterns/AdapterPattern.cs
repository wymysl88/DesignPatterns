using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.AdapterPattern
{
    // adapter maps the interface of one class (new app) onto another (old)


    public static class AdapterPattern
    {
        public static void Run()
        {
            Adapter a = new Adapter();
            a.DoOldWork();
            Console.ReadKey();
        }
    }

    class OldApp
    {
        public virtual void DoOldWork()
        {
            Console.WriteLine("Old app working");
        }
    }

    class Adapter : OldApp
    {
        private NewApp _newApp = new NewApp();

        // client can call new app's method in a way he would call the old app's method
        public override void DoOldWork()
        {
            _newApp.DoNewWork();
        }
    }

    class NewApp
    {
        public void DoNewWork()
        {
            Console.Write("New app working");
        }
    }
}
