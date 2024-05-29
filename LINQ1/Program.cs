using LINQ1;

List<Person> people = Adm.LoadData();

Adm.PrintData(people);
Console.WriteLine("------------------------------");
Adm.PrintData(Adm.FilterByLetterAndLength(people));