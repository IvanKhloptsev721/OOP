namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person yur = new Person("Yuriy", 35);

            Student iva = new Student("Ivan", 23, "Физмат","Добрый");
            iva.Introduce();
            
        }
    }
}
