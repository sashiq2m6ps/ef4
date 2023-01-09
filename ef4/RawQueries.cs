using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ef4
{
    class RawQueries
    {
        public void rq()
        {

            EfCoreEntities1 db = new EfCoreEntities1();
            //--sql query for entity types
            //IEnumerable<Person> personlist= db.Persons.SqlQuery("select * from Persons where PId=2");

            SqlParameter p1 = new SqlParameter();  //--           //--with paramaters

            p1.ParameterName = "@id";
            p1.Value = 2;
            p1.SqlDbType = System.Data.SqlDbType.VarChar;
            IEnumerable<Person> personlist= db.Persons.SqlQuery("select * from Persons where PId=2","@id");          //--with paramaters


            foreach (Person p in personlist) 
            {
                Console.WriteLine("{0} \t {1}", p.Name, p.Email);
            }


            //--sql query for non-entity types{1st create ur own class}
            var mypersonlist = db.Database.SqlQuery<mypersons>("select Name ,Email from Persons");

            foreach (mypersons p in mypersonlist)
            {
                Console.WriteLine("{0} \t {1}", p.Name, p.Email);
            }

            //--send rawcommand to database
            int r = db.Database.ExecuteSqlCommand("update Persons set Name='hhhh' where PId=2");
            if(r==1)
            {
                Console.WriteLine("updated");
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.ReadKey();

        }
    }
}
