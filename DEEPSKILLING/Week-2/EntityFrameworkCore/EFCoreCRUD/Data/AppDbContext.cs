using System.Collections.Generic;
using EFCoreCRUD.Models;

namespace EFCoreCRUD.Data
{
    public class AppDbContext
    {
        public List<Student> Students = new List<Student>();

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public void DisplayStudents()
        {
            foreach (Student s in Students)
            {
                System.Console.WriteLine($"{s.Id} {s.Name} {s.Age}");
            }
        }
    }
}