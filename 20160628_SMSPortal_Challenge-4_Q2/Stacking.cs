using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20160628_SMSPortal_Challenge_4_Q2 {
    class Stacking {
        public static List<T> StackToList<T>(Stack<T> stack, bool revertItems) {
            List<T> items = new List<T>();
            while (stack.Count > 0) {
                T item = stack.Pop();

                if (revertItems)
                    items.Insert(0, item);
                else
                    items.Add(item);
            }
            return items;
        }

        static void Main(string[] args) {
            Stack<int> stackT = new Stack<int>();
            stackT.Push(100);
            stackT.Push(1000);
            stackT.Push(10000);

            Stack<int> stackF = new Stack<int>();
            stackF.Push(100);
            stackF.Push(1000);
            stackF.Push(10000);

            Console.WriteLine("True Stack");
            List<int> listFromStackTrue = StackToList(stackT, true);
            listFromStackTrue.ForEach(item => Console.WriteLine(item));
            Console.WriteLine("False Stack");
            List<int> listFromStackFalse = StackToList(stackF, false);
            listFromStackFalse.ForEach(item => Console.WriteLine(item));
            Console.ReadLine();
        }
    }
}
