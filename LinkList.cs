using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkList<T>
    {
        Node<T> head;
        Node<T> tail;
        public void AddFirst(T data)
        {
            Node<T> newNode = new Node<T>(data);
            
            if (head == null) 
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }

        public void AddLast(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (head == null)
            {
                head = newNode;
                tail = newNode;

            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
        }

        public bool AddAfter(T searchData, T addData)
        {
            Node<T> newNode = new Node<T>(addData);
            Node<T> temp = head;

            while (temp != null)
            {
                if (temp.data.Equals(searchData))
                {
                    newNode.next = temp.next;
                    temp.next = newNode;
                    return true;
                }
                temp = temp.next;
            }

            Console.WriteLine($"{searchData} does not exist in the Linked List!!!");
            return false;
        }

        public void DeleteFirst()
        {
            if (head == null)
            {
                Console.WriteLine("The List is Empty");
            }
            else
            {
                Console.WriteLine(head.data + "-> First element is deleted successfully");
                head = head.next;
            }
        }

        public void DeleteLast()
        {
            if (head == null)
            {
                Console.WriteLine("The List is Empty");
                return;
            }

            if (head == tail)
            {
                Console.WriteLine(head.data + " The Last element is Deleted successfully");
                head = null;
                tail = null;
                return;
            }

            Node<T> temp = head;
            while (temp.next != tail)
            {
                temp = temp.next;
            }

            Console.WriteLine(tail.data + " The Last element is Deleted successfully");
            temp.next = null;
            tail = temp;
        }

        public void Display()
        { 
            Node<T> temp= head;
            while (temp != null) 
            {       
                Console.Write(temp.data + "->");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
