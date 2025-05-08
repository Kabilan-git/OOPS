
using System.Diagnostics.Contracts;
using System.IO.Compression;


//Naming Convention;;
/*
CarsDetails
Method1();
string fullNameDetails;
ICars
_cars

*/
public class Program
{
    public static void Main(string[] args)
    {
        // Parent parent = new Parent();    //objet creation or instance creation
        // parent.ParentMethod1();

        // Child child = new Child();
        // child.ParentMethod1();
        // child.ChildMethod1();
        // child.ParentMethod2();

        // abstract2 abstract2 = new abstract2();
        // abstract2.Method1();

        // abstract3 abstract3 = new abstract3();
        // abstract3.Method1();

        // Teacher teacher = new Teacher();
        // teacher.Call();

        Professor professor = new Professor();
        professor.callStudent();
    }
}

/// <summary>
/// Inheritance
/// </summary>


public class Parent
{
    public int number = 0;
    public void ParentMethod1()
    {
        Console.WriteLine("I am a method1 from Parent");
    }
    public void ParentMethod2()
    {
        Console.WriteLine("I am a method1 from Parent");
    }

}
public class Child : Parent, ICars
{
    public void Method1() { }
    public void ChildMethod1()
    {
        Console.WriteLine("I am a method1 from Child");
    }
    public void ChildMethod2()
    {
        Console.WriteLine("I am a method1 from Child");
    }

    public void Name()
    {
        throw new NotImplementedException();
    }

    public void Price()
    {
        throw new NotImplementedException();
    }

    public void Seat()
    {
        throw new NotImplementedException();
    }
}


/// <summary>Interface</summary>

public interface ICars
{
    public void Name();
    public void Price();
    public void Seat();
}


public class Car1 : ICars
{
    public void Name()
    {
        Console.WriteLine("Mahindra");
    }

    public void Price()
    {
        Console.WriteLine(100000);
    }

    public void Seat()
    {
        Console.WriteLine(5);
    }
}

public class Car2 : ICars
{
    public void Name()
    {
        Console.WriteLine("Lambo");
    }

    public void Price()
    {
        Console.WriteLine(3000000);
    }

    public void Seat()
    {
        Console.WriteLine(2);
    }
}




/// <summary>
///  Abstract
/// </summary>
public class program9
{
    // Abstarct abstarct = new Abstarct();
}


public abstract class Abstarct
{
    public abstract void Method1();
}

public class abstract2 : Abstarct
{
    public override void Method1()
    {
        Console.WriteLine("Method 1 from abstract2");
    }
}
public class abstract3 : Abstarct
{
    public override void Method1()
    {
        Console.WriteLine("Method 1 from abstract3");
    }

}


//** abstract method must be used under abstract class
//** but abstract class contains non-abstract method
//** abstract method doest not have a body
//** To give the body to the abstract method we need to inherit with another class
//** If we inherit the abstract class we need to implement the abstract method.
//** We can't create object for an abstract class.


/// <summary>Polymorphism</summary>
/// * Overloading

public static class ClassRoom
{
    public static void Student()
    {
        Console.WriteLine("Class Leader");
    }
    public static void Student(int rollNo)
    {
        Console.WriteLine($"My roll No is {rollNo}");
    }

    public static void Student(string name, int rollNo)
    {
        Console.WriteLine($"My name is {name} and my roll No is {rollNo}");
    }

    public static void Student(decimal marks)
    {
        Console.WriteLine($"My mark is {marks}");
    }
}

public class Teacher
{
    public void Call()
    {
        ClassRoom.Student("Jhon", 1);

    }
}

// * Overloading: We can use multiple methods with same name but the parameter must be different


/// * OverRiding
/// ! Virtual and Override

public class Student
{
    public virtual void Name()
    {
        Console.WriteLine("Student");
    }
}

public class Student1 : Student
{
    public override void Name()
    {
        Console.WriteLine("Jhon");
    }
}
public class Student2 : Student
{
    public override void Name()
    {
        Console.WriteLine("Jack");
    }
}


public class Professor
{
    public void callStudent()
    {
        Student student1 = new Student1();
        Student student2 = new Student2();
        student1.Name();
        student2.Name();
    }
}


/// <summary>Encapsulation</summary>
///

public class Register
{
    private int rollNo;
    public int RollNo
    {
        get
        {
            if (10 > 0)
            {
                return 100;
            }
        }
        set { rollNo = value; }
    }

    public string Name { get; set; } = "Student";

    public void assignRollNo()
    {
        rollNo = 0;
    }
}

public class Admin
{
    public void registeration()
    {
        Register register = new Register();
        register.RollNo = 10;
        int getRollNo = register.RollNo;
        register.Name = "Jack";
        string getName = register.Name;
    }
}

// * if need to access a private variable we need to declare a public property
// * property can contains 'get' or 'set'
// * get is to get the value
// * set is to set the value
// * when setting the value to private variable of another class we need to use the public property
// * when getting the value from private variable of another class we need to use the public property


/// <summary>Static Class</summary>
public static class Car
{
    public static void Name()
    {
        Console.WriteLine("I am method from a static class");
    }

}

public class CallStatic
{
    public void Method1()
    {
        Car.Name();
    }

    public static void Method2() { }
}

// * Static class only contains static methods
// * We can't create a object for a static class
// * But we can use a static method inside a non-static class
// * We can't create a inherit a static class
