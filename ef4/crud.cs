using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef4
{
    class crud
    {
        public void display()
        {
            EfCoreEntities1 db = new EfCoreEntities1();
            Person personobj = new Person();
            int opt;
            int id;
            do
            {
                Console.WriteLine("1.new \t 2 .display\t 3.update\t 4.delete\t5.exit");

                Console.Write("enter option:");
                opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("enter id,name ,mail,age:");
                        personobj.PId = (Console.ReadLine());
                        personobj.Name = Console.ReadLine();
                        personobj.Email = Console.ReadLine();
                        personobj.Age = Console.ReadLine();
                        db.Persons.Add(personobj);
                        db.SaveChanges();
                        break;
                    case 2:
                        foreach (Person p in db.selectinto())
                        {
                            Console.WriteLine("{0}  {1}  {2}  {3}", p.PId, p.Name, p.Email, p.Age);
                        }
                        break;
                    case 3:
                        Console.WriteLine("enter id to update");
                        id = Convert.ToInt32(Console.ReadLine());
                        personobj = db.Persons.Find(id);
                        if (personobj == null)
                        {
                            Console.WriteLine("enter validdata");
                        }
                        else
                        {
                            Console.WriteLine("enter modified data id,name ,mail,age");
                            personobj.PId = (Console.ReadLine());
                            personobj.Name = Console.ReadLine();
                            personobj.Email = Console.ReadLine();
                            personobj.Age = Console.ReadLine();
                            db.SaveChanges();

                        }
                        break;
                    case 4:
                        Console.WriteLine("enter id to delete");
                        id = Convert.ToInt32(Console.ReadLine());
                        personobj = db.Persons.Find(id);
                        if (personobj == null)
                        {
                            Console.WriteLine("enter validdata");
                        }
                        else
                        {
                            db.Persons.Remove(personobj);
                        }
                        db.SaveChanges();

                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("invalid option:");
                        break;


                }
            } while (opt != 5);
            Console.ReadKey();


        }
    }
}
