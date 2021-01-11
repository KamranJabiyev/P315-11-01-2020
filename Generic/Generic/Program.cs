using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Generic type class
            //MyList intList = new MyList();
            //intList.AddItem(1);
            //intList.AddItem(100);

            //MyList1 strList = new MyList1();
            //strList.AddItem("Fikret");
            //strList.AddItem("Mehemmedeli");

            //MyList2 personList = new MyList2();
            //personList.AddItem(new Person("Javid"));

            //MyList<int> intList = new MyList<int>();
            //intList.AddItem(5);

            //MyList<string> strList = new MyList<string>();
            //strList.AddItem("Test");

            //MyList<Person> people = new MyList<Person>();
            //people.AddItem(new Person("Mehemmedeli"));

            //MyList<Person, Object> plist = new MyList<Person, Object>();
            #endregion

            #region Generic type method
            //Print("Javid");
            //Print(5);
            //Print<Person>(new Person());
            #endregion

            #region Collection
            #region ArrayList
            //ArrayList arrList = new ArrayList();
            //arrList.Add(5);
            //arrList.Add("word");
            //arrList.Add(true);
            //arrList.Add(new Person("Tural"));
            //arrList.Add(true);
            //Console.WriteLine(arrList.LastIndexOf(true));
            //arrList.RemoveAt(1);
            //arrList.Remove(true);
            //Console.WriteLine(arrList.Contains("test"));
            //arrList.Clear();
            //foreach (var item in arrList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region List
            //List<string> list = new List<string>(3);
            //list.Add("word1");
            //list.Insert(1, "word2");
            //list.Insert(2, "word3");
            //list.Insert(3, "word3");

            //List<Person> people = new List<Person>();
            #endregion

            #region Dictionary
            //Dictionary<string, string> phones = new Dictionary<string, string>();
            //phones.Add("Kamran", "+994502373434");
            //phones.Add("Fikret", "+994505593399");
            //phones.Add("Mehemmedeli", "+994552038200");

            //Console.WriteLine(phones["Fikret"]);

            //foreach (var item in phones)
            //{
            //    Console.WriteLine($"{item.Key} : {item.Value}");
            //}
            #endregion

            #region Queue - FIFO
            //Queue<string> q = new Queue<string>();
            //q.Enqueue("Tural");
            //q.Enqueue("Cavid");
            //q.Enqueue("Fikret");

            //Console.WriteLine("Novbeden chixan:");
            //int count = q.Count;
            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine(q.Dequeue());
            //}

            //Console.WriteLine("Novbesi chatan:");
            //Console.WriteLine(q.Peek());

            //Console.WriteLine("Novbeden chixan:");
            //Console.WriteLine(q.Dequeue());
            //Console.WriteLine(q.Dequeue());

            //Console.WriteLine("Novbedekiler:");
            //foreach (string item in q)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Stack - LIFO
            //Stack<string> stack = new Stack<string>();
            //stack.Push("Fikret");
            //stack.Push("Javid");
            //stack.Push("Tural");

            //Console.WriteLine(stack.Pop());

            //foreach (string item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #endregion
        }
        #region Generic type method
        static void Print<T>(T item) where T:class
        {
            Console.WriteLine(item);
        }
        #endregion
    }

    #region Generic type class
    //class MyList<T> where T : class
    //class MyList<T> where T : struct
    //class MyList<T> where T : IRun,new()
    class MyList<T,U> where T : U where U:class,new()
    {
        private T[] arr;

        public MyList()
        {
            arr = new T[0];
        }

        public void AddItem(T item)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = item;
        }
    }

    interface IRun
    {

    }
    class Person:IRun
    {
        public string Name { get; set; }
        public Person()
        {

        }
        
        public Person(string name)
        {
            Name = name;
        }
    }
    #endregion
}
