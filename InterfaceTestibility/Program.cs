using System;
namespace Testability
{
    public class OrderProcessor
    {
        public readonly ShippingCalculator _shippingCalculator;
        public OrderProcessor()
        {
            _shippingCalculator = new ShippingCalculator();
        }  

        public void Process(OrderProcessor order)
        {
            if (order.IsShipped)
            {
                throw new InvalidOperationException("This order is already processed");
            }

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShoppingDate = DateTime.Today.AddDays(1);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor();
            var order = new OrderedParallelQuery { DatePlaced= DateTime.Now, TotalPrice= 100f };
            orderProcessor.Process(order);