using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns
{
    class SingletonPattern
    {
    }


    class Singleton
    {
        private static Singleton _singleton;

        // protected constructor - can't use 'new'
        protected Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if (_singleton == null)
            {
                _singleton = new Singleton();
            }

            return _singleton;           
        }
    }
}
