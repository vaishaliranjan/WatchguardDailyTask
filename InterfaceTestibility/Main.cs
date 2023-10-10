using System;
using System.Linq;

namespace Testability
{
    class Oct10
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator() );
            var order = new Order{ DatePlaced = DateTime.Now, TotalPrice = 100f };
            orderProcessor.Process(order);
        }

    }
}

   