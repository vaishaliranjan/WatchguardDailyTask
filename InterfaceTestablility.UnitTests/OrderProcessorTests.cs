using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InterfaceTestablility.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {

        //METHODNAME_CONDITION_EXPECTATION
        [TestMethod]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessorTests();

        }
       
    }
    public class FakeShippingCalculator : IShippingCalculator
    {

    }
}
