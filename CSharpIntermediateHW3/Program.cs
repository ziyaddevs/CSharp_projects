namespace CSharpIntermediate
{

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "John Smith");
            System.Console.WriteLine(customer.Id);
            System.Console.WriteLine(customer.Name);

            var order = new Order();
            customer.Orders = new List<Order>();
            System.Console.WriteLine(customer.Name);
        }
    }
}