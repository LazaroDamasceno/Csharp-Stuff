using IniatializerObject;

Person person = new() { name = "Lazaro", age = 24, id = 454564 };

Console.WriteLine(person.GetData());

person = new() { name = "Leonardo", age = 25, id = 8567565 };

Console.WriteLine(person.GetData());

person = new() { name = "Guilherme", age = 26, id = 5363343 };

Console.WriteLine(person.GetData());
