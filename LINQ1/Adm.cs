using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{
    public class Adm
    {
        public static List<Person> LoadData()
        {
            var people = new List<Person>();
            people.Add(new Person() { Id = 1, Name = "Alice Anderson", Age = 30, Telephone = "12 345678901" });
            people.Add(new Person() { Id = 2, Name = "Bob Brown", Age = 25, Telephone = "13 234567890" });
            people.Add(new Person() { Id = 3, Name = "Charlie Clark", Age = 28, Telephone = "14 456789012" });
            people.Add(new Person() { Id = 4, Name = "David Davis", Age = 35, Telephone = "15 567890123" });
            people.Add(new Person() { Id = 5, Name = "Eva Evans", Age = 32, Telephone = "16 678901234" });
            people.Add(new Person() { Id = 6, Name = "Frank Foster", Age = 22, Telephone = "17 789012345" });
            people.Add(new Person() { Id = 7, Name = "Grace Green", Age = 29, Telephone = "18 890123456" });
            people.Add(new Person() { Id = 8, Name = "Hannah Harris", Age = 27, Telephone = "19 901234567" });

            people.Add(new Person() { Id = 9, Name = "Ivy Irving", Age = 16, Telephone = "20 123456789" });
            people.Add(new Person() { Id = 10, Name = "Jack Johnson", Age = 14, Telephone = "21 234567890" });
            people.Add(new Person() { Id = 11, Name = "Kara King", Age = 12, Telephone = "22 345678901" });
            people.Add(new Person() { Id = 12, Name = "Liam Lewis", Age = 10, Telephone = "23 456789012" });

            return people;
        }
        public static void PrintData(List<Person> people)
        {
            foreach (var p in people)
            {

                Console.WriteLine(p);

            }
        }
        public static void PrintMoreThan18(List<Person> people)
        {
            foreach (var p in people)
            {
                if (p.Age >= 18)
                {
                    Console.WriteLine(p);
                }
            }
        }


        public static List<Person> FilterByFirstLetter(List<Person> people) => people.Where(p => p.Name.StartsWith("A")).ToList();

        public static List<Person> OrderByName(List<Person> people) => people.OrderBy(p => p.Name).ToList();
        public static List<Person> OrderByNameDesc(List<Person> people) => people.OrderByDescending(p => p.Name).ToList();

        public static List<Person> FilterByLetterAndLength(List<Person> people) => people.Where(p => p.Name.Contains('a') && p.Name.Length > 3).ToList();


    }
}
