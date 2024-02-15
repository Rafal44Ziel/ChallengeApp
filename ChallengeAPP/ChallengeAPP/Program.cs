using Challenge1App;
using System.Runtime.InteropServices;

Employee user1 = new Employee ("Justyna", "Gawronska", 43);
Employee user2 = new Employee("Julia", "Szyszko", 19);
Employee user3 = new Employee("Kris", "Glejzer", 45);

user1.AddScore(7);
user1.AddScore(9);
user1.AddScore(6);

user2.AddScore(8);
user2.AddScore(5);
user2.AddScore(2);

user3.AddScore(10);
user3.AddScore(2);
user3.AddScore(5);

List<Employee> users = new List<Employee>()
{
    user1, user2, user3
};

int MaxResult = 1;
Employee userWitchMaxResult = null;

foreach( var user in users )
{
    if(user.Result > MaxResult)
            {
        userWitchMaxResult = user;
        MaxResult = user.Result;
    }
}

Console.WriteLine("User witch the highest result");
Console.WriteLine();
Console.WriteLine(userWitchMaxResult.Name + "" + userWitchMaxResult.Surname + "" + userWitchMaxResult.Age + " ith result of " + userWitchMaxResult.Result);


Console.ReadLine();

`1`

