using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks;

namespace StudentQ4
{
    public class StudentList
    {  
       List<Studunt> s1 ;
       public StudentList(List<Studunt> studunts){
         s1= studunts;
        s1.Add(new Studunt{Name="niraj", RollNo= 997800 , Branch="Rajkot", Marks=90, Location="Surat"});
       }
        
        public void AddStudent(string Name, int RollNo, string Branch, int Marks, string Location){
            s1.Add(new Studunt{Name=Name, RollNo= RollNo , Branch=Branch, Marks=Marks, Location=Location});
        }

        public void DisplayAllStudents( ){
            foreach (var item in s1)
            {
                Console.WriteLine("\nName:{0}",item.Name);
                Console.WriteLine("Roll No: {0}", item.RollNo);
                Console.WriteLine("Branch: {0}",item.Branch);
                Console.WriteLine("Marks: {0}",item.Marks);
                Console.WriteLine("Location: {0}",item.Location);
            }
        }

        // public void  RemoveStudentByRollNo(int RollNo){
            
        // }

        public void DisplayAllStudentsWithBranch( string Branch){
            Console.WriteLine("{0} Branch all Students", Branch);
             foreach (var item in s1)
            {   
                if(item.Branch == Branch){ 
                Console.WriteLine("\nName:{0}",item.Name);
                Console.WriteLine("Roll No: {0}", item.RollNo);
                Console.WriteLine("Marks: {0}",item.Marks);
                Console.WriteLine("Location: {0}",item.Location);
                }
            }

        }

         public void DisplayAllStudentsWithLocation( string Location){
            Console.WriteLine("{0} Location all Students", Location);
             foreach (var item in s1)
            {   
                if(item.Location == Location){ 
                Console.WriteLine("\nName:{0}",item.Name);
                Console.WriteLine("Roll No: {0}", item.RollNo);
                Console.WriteLine("Marks: {0}",item.Marks);
                Console.WriteLine("Branch: {0}",item.Branch);
                }
            }
            
        }
    }
}