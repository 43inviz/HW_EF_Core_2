namespace HW_30_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderService os = new OrderService();

            os.AddDataInProduct();
            os.AddDataInOrders();
        }
    }
}
