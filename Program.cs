namespace LinkedList
{
    class Program 
    {

        public static void Main(String[] args)
        {

            LinkList<int> l1 = new LinkList<int>();
            l1.AddFirst(1);
            l1.AddFirst(2);
            
            l1.Display();

            l1.AddLast(55);
            l1.AddLast(32);

            l1.Display();
        
        
        }
    }



}