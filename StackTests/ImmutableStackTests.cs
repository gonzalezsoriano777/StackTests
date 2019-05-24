using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StackTests
{
    public interface IStack<T>
    {
        IStack<T> Push(T value);
        IStack<T> Pop();
        T Peek();
        bool IsEmpty { get; }
    }
        
     public class ImmutableStack<T> : IStack<T>
    {
        private sealed class IsEmpty : IStack<T>
        {
            public IStack<T> Push (T value)
            {
                throw new NotImplementedException();
            }

            public IStack<T> Pop()
            {
                throw new NotImplementedException();
            }

            public T Peek()
            {
                throw new NotImplementedException();
            }

            public bool IsEmpty => true;
        }

        public IStack<T> Push(T value)
        {
            throw new NotImplementedException();
        }

        public IStack<T> Pop()
        {
            throw new NotImplementedException();
        }

        public T Peek()
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty => true;
    }
}
