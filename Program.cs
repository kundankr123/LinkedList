namespace LinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Linked List programs.");


            Linkedlist list = new Linkedlist();
            //list.Addatbegning(70);
            //list.Addatbegning(30);
            //list.Addatbegning(56);

            //list.Addatend(56);
            //list.Addatend(30);
            //list.Addatend(70);

            list.Addatend(56);
            list.Addatend(70);
            //list.PrintList();
            list.InsertAfter(56, 30);
            list.PrintList();

            //list.Pop();
            //list.PrintList();

            //int poppedValue = list.popLast();

            //list.PrintList();

            bool result = list.Search(30);
            Console.WriteLine("Value 30 found: " + result);


        }   
    }
}