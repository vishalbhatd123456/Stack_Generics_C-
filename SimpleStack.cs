using System;

namespace Generics_PS1
{
    internal class SimpleStack<T>
    {
        private readonly T[] _items;
        private int _currentIndex = -1;

        public SimpleStack() => _items = new T[10];
        public int Count => _currentIndex + 1;
        internal void Push(T item) => _items[++_currentIndex] = item;

        public T Pop() => _items[_currentIndex--];
        
    }
    
}
