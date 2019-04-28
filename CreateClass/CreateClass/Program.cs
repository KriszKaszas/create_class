using DocumentFormat.OpenXml.Wordprocessing;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Kovacs = new Employee("Géza", DateTime.Now, 1000, "léhűtő");
            Kovacs.room = new Room(111);
            Employee Kovacs2 = (Employee)Kovacs.Clone();
            Kovacs2.room.Number = 112;
            Console.WriteLine(Kovacs.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();
        }
    }


    class Person
    {
        public string Name { get; set; }
        public int BirthDate { get; set; }
        enum Genders
        {
            MALE,
            FEMALE
        }

        public Person(string name, int birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return "Person: " + Name + "\n" + "Birth date: " + BirthDate;
        }

    }

    class Employee : Person
    {
        public int Salary { get; set; }
        public string Profession { get; set; }

        public Room room;

        public Employee(int salary, string profession)
        {
            Salary = salary;
            Profession = profession;
        }

        public override string ToString()
        {
            return "Employee: " + Name + "\n" + "Birth date: " + 
                BirthDate + "\n" + "Profession: " + Profession + "\n" + "Salary: " + Salary;
        }

        public object Clone()
        {
            Employee newEmployee = (Employee)this.MemberwiseClone();
            newEmployee.room = new Room(Room.Number);
            return newEmployee;
        }
    }

    class Room
    {
        public int Number { get; set; }

        public Room(int number)
        {
            Number = number;
        }
    }


}
