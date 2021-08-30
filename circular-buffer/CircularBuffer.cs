using System;
using System.Linq;
using System.Collections.Generic;

public class CircularBuffer<T>
{
    private readonly int _capacity;

    public CircularBuffer(int capacity) => _capacity = capacity;
    
    private Queue<T> _queue { get; } = new Queue<T>();

    public T Read()
    {
        if (!_queue.Any()) throw new InvalidOperationException();
        return _queue.Dequeue();
    }

    public void Write(T value)
    {
        if (_queue.Count == _capacity) throw new InvalidOperationException();
        _queue.Enqueue(value);    
    }

    public void Overwrite(T value)
    {
        if (_queue.Count == _capacity) _queue.Dequeue();
        _queue.Enqueue(value);
    }

    public void Clear() => _queue.Clear();
}