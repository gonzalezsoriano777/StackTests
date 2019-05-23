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
            var stack = new MyStack<int>();
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

        public void Pop_EmptyStack_ThrowsException()
        {
            var stack = new MyStack<int>();

            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                stack.Pop();
            });
        }

        public void Peek_PushTwoItems_ReturnsHeadItem()
        {
            var stack = new MyStack<int>();

            stack.Push(1);
            stack.Push(2);

            
        }
    }

    public class MyStack<T>
    {
        public bool IsEmpty => Count == 0;        

        public int Count { get; private set;  }

        public void Push(T value)
        {
            Count++;
        }

        public void Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
        }
    }
}
