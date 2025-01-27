namespace CSharp.InstanceMethods;

class Program
{
    static void Main(string[] args)
    {
    // create an instance of Program and assign it to a variable
    Program myProgram = new Program();
    
    MyMethod();
    myProgram.InstanceMyMethod();

    }

    
    // a static method
    static void MyMethod() {
    Console.WriteLine("a static method");
    }

    // an instance method
    void InstanceMyMethod() {
    Console.WriteLine("an instance method");
    }
    
}
