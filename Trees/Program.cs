using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    int[] arr = { 2, 6, 9, 13, 4, 77, 12, 40, 6, 7, 1 };
        //    Filter(arr, (val) => val %2 == 0);

        //}

        //static void Filter(int[] a, Predicate<int> query)
        //{
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        if (query(a[i])) Console.WriteLine(a[i]);
        //    }
        //}

        static void Main(string[] args)
        {
            int start = 20;
            BST<int> tree = new BST<int>();
            tree.Add(start);
            tree.Add(6);
            tree.Add(4);
            tree.Add(7);
            tree.Add(1);
            tree.Add(5);
            tree.Add(3);
            tree.Add(23);
            tree.Add(21);
            tree.Add(22);
            tree.Add(22);
            tree.Add(22);
            tree.Add(20);
            tree.Add(19);
            tree.Add(24);
            tree.Add(25);
            tree.Add(2);
            tree.Add(27);
            tree.Add(22);
            tree.Add(20);
            tree.Add(19);
            tree.Add(24);

            Console.WriteLine(tree.GetLevels());
            Console.WriteLine();

            tree.InOrder((c) => Console.WriteLine(c.ToString()));
            Console.WriteLine();

            int tmp;
            if (tree.Remove(start, out tmp))
            {
                tree.InOrder((c) => Console.WriteLine(c.ToString()));

            }

            Console.WriteLine();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    if (tree.Remove(j, out tmp))
                        Console.WriteLine(tmp);
                }
            }

            tree.InOrder((c) => Console.WriteLine(c.ToString()));


            //tree.Add(new Person("aaa", 12, 1234567, "TLV"));
            //tree.Add(new Person("ddd", 34, 3634634, "Ashkelon"));
            //tree.Add(new Person("ccc", 91, 9675600, "Lod"));
            //tree.Add(new Person("bbb", 18, 2413278, "Shilo"));
            //tree.InOrder(Person.PrintPerson);


            //tree.InOrder((per) => Console.WriteLine(per));
            //Person dummy = new Person("ccc");
            //Person p;
            //bool isFound = tree.Search(dummy, out p);
            //if (isFound)
            //    Console.WriteLine("found item is {0}", p.ToString());

            //ShowRes((n1, n2) => n1 * n2);
            //ShowRes((n1, n2) => n2 - n1);

        }

        static void ShowRes(Func<int, int, long> addFunc)
        {
            long res = addFunc(3, 200);
            Console.WriteLine(res);
        }

    }
}
