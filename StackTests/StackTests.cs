using System;
using System.Collections.Generic;
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

            Assert.AreEqual(2, stack.Peek());

        }

        public void Peek_PushTwoItemsAndPop_ReturnsHeadElement()
        {
            var stack = new MyStack<int>();

            stack.Push(1);
            stack.Push(2);

            stack.Pop();

            Assert.AreEqual(1, stack.Peek());
        }
    }

    public class MyStack<T>
    {

        private List<T> _list = new List<T>();

        public bool IsEmpty => Count == 0;

        public int Count => _list.Count;

        public void Push(T value)
        {
            _list.Add(value);
        }

        public void Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            _list.RemoveAt(Count - 1);
        }

        public T Peek()
        {
            return _list[Count - 1];
        }
    }
}
