using System;
using System.Collections.Generic;

namespace Observer
{
    public class Department : IObserver
    {
        public List<Lecturer> Lecturers { get; set; }

        public void Receive(object sender)
        {
            if (sender is Lecturer lecturer)
            {
                Console.WriteLine($"{lecturer.Name}, report not found.");
            }
        }

        public Department()
        {
            Lecturers = new List<Lecturer>();
        }
    }
}