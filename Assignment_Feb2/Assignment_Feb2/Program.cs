using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Feb2
{
     class Student
    {
        
            private string studentName;
            private int studentId;
            public string GetStudentName()
            {
                return studentName;
            }
            public void SetStudentName(string studentName)
            {
                this.studentName = studentName;
            }
            public int GetStudentId()
            {
                return studentId;
            }
            public void SetStudentid(int studentId)
            {
                this.studentId = studentId;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Student student = new Student();
                student.SetStudentName("Mikeee");
                student.SetStudentid(009);
                Console.WriteLine("Student Name is: " + student.GetStudentName());
                Console.WriteLine("Student Id is: " + student.GetStudentId());
            }
        }
    }
    
