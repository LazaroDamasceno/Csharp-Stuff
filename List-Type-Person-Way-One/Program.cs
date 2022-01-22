using GenericCollection;

List<Person> people = new List<Person>();

people.Add(new Person() 
{ 
    name = "Lazaro", 
    adress = "Rua do Ouvidor", 
    age = 24, 
    hasUniDegree = true, 
    id = 7467832, 
    isWorking = false, 
    socialStatus = "single" 
});

people.Add(new Person()
{
    name = "Leonardo",
    adress = "Rua do Ouvidor",
    age = 24,
    hasUniDegree = true,
    id = 7467832,
    isWorking = true,
    socialStatus = "single"
});

people.Add(new Person()
{
    name = "Jorge Mario",
    adress = "Rua do Ouvidor",
    age = 24,
    hasUniDegree = false,
    id = 7467832,
    isWorking = false,
    socialStatus = "single"
});

foreach (Person person in people)
{
    Console.WriteLine(person.PersonInfo());
}