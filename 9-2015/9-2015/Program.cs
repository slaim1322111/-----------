using System;
using System.Collections.Generic;

public interface IEmployeeData
{
    void AddEmployeeSalary(string company, string employee, double salary);
    Dictionary<string, string> GetEmployeesBelowMinimumWage(string company, double minimumWage);
}

public interface ICipher
{
    string encode(string str);
    string decode(string str);
}

public class SimpleCipher : ICipher
{
    public string encode(string str)
    {
        string ciphertext = "";
        for (int i = 0; i < str.Length; i++)
            ciphertext = ciphertext + (char)(str[i] + 1);
        return ciphertext;
    }

    public string decode(string str)
    {
        string plaintext = "";
        for (int i = 0; i < str.Length; i++)
            plaintext = plaintext + (char)(str[i] - 1);
        return plaintext;
    }
}

public class EmployeeDatabase : IEmployeeData
{
    private Dictionary<string, Dictionary<string, string>> companySalaries = new Dictionary<string, Dictionary<string, string>>();
    public SimpleCipher cipher = new SimpleCipher(); // Теперь доступен извне

    public void AddEmployeeSalary(string company, string employee, double salary)
    {
        if (!companySalaries.ContainsKey(company))
        {
            companySalaries[company] = new Dictionary<string, string>();
        }

        string encryptedSalary = cipher.encode(salary.ToString());
        companySalaries[company][employee] = encryptedSalary;
    }

    public Dictionary<string, string> GetEmployeesBelowMinimumWage(string company, double minimumWage)
    {
        Dictionary<string, string> belowMinimumWageEmployees = new Dictionary<string, string>();
        if (companySalaries.ContainsKey(company))
        {
            foreach (var employee in companySalaries[company])
            {
                double decryptedSalary = double.Parse(cipher.decode(employee.Value));
                if (decryptedSalary < minimumWage)
                {
                    belowMinimumWageEmployees.Add(employee.Key, employee.Value);
                }
            }
        }
        return belowMinimumWageEmployees;
    }
}

class Program
{
    static void Main(string[] args)
    {
        EmployeeDatabase employeeDatabase = new EmployeeDatabase();

        employeeDatabase.AddEmployeeSalary("a", "Валера", 800);
        employeeDatabase.AddEmployeeSalary("a", "Лиса", 1200);
        employeeDatabase.AddEmployeeSalary("b", "ЧУР", 900);
        employeeDatabase.AddEmployeeSalary("b", "Даниил", 1500);

        Console.Write("Введите название предприятия: ");
        string company = Console.ReadLine();

        Console.Write("Введите прожиточный минимум: ");
        double minimumWage = double.Parse(Console.ReadLine());

        Dictionary<string, string> belowMinimumWageEmployees = employeeDatabase.GetEmployeesBelowMinimumWage(company, minimumWage);

        Console.WriteLine("Работники с зашифрованной зарплатой ниже прожиточного минимума:");
        foreach (var employee in belowMinimumWageEmployees)
        {
            Console.WriteLine($"{employee.Key}: {employee.Value}, {employeeDatabase.cipher.decode(employee.Value)}");
        }
    }
}
