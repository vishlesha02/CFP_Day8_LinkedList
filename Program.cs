namespace LinkedList
{
    class Program 
    {

        public static void Main(String[] args)
        {

            LinkList<int> l1 = new LinkList<int>();

            //Adds the element at the very start of list
            l1.AddFirst(1);
            l1.AddFirst(9);
            l1.AddFirst(5);  
            l1.Display();
            
            //Adds the element at last of list
            l1.AddLast(55);
            l1.AddLast(32);
            l1.Display();

            //Adds the element after a particular element user chooses
            l1.AddAfter(9,6);
            l1.Display();


            //Deletes the very first element from the list
            l1.DeleteFirst();
            l1.Display();

        }
    }



}