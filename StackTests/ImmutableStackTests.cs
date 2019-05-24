using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StackTests
{
    public interface IStack<T>
    {
        IStack<T> Peek(T value);
        IStack<T> Pop();
        T Peek();
        bool IsEmpty();
    }
        
        
}
