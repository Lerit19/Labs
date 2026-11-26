using PersonLibrary;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Person PerviiTip = new Person("Andrei", "Gorbunov", 25, Pol.Myjskoi);
        Person VtoroiTip = new Person("Aleksei", "Sobolev", 22, Pol.Myjskoi);
        Person Tretya = new Person("Darya", "Romanova", 23, Pol.Jenskii);
        PersonList PerviiSpisok = new PersonList();
        PerviiSpisok.Add(PerviiTip);
        PerviiSpisok.Add(VtoroiTip);
        PerviiSpisok.Add(Tretya);
    }
}
