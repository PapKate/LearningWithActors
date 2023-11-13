using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTime
{
    /// <summary>
    /// Test class
    /// </summary>
    public static class StudentProfessorTest
    {
        public static void Main()
        {
            var person = new PersonDataModel();
            Console.WriteLine("_____Person_____");
            person.Greet();
            Console.WriteLine("________________");

            var student = new StudentDataModel();
            Console.WriteLine("_____Student_____");
            student.SetAge(16);
            student.Greet();
            student.Study();
            Console.WriteLine("________________");


            var teacher = new TeacherDataModel();
            Console.WriteLine("____Teacher____");
            teacher.SetAge(16);
            teacher.Greet();
            teacher.Explain();
            Console.WriteLine("________________");
        }
    }
}
