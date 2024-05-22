using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

public class Student
{
    public string FullName { get; private set; }
    public DateTime DateOfBirth { get; private set; }

    public Student(string fullName, DateTime dateOfBirth)
    {
        FullName = fullName;
        DateOfBirth = dateOfBirth;
    }

    public string LastName
    {
        get
        {
            string[] nameParts = FullName.Split(' ');
            return nameParts[nameParts.Length - 1];
        }
    }

    public char FirstLetterOfLastName
    {
        get
        {
            return LastName.FirstOrDefault();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        try
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "1.txt");

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(' ');

                if (parts.Length < 2)
                {
                    Console.WriteLine($"Некорректный формат строки: {line}");
                    continue;
                }

                string fullName = string.Join(" ", parts.Take(parts.Length - 1));

             
                if (ContainsCyrillic(fullName))
                {
                    Console.WriteLine($"Кириллицы: {fullName}");
                    continue;
                }

                if (!DateTime.TryParse(parts.Last(), out DateTime dateOfBirth))
                {
                    Console.WriteLine($"Некорректный формат даты рождения: {parts.Last()}");
                    continue;
                }

                students.Add(new Student(fullName, dateOfBirth));
            }

            Console.WriteLine("Введите год рождения для поиска студентов:");
            if (!int.TryParse(Console.ReadLine(), out int year))
            {
                Console.WriteLine("Неверный формат ввода.");
                return;
            }

            var filteredStudents = students.Where(student => student.DateOfBirth.Year == year)
                                           .GroupBy(student => student.FirstLetterOfLastName)
                                           .OrderBy(group => group.Key);

            foreach (var group in filteredStudents)
            {
                
                foreach (var student in group.OrderBy(student => student.LastName))
                {
                    Console.WriteLine(student.FullName);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
        }
        
    }
    static bool ContainsCyrillic(string input)
    {
        return Regex.IsMatch(input, @"\p{IsCyrillic}");
    }
}
