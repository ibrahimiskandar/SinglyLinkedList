using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeList
{
    public class NodeList
    {
        public Node Head { get; set; }

        public void AddLast(int value)
        {
            Node toAdd = new Node(value);
            if (Head == null)
            {
                Head = toAdd;
            }
            else
            {

                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                
                current.Next = toAdd;
            }
        }


        public void AddFirst(int value)
        {
           Head =new Node(value,Head);
        }

        public void Add(int value,int index)
        {
            Node current = Head;


            if (index == 0){
                Head = new Node(value, Head);
            }
            else
            {
                Node toAdd = new Node(value);
                index -= 1;
                int count = 0;
                while (index > count)
                {
                    current = current.Next;
                    count++;
                }
                toAdd.Next = current.Next;
                current.Next = toAdd;
            }
            
        }


        public void deleteNode(int position)
        {

            if (Head == null)
                return;

            Node temp = Head;

            if (position == 0)
            {
                Head = temp.Next;
                return;
            }

            for (int i = 0; temp != null && i < position - 1;
                 i++)
                temp = temp.Next;

            if (temp == null || temp.Next == null)
                return;

            Node next = temp.Next.Next;
            temp.Next = next;
        }


        public void PrintList()
        {
            Node Current = Head;

            while(Current!=null)
            {
                Console.WriteLine(Current.Value);
                Current = Current.Next;
            }
            
        }
    }
}
