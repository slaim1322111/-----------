using System;
using System.Collections.Generic;

namespace StudentProcessing
{
 
    struct Student
    {
        public string FullName;
        public string Gender;
        public string Residence;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { FullName = "Иванова Анна Петровна", Gender = "Ж", Residence = "Общежитие" });
            students.Add(new Student { FullName = "Петров Иван Васильевич", Gender = "М", Residence = "Квартира" });
            students.Add(new Student { FullName = "Сидорова Елена Владимировна", Gender = "Ж", Residence = "Общежитие" });
            students.Add(new Student { FullName = "Иванов Петр Александрович", Gender = "М", Residence = "Общежитие" });         
            Console.WriteLine("пол");
            string genderFilter = Console.ReadLine();
            Console.WriteLine("Жилье");
            string residenceFilter = Console.ReadLine();      
           
            foreach (var student in students)
            {
                if (student.Gender == genderFilter && student.Residence == residenceFilter)
                {
                    Console.WriteLine($"ФИО: {student.FullName}, Пол: {student.Gender}, Место жительства: {student.Residence}");
                }
            }

            Console.ReadLine();
        }
    }
}
