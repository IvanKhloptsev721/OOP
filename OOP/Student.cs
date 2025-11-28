using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Student : Person
    {
        public string Moot {  get; set; }
    

        public string fakultet { get; set; }
    
       
        public Student(string name, int age, string fakult, string moot)
             : base(name, age)
        {
            fakultet = fakult;
            Moot = moot;
        }

        public override void Introduce()
        {
            base.Introduce();
            if (Moot == "Злой")
            { Console.WriteLine($" Я учусь на {fakultet} нет настроения общаться"); }
            else if (Moot == "Добрый") { Console.WriteLine($" Я учусь на {fakultet} поболтаем ?"); }
            else
            {
                Console.WriteLine($" Я учусь на {fakultet}");
            }
        }
    }
}
