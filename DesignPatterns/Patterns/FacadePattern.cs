using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.FacadePattern
{
    public static class FacadePattern
    {
        public static void Run()
        {
            SmartHouse sh = new SmartHouse();
            sh.PrepareForArrival();
        }            
    }

    // complex system elements
    class Radiator
    {
        public Radiator()
        {

        }

        public void TurnOn()
        {
            Console.Write("Radiator turned on");
        }
    }

    class Light
    {
        public Light()
        {

        }

        public void TurnOn()
        {
            Console.WriteLine("Lights turned on");
        }
    }

    class Alarm
    {
        public Alarm()
        {

        }

        public void TurnOff()
        {
            Console.WriteLine("Alarms turned off");
        }
    }

    // Facade - simplified access to complex system
    class SmartHouse
    {
        private Radiator _radiator = new Radiator();
        private Light _light = new Light();
        private Alarm _alarm = new Alarm();

        public void PrepareForArrival()
        {
            _radiator.TurnOn();
            _light.TurnOn();
            _alarm.TurnOff();
        }
    }
}
