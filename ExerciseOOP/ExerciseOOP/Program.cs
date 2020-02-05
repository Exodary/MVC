using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var Person = new Person();

            Person.Greet();


            var student = new Student();

            student.SetAge(21);
            student.ShowAge();

            var teacher = new Teacher();

            teacher.SetAge(30);
            teacher.ShowAge();
            teacher.Greet();
            teacher.Explain();
        }
    }
}
