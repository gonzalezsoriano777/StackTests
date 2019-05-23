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
            MyStack stack = new MyStack<int>();
            Assert.IsTrue(stack.IsEmpty);
        }

        [TestMethod]
        public void Count_PushOneItem_ReturnOne()
        {
            var stack = new MyStack<int>();

            // this will throw an agruement, if value was not implemented
            stack.Push(1);

            Assert.AreEqual(1, stack.Count);
            Assert.IsFalse(stack.IsEmpty);

        }
    }

    public class MyStack<T>
    {
        public bool IsEmpty
        {
            get { return true; }
        }

        public int Count { get; private set;  }

        public void Push(T value)
        {
            throw new NotImplementedException();
        }
    }
}
