using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef4
{
    class Program
    {
        static void Main(string[] args)
        {
            //crud cs = new crud();
            //cs.display();
            //lazyloading l = new lazyloading();
            //l.Lazy();
            //eagerloading el = new eagerloading();
            //el.eager();
            //AutoChangeTracking a = new AutoChangeTracking();
            //a.atc();
            RawQueries ra = new RawQueries();
            ra.rq();
        }
    }
}
