using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string FullName { get; set; }
    public int EmployeeID { get; set; }
    public string Position { get; set; }
    public string Department { get; set; }
}

class WorkRecord
{
    public int EmployeeID { get; set; }
    public List<decimal> MonthlySalary { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
       
        var employees = ReadEmployeesData("1.bin"); //Отдел продаж
        var workRecords = ReadWorkRecordsData("2.bin");

       
        Console.WriteLine("Отдел");
        string departmentInput = Console.ReadLine();

        
        var departmentEmployees = employees.Where(emp => emp.Department == departmentInput);
        foreach (var emp in departmentEmployees)
        {
            var workRecord = workRecords.FirstOrDefault(wr => wr.EmployeeID == emp.EmployeeID);
            if (workRecord != null)
            {
                decimal averageSalary = workRecord.MonthlySalary.Average();
                Console.WriteLine($"ФИО: {emp.FullName}, Должность: {emp.Position}, Средняя зарплата: {averageSalary}");
            }
        }
        Console.ReadKey();
    
    }

    static List<Employee> ReadEmployeesData(string fileName)
    {
        List<Employee> employees = new List<Employee>();
        using (FileStream stream = new FileStream(fileName, FileMode.Open))
        {
            using (BinaryReader reader = new BinaryReader(stream))
            {
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    var employee = new Employee
                    {
                        FullName = reader.ReadString(),
                        EmployeeID = reader.ReadInt32(),
                        Position = reader.ReadString(),
                        Department = reader.ReadString()
                    };
                    employees.Add(employee);
                }
            }
        }
        return employees;
    }

    static List<WorkRecord> ReadWorkRecordsData(string fileName)
    {
        List<WorkRecord> workRecords = new List<WorkRecord>();
        using (FileStream stream = new FileStream(fileName, FileMode.Open))
        {
            using (BinaryReader reader = new BinaryReader(stream))
            {
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    var record = new WorkRecord
                    {
                        EmployeeID = reader.ReadInt32(),
                        MonthlySalary = new List<decimal>()
                    };
                    for (int i = 0; i < 12; i++)
                    {
                        record.MonthlySalary.Add(reader.ReadDecimal());
                    }
                    workRecords.Add(record);
                }
            }
        }
        return workRecords;
    }
}
