using System;
using System.Security.Cryptography.X509Certificates;

// Create a class 'Student' which stores Name, Roll No,
// Branch, Marks, and Location. Create a list of student type.
// Provide the following functions:
// 1) AddStudent
// 2) RemoveStudentByRollNo( )
// 3) DisplayAllStudents( )
// 4) DisplayAllStudentsWithBranch( )
// 5) DisplayAllStudentsWithLocation( )
// 6) SortStudentsByName( ) 

namespace StudentQ4 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentList students = new StudentList(new List<Studunt>());
            students.AddStudent("Raj", 88546, "Rajkot", 56, "UAS");
             students.AddStudent("Meet", 558546, "Xyz", 56, "UAS");
            students.DisplayAllStudents();
            students.DisplayAllStudentsWithBranch("Rajkot");

        }
    }
}