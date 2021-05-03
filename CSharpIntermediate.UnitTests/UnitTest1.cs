using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSharpIntermediate.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    { 
        // MethodName_Condition_Expectation

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order()
            {
                Shipment = new Shipment()
            };
            orderProcessor.Process(order);
        }

        public class FakeShippingCalculator : IShippingCalculator
        {
            public float CalculateShipping(Order order)
            {
                return 1;
            }
        }
    }
}
