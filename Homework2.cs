using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please input letter grade.");
      char grade = Console.ReadKey().KeyChar;
      int gpa;
      switch (grade)
      {
      case 'A': 
        gpa = 4;
        break;
      case 'B':
        gpa = 3;
        break;
      case 'C':
        gpa = 2;
        break;
      case 'D':
        gpa = 1;
        break;
      case 'F':
        gpa = 0;
        break;
      default:
        Console.WriteLine("\nWrong letter grade!");
        return;
      }
     Console.WriteLine($"\nGPA points: {gpa}");
    }
}
