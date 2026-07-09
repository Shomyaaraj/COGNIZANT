using System;
using EFCoreCRUD.Data;
using EFCoreCRUD.Models;

namespace EFCoreCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDbContext db = new AppDbContext();

            db.AddStudent(new Student
            {
                Id = 1,
                Name = "Shomya",
                Age = 22
            });

            db.AddStudent(new Student
            {
                Id = 2,
                Name = "Rahul",
                Age = 21
            });

            Console.WriteLine("Student Records");

            db.DisplayStudents();
        }
    }
}