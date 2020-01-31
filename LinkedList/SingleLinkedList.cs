using System;
using System.Collections;

namespace SingleLinkedList
{
    public class LinkedList<T>
    {
        public int Count { get; private set; }

        private LinkedListNode<T> head;
        private LinkedListNode<T> tail;

        public void Add(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);

            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.Next = node;
            }

            tail = node;
            Count++;
        }

        public bool Remove(T value)
        {
            LinkedListNode<T> current = head;
            LinkedListNode<T> previous = null;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;

                        if (current.Next == null)
                        {
                            tail = previous;
                        }
                    }
                    else
                    {
                        head = head.Next;

                        if (head == null)
                        {
                            tail = null;
                        }
                    }

                    Count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }

        public void CopyToArray(T[] array, int arrayIndex)
        {
            LinkedListNode<T> current = head;

            while (current != null && arrayIndex < array.Length)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public void Clear()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        public bool IsEmpty { get { return Count == 0; } }

        public bool Contains(T value)
        {
            LinkedListNode<T> current = head;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        
        public IEnumerator GetEnumerator()
        {
            LinkedListNode<T> current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
    }
}
