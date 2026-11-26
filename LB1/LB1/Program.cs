using PersonLibrary;
using System;
using System.Dynamic;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Person PerviiTip = new Person("Andrei", "Gorbunov", 25, Pol.Myjskoi);
        Person VtoroiTip = new Person("Aleksei", "Sobolev", 22, Pol.Myjskoi);
        Person Tretya = new Person("Darya", "Romanova", 23, Pol.Jenskii);

        PersonList list1 = new PersonList();

        list1.Add(PerviiTip);
        list1.Add(VtoroiTip);
        list1.Add(Tretya);

        Person chetvertiitip = new Person("Danil", "Skorohodov", 24, Pol.Myjskoi);
        Person pyataya = new Person("Aleksandra", "Polyakova", 19, Pol.Jenskii);
        Person ktotowestoi = new Person("Roman", "Kabanov", 32, Pol.Myjskoi);

        PersonList list2 = new PersonList();

        list2.Add(chetvertiitip);
        list2.Add(pyataya);
        list2.Add(ktotowestoi);

        Print(list1);
        Print(list2);

        Console.ReadLine();
    }
    private static void Print(PersonList list)
    {
        for (int i = 0; i <  list.Count; i++)
        {
            Person person = list[i];

            Console.WriteLine($"Имя: {person.Name}, Фамилия: {person.Surname}, Возраст: {person.Age}, Пол: {person.Pol}");

        }
        Console.WriteLine();
    }
}
