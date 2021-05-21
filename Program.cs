using System;

Console.Write("First Name? ");
string first = Console.ReadLine();

Console.Write("Last Name? ");
string last = Console.ReadLine();

string name = first + " " + last;

string reversed = string.Empty;

for (int i = name.Length - 1; i >= 0; i--)
{
    reversed += name[i];
}

Console.WriteLine(reversed);