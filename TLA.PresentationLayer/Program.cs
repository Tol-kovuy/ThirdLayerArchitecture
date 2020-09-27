using System;
using System.Collections.Generic;
using TLA.BusinessLayer;
using TLA.DataAccessLayer.Entity.Context;

namespace TLA.PresentationLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            ModelService db = new ModelService();
            TLAContext db1 = new TLAContext();

            //db.AddAudiences();
            //db.AddCourses();
            //db.AddTrainers();

            foreach (var item in db.GetAll())
            {
                Console.WriteLine(item.Id + " -" + item.Name);
            }

            Console.WriteLine(new string('_', 40));

            Console.ReadKey();
        }
    }
}
