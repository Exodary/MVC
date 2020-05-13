using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassAndObjectsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog1 = new Dog("gringo");
            dog1.Name = "Tisho";
            dog1.Speak();
        }
    }
}
