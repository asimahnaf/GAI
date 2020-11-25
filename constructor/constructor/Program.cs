using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    //class constructor
    //{
    //public string name;
    //public float roll;
    //public string dep;
    //public constructor()
    //    {
    //    name = "Hasib";
    //    roll = 180;
    //    dep = "Compuret";
    //    Console.WriteLine("Name : " + name);
    //    Console.WriteLine( "Roll : " + roll);
    //    Console.WriteLine("Department : " + dep);
    //    Console.ReadKey();
    //    }

    //    static void Main(string[] args)
    //    {
    //        constructor con = new constructor();
    //    }
    //}
    //**************************peramiter.....cinstructor>>>>>>>>>>>>>>>>>>>>>
    //class paraconstrctor
    //{
    //    public int a, b;
    //    public paraconstrctor(int x, int y)  // decalaring Paremetrized Constructor with ing x,y parameter  
    //    {
    //        a = x;
    //        b = y;
    //    }

    //}
    //class MainClass
    //{
    //    static void Main()
    //    {
    //        paraconstrctor v = new paraconstrctor(100, 175);   // Creating object of Parameterized Constructor and ing values   
    //        Console.WriteLine("-----------parameterized constructor example by vithal wadje---------------");
    //        Console.WriteLine("\t");
    //        Console.WriteLine("value of a=" + v.a);
    //        Console.WriteLine("\t");
    //        Console.WriteLine("value of b=" + v.b);
    //        Console.Read();
    //    }

    //}
    //example????????????????????????????????????????????????????????????????????????????????????????????????????????????
    //copy construct methode
    //class employee
    //{
    //    private string name;
    //    private int roll;
    //    public employee(employee emp)   // declaring Copy constructor.  
    //    {
    //        name = emp.name;
    //        roll = emp.roll;
    //    }
    //    public employee(string name, int age)  // Instance constructor.  
    //    {
    //        this.name = name;
    //        this.roll = age;
    //    }
    //    public string Details     // Get deatils of employee  
    //    {
    //        get
    //        {
    //            return " The roll of " + name + " is " + roll.ToString();
    //        }
    //    }
    //}
    //class empdetail
    //{
    //    static void Main()
    //    {
    //        employee emp1 = new employee("Vithal", 23);  // Create a new employee object.  
    //        employee emp2 = new employee(emp1);          // here is emp1 details is copied to emp2.  
    //        Console.WriteLine(emp2.Details);
    //        Console.ReadLine();
    //    }
    //}
    //example>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    //class Person
    //{
    //    // Copy constructor.
    //    public Person(Person previousPerson)
    //    {
    //        Name = previousPerson.Name;
    //        Age = previousPerson.Age;
    //    }

    //    //// Alternate copy constructor calls the instance constructor.
    //    //public Person(Person previousPerson)
    //    //    : this(previousPerson.Name, previousPerson.Age)
    //    //{
    //    //}

    //    // Instance constructor.
    //    public Person(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }

    //    public int Age { get; set; }

    //    public string Name { get; set; }

    //    public string Details()
    //    {
    //        return Name + " is " + Age.ToString();
    //    }
    //}

    //class TestPerson
    //{
    //    static void Main()
    //    {
    //        // Create a Person object by using the instance constructor.
    //        Person person1 = new Person("George", 40);

    //        // Create another Person object, copying person1.
    //        Person person2 = new Person(person1);

    //        // Change each person's age.
    //        person1.Age = 39;
    //        person2.Age = 41;

    //        // Change person2's name.
    //        person2.Name = "Charles";

    //        // Show details to verify that the name and age fields are distinct.
    //        Console.WriteLine(person1.Details());
    //        Console.WriteLine(person2.Details());

    //        // Keep the console window open in debug mode.
    //        Console.WriteLine("Press any key to exit.");
    //        Console.ReadKey();
    //    }
    //}
    //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<copy-constructor>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
    public class copy
    {
        public string Name;
        public int Roll;

        public copy(string name, int roll)
        {
            Name = name;
            Roll = roll;
        }
        public copy(copy a) //copy constuctur
        {
            Name = a.Name;
            Roll = a.Roll;
        }
        public void objectt()
        {
            Console.WriteLine("Name is : {0} ", Name);
            Console.WriteLine("Roll is : {0} ", Roll);
        }

    }
    class main
    {
        static void Main(string[] args)
        {
            copy obj = new copy("abdullah", 240);
            obj.objectt();
            copy obj1 = new copy(obj);
            obj.objectt();
            //w3 school
            //Console.WriteLine(Math.Round(2.6));
            //Console.WriteLine(Math.Sqrt(4));
            Console.ReadKey();

        }
    }


}
