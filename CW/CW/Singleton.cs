using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW
{
    public class Singleton
    {
        private static Singleton instance;
        public static Singleton Instance
        {
            get { return instance ?? (instance = new Singleton()); }
        }
        protected Singleton() { }
    }
}
