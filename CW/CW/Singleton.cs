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
    }
}
