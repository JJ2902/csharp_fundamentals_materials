namespace CSharp.Arithmetic;

class Program
{
    static void Main(string[] args)
    {
        int totalOrderAmount = 20;
        Order myOrder = new Order(totalOrderAmount);

        int additionalAmount = 10;
        int discountAmount = 5;

        int totalAfterAddition = Order.AddAmount(totalOrderAmount, additionalAmount);
        int totalAfterDiscount = Order.ApplyDiscount(totalOrderAmount, discountAmount);

        Console.WriteLine($"Total: {Order.GetTotal(totalAfterDiscount)}");
        Console.WriteLine($"Total: {myOrder.FriendlyTotal()}");

        //int total = 100;
        Discounter discounter = new Discounter(30);

        Console.WriteLine(discounter.ApplyTo(100));

        System.Console.WriteLine(discounter.ApplyTo(200));


    }
}
