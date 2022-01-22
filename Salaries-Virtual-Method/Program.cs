using SalariesVirtualMethod;

Salaryman salaryman = new(1000.0);
Console.WriteLine(salaryman.DisplaySalary());

Supervisor supervisor = new(1000.0, 0.1);
Console.WriteLine(supervisor.DisplaySalary());

Manager manager = new(1000.0, 0.25);
Console.WriteLine(manager.DisplaySalary());

Director director = new(1000.0, 0.5);
Console.WriteLine(director.DisplaySalary());