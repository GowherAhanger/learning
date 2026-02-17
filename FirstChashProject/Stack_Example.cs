namespace FirstChashProject;

using System;
using System.Collections.Generic;

public class StackExample
{
    public  int maxSize = 5;
    public Stack<int> stack;

    public void StackOperations()
    {
        stack = new Stack<int>(maxSize);

        // PUSH...................................
        Console.WriteLine("Pushing items into stack...");
        Push(1);
        Push(2);
        Push(3);
        Push(4);
        Push(5);
        Push(6); // stack will overflow....................

        // POP..........................................
        Console.WriteLine("\nPopping items from stack...");
        Pop();

        // PEEK...............................
        Console.WriteLine("\nTop most item in stack...");
        Peek();
    }

    public  void Push(int item)
    {
        if (stack.Count < maxSize)
        {
            stack.Push(item);
            Console.WriteLine($"Pushed {item}, Top is now: {stack.Peek()}");
        }
        else
        {
            Console.WriteLine($" Stack Overflow! Cannot push {item}");
        }
    }

    public void Pop()
    {
        if (stack.Count > 0)
        {
            Console.WriteLine($"Popped: {stack.Pop()}");
        }
        else
        {
            Console.WriteLine(" Stack Underflow! Stack is empty");
        }
    }

    public void Peek()
    {
        if (stack.Count > 0)
        {
            Console.WriteLine($"Top element: {stack.Peek()}");
        }
        else
        {
            Console.WriteLine("Stack is empty");
        }
    }
}