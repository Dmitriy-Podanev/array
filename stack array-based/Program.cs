using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibary;


public class Program
{
    static void Main(string[] args)
    {
        MyStack<int> stack = new MyStack<int>(0);
        stack.Push(11);
        stack.Push(133);
        stack.Push(100);
        stack.Push(8);

        stack.Show();
        stack.Pop();
        stack.Show();
        stack.Clear();
        stack.Show();
        // Check<MyStack<int>>.showArray(stack);

        
        

    }
}

