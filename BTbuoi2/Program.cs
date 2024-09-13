using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Student> students = new List<Student>()
        {
            new Student() { Id = 1, Name = "Phung Trong Hung", Age = 16 },
            new Student() { Id = 2, Name = "Nguyen Dong Nhat", Age = 17 },
            new Student() { Id = 3, Name = "Tieu Viet Huy", Age = 15 },
            new Student() { Id = 4, Name = "Nguyen Thanh Dat", Age = 19 },
            new Student() { Id = 5, Name = "Dang Huu Nha", Age = 18 }
        };

        Console.WriteLine("Danh sach toan bo hoc sinh:");
        foreach (var student in students)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        Console.WriteLine("\nDanh sach hoc sinh co tuoi tu 15 den 18:");
        var ageBetween15And18 = students.Where(s => s.Age >= 15 && s.Age <= 18);
        foreach (var student in ageBetween15And18)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        Console.WriteLine("\nDanh sach hoc sinh co ten bat dau bang chu 'A':");
        var nameStartsWithA = students.Where(s => s.Name.StartsWith("A"));
        foreach (var student in nameStartsWithA)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }

        int totalAge = students.Sum(s => s.Age);
        Console.WriteLine($"\nTong tuoi cua tat ca hoc sinh: {totalAge}");

        var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
        Console.WriteLine($"\nHoc sinh co tuoi lon nhat: Id: {oldestStudent.Id}, Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");

        Console.WriteLine("\nDanh sach hoc sinh sau khi sap xep theo do tuoi tang dan:");
        var sortedByAge = students.OrderBy(s => s.Age);
        foreach (var student in sortedByAge)
        {
            Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
        }
    }
}

