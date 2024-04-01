using System;
using System.Collections.Generic;

class Student
{
    public int StudentID { get; private set; }
    public string StudentName { get; private set; }

    public Student(int studentID, string studentName)
    {
        StudentID = studentID;
        StudentName = studentName;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {StudentID}, Student Name: {StudentName}");
    }

    public static List<Student> studentList = new List<Student>();
}

class Program
{
    static void Main()
    {
        Student student1 = new Student(111, "Alice");
        Student student2 = new Student(222, "Bob");
        Student student3 = new Student(333, "Cathy");
        Student student4 = new Student(444, "David");

        Student.studentList.Add(student1);
        Student.studentList.Add(student2);
        Student.studentList.Add(student3);
        Student.studentList.Add(student4);

        Dictionary<string, double> gradebook = new Dictionary<string, double>
        {
            { "Alice", 4.0 },
            { "Bob", 3.6 },
            { "Cathy", 2.5 },
            { "David", 1.8 }
        };
        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook.Add("Tom", 3.3);
        }

        double totalGpa = 0;
        foreach (var gpa in gradebook.Values)
        {
            totalGpa += gpa;
        }
        double averageGpa = totalGpa / gradebook.Count;

        Console.WriteLine($"The average GPA is: {averageGpa:F2}");

        Console.WriteLine("Students with GPA greater than average:");
        foreach (var student in Student.studentList)
        {
            if (gradebook.ContainsKey(student.StudentName) && gradebook[student.StudentName] > averageGpa)
            {
                student.PrintInfo();
            }
        }
    }
}
