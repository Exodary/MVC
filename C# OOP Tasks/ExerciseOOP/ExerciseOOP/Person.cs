using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOOP
{
    class Person
    {
        public int age;

        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public int SetAge(int age)
        {
            return this.age = age;
        }

        public void ShowAge()
        {
            Console.WriteLine("My age is: {0} years old", this.age);
        }
    }
}
