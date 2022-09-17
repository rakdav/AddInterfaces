// See https://aka.ms/new-console-template for more information
using AddInterfaces;

var tom=new Person("Tommy",21);
var bob = new Person("Boby", 12);
var sam = new Person("Sam", 67);

Person[] people = {tom,bob,sam};
Array.Sort(people,new PeopleCompareByName());

foreach(Person person in people)
{
    Console.WriteLine($"{person.Name}," +
                      $"{person.Age}");
}
int[] mas = { 34, 12, 78, 16, 34, 90, 81 };
Array.Sort(mas);
foreach (var item in mas)
{
    Console.Write(item+" ");
}
Console.WriteLine();

Week week = new Week();
foreach(var day in week)
{
    Console.WriteLine(day);
}