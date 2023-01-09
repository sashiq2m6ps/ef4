using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef4
{
    class lazyloading
    {
        public void Lazy() {
            EfCoreEntities1 db = new EfCoreEntities1();

            foreach(Person p in db.Persons)
            {
                Console.WriteLine("{0}\t{1}", p.PId, p.Name);
                    foreach (employee e in p.employees)
                      Console.WriteLine(e.empname);
            }
 

    }
    }
}
