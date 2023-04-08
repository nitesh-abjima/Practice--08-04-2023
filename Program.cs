using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
public class Program
{
    public static void Main()
    {
        String studentName = "Jack";

        // get the current type of studentName
        Type studentNameType = studentName.GetType();       //Reflection type class

        Console.WriteLine("Type is: " + studentNameType);

        //Reflection to get assembly
        
        Type t = typeof(Program);

        // get Assembly of variable t using the Assembly property
        Console.WriteLine(t.Assembly);

        //Reflection with Enumerable

        Type t1 = typeof(Enumerable);

        Console.WriteLine("Name : {0}", t1.Name);
        Console.WriteLine("Namespace : {0}", t1.Namespace);
        Console.WriteLine("Base Type : {0}", t1.BaseType);

        //Reflection with string

        Type t2 = typeof(String);
 
        Console.WriteLine("Name : {0}", t2.Name);
        Console.WriteLine("Namespace : {0}", t2.Namespace);
        Console.WriteLine("Base Type : {0}", t2.BaseType);

        //Declare nullable type
        //Nullable<dataType> variableName = null; or datatype? variableName = null;

        Nullable<int> x = null;
        //int? x = null;  

        // access Nullable type 
        Console.WriteLine("Value of x: " + x.GetValueOrDefault());

        //Nullable with Different Data Types

        Nullable<bool> y = null;
 
        Nullable<float> z = null;


        // access Nullable types

        Console.WriteLine("Value of y: " + y.GetValueOrDefault());
        Console.WriteLine("Value of z: " + z.GetValueOrDefault());

        var person1 = new Person("Joe", "Bloggs");
        var person2 = new Person("Joe", "Bloggs");
        var person3 = new Person("Jane", "Bloggs");
        Console.WriteLine($"Person1 == Person2? {person1 == person2}");
        Console.WriteLine($"Person1 == Person3? {person1 == person3}");

        //Cloning Records

        var person4 = person3 with { LastName = "Doe" };
        Console.WriteLine(person4);

        //Adding new property 
        var person5 = new Employee("Joe", "Bloggs", "Firefigher");
        var person6 = new Employee("Joe", "Bloggs", "Teacher");
        var person7 = new Employee("Jane", "Bloggs", "Programmer");

        Console.WriteLine(person5);
        Console.WriteLine(person6);
        Console.WriteLine(person7);


    }
}

//Record
public record Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    //public string FirstName { get; init; } //Use init for immutability
    //public string LastName { get; init; }
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    
}

//Inheritace Records
public record Employee(string FirstName, string LastName, string Job) : Person(FirstName, LastName);