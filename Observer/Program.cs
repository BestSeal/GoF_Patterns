using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new DB();
            var department = new Department();
            var deansOffice = new DeansOffice(db);
            var scheduler = new Scheduler();
            
            scheduler.Register(new Lecturer("Mike", db, department));
            scheduler.Register(new Lecturer("Maria", db, department));
            scheduler.Register(new Lecturer("John", db, department));
            scheduler.Register(new Lecturer("Doe", db, department));
            scheduler.Register(deansOffice);
            deansOffice.Register(department);
            
            scheduler.Notify();
            Console.WriteLine("---------------");
            scheduler.Remove(department.Lecturers[0]);
            
            scheduler.Notify();
        }
    }
}