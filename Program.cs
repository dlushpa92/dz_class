//namespace dz_class
//{

//    using System;
//    using System.Collections.Generic;

//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            var s1 = new Stack("h2", "w", "askd");
//            s1.Add("Hello");
//            Console.WriteLine(s1.Size);
//            s1.Pop();
//            s1.Pop();
//            var s2 = new Stack("1", "2", "3");
//            s1.Merge(s2);
//            Console.WriteLine(s1.Size);
//            Console.WriteLine(s1.Top);


//        }


//        public class Stack
//        {
//            private List<string> _items = new List<string>();
//            public Stack(params string[] items)
//            {
//                _items.AddRange(items);
//            }

//            public void Add(string item)
//            {
//                _items.Add(item);
//            }

//            public string Pop()
//            {
//                if (Size == 0)
//                {
//                    throw new Exception("Стек пустой");
//                }
//                string item = _items[Size - 1];
//                _items.RemoveAt(Size - 1);
//                return item;
//            }

//            public int Size
//            {
//                get => _items.Count;

//            }

//            public string Top
//            {
//                get => Size != 0 ? _items[Size - 1] : null;
//            }

//            public List<string> GetItems()
//            {
//                return _items;
//            }


//        }

//    }

//    public static class StackExtensions
//    {
//        public static void Merge(this Program.Stack s1, Program.Stack s2)
//        {
//            Console.WriteLine("hello");
//            //for (int i = s2.Size - 1; i >= 0; i--)
//            //{
//            //    s1.Add(s2._items[i]);
//            //}
//            foreach (var item in s2.GetItems())
//            {
//                s1.Add(item);
//            }
//        }
//    }
//}

using System;
using System.Collections.Generic;

namespace dz_class
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var s1 = new Stack("h2", "w", "askd");
            s1.Add("Hello");
            Console.WriteLine(s1.Size);
            s1.Pop();
            s1.Pop();
            var s2 = new Stack("1", "2", "3");
            s1.Merge(s2);
            Console.WriteLine(s1.Size);
            Console.WriteLine(s1.Top);
        }

        public class Stack
        {
            private List<string> _items = new List<string>();

            public Stack(params string[] items)
            {
                _items.AddRange(items);
            }

            public void Add(string item)
            {
                _items.Add(item);
            }

            public string Pop()
            {
                if (Size == 0)
                {
                    throw new Exception("Стек пустой");
                }
                string item = _items[Size - 1];
                _items.RemoveAt(Size - 1);
                return item;
            }

            public int Size => _items.Count;

            public string Top => Size != 0 ? _items[Size - 1] : null;

            // Expose the items via a public method or property
            public List<string> GetItems()
            {
                return _items;
            }
        }
    }

    internal static class StackExtensions
    {
        internal static void Merge(this Program.Stack s1, Program.Stack s2)
        {
            Console.WriteLine("Merging stacks...");

            foreach (var item in s2.GetItems())
            {
                s1.Add(item);
            }
        }
    }
}
