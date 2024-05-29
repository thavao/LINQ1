using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Telephone { get; set; }
        public int Age { get; set; }

        public override string ToString() => $"Id: {Id}, Nome: {Name}, Idade: {Age}, Telefone: {Telephone} ";
    }
}
