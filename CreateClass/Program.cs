using System;

namespace CreateClass
{
    class Program
    {
        public class Person
        {
            public string name;
            public DateTime birthDate;
            public enum Gender { Male, Female};
            public Gender gender;

            public Person(string name, DateTime birthDate, Gender gender)
            {
                this.name = name;
                this.birthDate = birthDate;
                this.gender = gender;
            }

            public override string ToString()
            {
                return "Name: " + name + " | Birth: " + birthDate + " | Gender: " + gender + " |";
            }
        }
        static void Main(string[] args)
        {
            Person person1 = new Person("Yuri Tarded", new DateTime(1111, 1, 11), Person.Gender.Female);
            Person person2 = new Person("Moe Lester", new DateTime(2222, 2, 22), Person.Gender.Male);

            Console.WriteLine(person1);
            Console.WriteLine(person2);
            Console.ReadKey(true);
        }
    }
}
