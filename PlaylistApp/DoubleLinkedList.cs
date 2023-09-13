using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistApp
{
    public class DoubleLinkedList<T>
    {
        public Node<T> Head { get; private set; }
        public Node<T> Tail { get; private set; }
        public int Size { get; private set; }

        public DoubleLinkedList()
        {
            Head = null;
            Tail = null;
            Size = 0;
        }


        public void Prepend(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
                Size++;
            }
            else
            {
                newNode.Next = Head;
                Head.Previous = newNode;
                Head = newNode;
                Size++;
            }
        }

        public void Append(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (Tail == null)
            {
                Head = newNode;
                Tail = newNode;
                Size++;
            }
            else
            {
                newNode.Previous = Tail;
                Tail.Next = newNode;
                Tail = newNode;
                Size++;
            }
        }

        public List<T> GetList()
        {
            List<T> contents = new List<T>();
            Node<T> current = Head;
            while (current != null)
            {
                contents.Add(current.Data);
                current = current.Next;
            }
            return contents;
        }

        public void Remove(T data)
        {
            Node<T> current = Head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (current.Previous != null)
                        current.Previous.Next = current.Next;
                    else
                        Head = current.Next;

                    if (current.Next != null)
                        current.Next.Previous = current.Previous;
                    else
                        Tail = current.Previous;
                    
                    Size--;
                }
                    
                current = current.Next;
                
            }
            
        }
    }
}
