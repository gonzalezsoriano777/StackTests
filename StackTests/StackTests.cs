using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StackTests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void IsEmpty_EmptyStack_ReturnsTrue()
        {
            MyStack stack = new MyStack();
            Assert.IsTrue(stack.IsEmpty);
        }
    }

    public class MyStack
    {
        public bool IsEmpty
        {
            get { return true; }
        }
    }
}
