using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassAndObjectsExercise
{
    public class Dog
    {
        public string Name { get; set; }

        public Dog(string name)
        {
            this.Name = name;
        }

        public void Speak()
        {
            Console.WriteLine("I'm {0} and i WOOF", this.Name);
        }
    }
}
