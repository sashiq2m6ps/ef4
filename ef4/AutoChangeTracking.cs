using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef4
{
    class AutoChangeTracking
    {
        public void atc()
        {



            EfCoreEntities1 db = new EfCoreEntities1();
            Person newperson = new Person() { PId = "16", Name = "aa", Email = "svs", Age = "44" };
            db.Persons.Add(newperson);
            foreach(var tracker in db.ChangeTracker.Entries<Person>())
            {
                Console.WriteLine(tracker.State);
            }
            Console.ReadKey();


                }
    }
}
