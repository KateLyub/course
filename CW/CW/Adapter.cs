using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW
{
    public class Adapter : Singleton
    {
        Man adapteeMan = new Man();
        Woman adapteeWoman = new Woman();


        public override void Walking(Wo_Man wm)
        {
            if (wm is Man)
                adapteeMan.ManWalking();
            else if (wm is Woman)
                adapteeWoman.WomanWalking();
            else
                Console.WriteLine("Непонятная походка");
        }

        public override void Dressing(Wo_Man wm)
        {
            if (wm is Man)
                adapteeMan.ManDressing();
            else if (wm is Woman)
                adapteeWoman.WomanDressing();
            else
                Console.WriteLine("Непонятная одежда");
        }

        public override void Eating(Wo_Man wm)
        {
            if (wm is Man)
                adapteeMan.ManEating();
            else if (wm is Woman)
                adapteeWoman.WomanEating();
            else
                Console.WriteLine("Непонятная еда");
        }

    }
}
