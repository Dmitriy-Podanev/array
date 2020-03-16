using System;
using MyLibary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void push_and_get_header()
        {
            //arange
            int x = 10;
            int y = 18;
            int z = 50;

            int expected = 18;

            //act
            MyStack<int> stack = new MyStack<int>();
            stack.Push(x);
            stack.Push(z);
            stack.Push(y);

            //assert
            Assert.AreEqual(expected, stack.Header());
        }

        [TestMethod]
        public void Empty_stack_pop()
        {
            MyStack<int> stack = new MyStack<int>(); //arange
            Assert.ThrowsException<InvalidOperationException>(() => { stack.Pop(); });
        }

        [TestMethod]
        public void pop_elem()
        {
            MyStack<float> stack = new MyStack<float>();
            float x = 10.0f;
            float y = 18.0f;
            float z = 50.0f;

            stack.Push(x);
            stack.Push(y);
            stack.Push(z);

            Assert.AreEqual(z, stack.Pop());
            Assert.AreEqual(y, stack.Pop());
            Assert.AreEqual(x, stack.Pop());

        }

        [TestMethod]
        public void count_elem_into_stack()
        {
            MyStack<int> stack = new MyStack<int>();
            int x = 10;
            int y = 18;
            int z = 50;

            stack.Push(x);
            stack.Push(y);
            stack.Push(z);
            Assert.AreEqual(3, stack.Count_in_Array());
            stack.Pop();
            Assert.AreEqual(2, stack.Count_in_Array());
            stack.Pop();
            Assert.AreEqual(1, stack.Count_in_Array());
            stack.Pop();
            Assert.AreEqual(0, stack.Count_in_Array());
        }

        [TestMethod]
        public void max_int_1000_elem()
        {
            MyStack<int> stack = new MyStack<int>();
            for (int i = 0; i < 1000; i++)
            {
                stack.Push(1);
            }
            Assert.AreEqual(1000, stack.Count_in_Array());
        }

        [TestMethod]
        public void Empty_stack_false()
        {
            MyStack<int> stack = new MyStack<int>();
            int x = 19;
            stack.Push(x);
            Assert.AreEqual(false, stack.EmptyStack());
        }

        [TestMethod]
        public void Empty_stack_true()
        {
            MyStack<int> stack = new MyStack<int>();
            Assert.AreEqual(true, stack.EmptyStack());
        }

        [TestMethod]
        public void Clear_stack()
        {
            MyStack<int> stack = new MyStack<int>();

            stack.Push(10);
            Assert.AreEqual(1, stack.Count_in_Array());
            stack.Clear();
            Assert.AreEqual(0, stack.Count_in_Array());
        }

        [TestMethod]
        public void ToList()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(10);
            stack.Push(15);
            stack.Push(20);
            List<int> list = stack.ToList();
            Assert.AreEqual(3, list.Count);
            list.Add(123);
            Assert.AreEqual(4, list.Count);
        }

        [TestMethod]
        public void Push_Pop_Emptystack()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(10);
            Assert.AreEqual(false, stack.EmptyStack());
            stack.Pop();
            Assert.AreEqual(true, stack.EmptyStack());
        }
    }
}
