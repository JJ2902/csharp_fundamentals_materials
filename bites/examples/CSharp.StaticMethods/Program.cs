namespace CSharp.StaticMethods;

class Program
{
    static void Main(string[] args)
    {
        Program myProgram = new Program();

        myProgram.InstanceAlert();
        myProgram.InstanceChangeOfPlan();
        myProgram.InstanceApology();
        myProgram.InstanceHelpNeeded();
        

        Console.WriteLine(Alert("HINT: This method must now return a string!"));
        Console.WriteLine(Alert()); //returns "default alert!!"

        Console.WriteLine(ChangeOfPlan("Change of plans!"));

        Console.WriteLine(Apology("I'm so sorry"));
        Console.WriteLine(Apology());

        Console.WriteLine(PoliteNotice());
        Console.WriteLine(HelpNeeded("Help!"));
    }

// no argument is given. example of method overload
    static string Alert() {
    return "default alert!!";
    }
    // note that `void` has been replaced with `string`
    static string Alert(string message) {
    return message;
    }

    void InstanceAlert() {
    Console.WriteLine("an instance method Alert");
    }

    static string ChangeOfPlan(string message){
    return message;
    }

    void InstanceChangeOfPlan(){
        Console.WriteLine("an instance method Change of plans");
    }
    static string Apology(){
        return "Sorry!";
    }

    void InstanceApology(){
        Console.WriteLine("Instant Sorry!");
    }
    static string Apology(string message){
    return message;
    }

    static string PoliteNotice(){
    return "kindly look away";
    }
    void InstanceHelpNeeded(){
        System.Console.WriteLine("Instant Help needed!");
    }
    static string HelpNeeded(string message){
    return message;
    }

}
