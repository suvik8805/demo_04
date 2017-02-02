using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = New Person();

            //create  one teacher from Teacher class
            Teacher teacher = new Teacher();
            teacher.FirstName = "Kirsi";
            teacher.LastName = "Kernel";
            teacher.Age = 30;
            teacher.Address = "Piippukatu 2";
            teacher.PhoneNumber = "010-12345658";
            teacher.Room = "D444";
            Console.WriteLine(teacher.ToString());

            //create one student
            Student student = new Student("Matti", "Mallikas","H9090");
            student.Address = "Kirkkokatu 10";
            student.Age = 20;
            student.PhoneNumber="040-8778787";
            Console.WriteLine(student.ToString());

            teacher.TeacherMethod();
            student.StudentMethod();
            

        }
    }
}
