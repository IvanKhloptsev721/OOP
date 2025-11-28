using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Person
    {
        public string Name { get; set; }
        private int _age { get; set; }

        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                    _age = value;
                else
                    throw new ArgumentOutOfRangeException("Возраст не коретен");
            }

        }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void Introduce()
        {
           
             Console.WriteLine($"Привет я {Name} мне {Age} лет"); }


        }
}
