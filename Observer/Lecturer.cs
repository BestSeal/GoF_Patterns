using System;
using System.Collections.Generic;

namespace Observer
{
    public class Lecturer : IObserver
    {
        public readonly static List<string> Subjects = new List<string>(new string[]{"Math","PE","IT","Language","Sleep"});
        
        private readonly DB _db;
        private readonly Department _department;
        public string Name { get;}

        public void Receive(object sender)
        {
            if (sender is Scheduler)
            {
                _db.Reports.Add(new Report()
                {
                    info = DateTime.Now.ToString(),
                    Lecturer = this,
                    Subject = Subjects[new Random().Next(0, Subjects.Count - 1)]
                });
                Console.WriteLine($"{Name}: new report was sent.");
            }
        }

        public Lecturer(string name, DB db, Department department)
        {
            Name = name;
            _db = db;
            _department = department;
            department.Lecturers.Add(this);
        }
    }
}