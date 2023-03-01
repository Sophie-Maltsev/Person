using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class HelloWorld
{
    internal class Person
    {
        private string surname;
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public DateTime Birthday { get; set; }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private char gender;
        public char Gender
        {
            get { return gender; }
            set
            {
                if ((value == 'm') || (value == 'M') || (value == 'f') || (value == 'F'))
                    gender = value;
            }
        }
        public Person(string name, string surname, char gender)
        {
            this.name = name;
            this.surname = surname;
            this.gender = gender;
        }
        public override string ToString()
        {
            return name + " " + surname + " " + gender;
        }
    }
    public static int GetAge(DateTime birthDate)
    {
        var now = DateTime.Today;
        return now.Year - birthDate.Year - 1 +
        ((now.Month > birthDate.Month || now.Month == birthDate.Month && now.Day >= birthDate.Day) ? 1 : 0);
    }

    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Person[] X = new Person[n];
        for (int i = 0; i < n; i++)
        {
            char pol = ' ';
            string imya = Console.ReadLine();
            string familia = Console.ReadLine();
            string str = Console.ReadLine();
            if ((str.Length == 1) && ((str[0] == 'm') || (str[0] == 'M') || (str[0] == 'f') || (str[0] == 'F')))
            { pol = str[0]; }
            else
            {
                pol = 'N';
                Console.WriteLine("Wrong letter. Chaged to N");
            }
            int y = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            X[i] = new Person(imya, familia, pol);
            X[i].Birthday = new DateTime(y, m, d);
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(GetAge(X[i].Birthday));
            Console.WriteLine(X[i].Name[0] + "." + X[i].Surname + " " + X[i].Gender);
        }
    }
}