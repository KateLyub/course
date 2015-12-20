using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW
{
    public class Singleton
    {
        protected Singleton() { }

        private static Singleton single = new Singleton();

        public static Singleton GetInstance()
        {
            return single;
        }

        public virtual void Walking(Wo_Man wm)
        {
            Console.WriteLine("Ходит как человек.");
        }

        public virtual void Eating(Wo_Man wm)
        {
            Console.WriteLine("Ест как человек.");
        }

        public virtual void Dressing(Wo_Man wm)
        {
            Console.WriteLine("Одевается как человек.");
        }
    }
}
