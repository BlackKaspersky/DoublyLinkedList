using System.Collections;

namespace DoublyLinkedList
{
    public class DoublyLinkedList<T> : IEnumerable<T>
    {
        private int count;

        DoublyNode<T>? head;
        DoublyNode<T>? tail;

        public int Count { get { return count; } }

        public bool IsEmpty { get { return count == 0; } }

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void Add(T item)
        {
            var doublynode = new DoublyNode<T>(item);
            if (IsEmpty)
            {
                head = doublynode;
            }
            else
            {
                tail.Next = doublynode;
                doublynode.Previous = tail;
            }
            count++;
            tail = doublynode;
        }

        public void AddFirst(T item)
        {
            var doublynode = new DoublyNode<T>(item);
            var temp = head;
            doublynode.Next = temp;
            head = doublynode;
            if (count == 0)
                tail = head;

            else
                temp.Previous = doublynode;

            count++;
        }

        public void Remove(T item)
        {
            DoublyNode<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(item))
                {
                    break;
                }
                current = current.Next;
            }
            if (current != null)
            {

                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {

                    tail = current.Previous;
                }

                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {

                    head = current.Next;
                }
                count--;
                return;
            }
            return;
        }
        public bool Contains(T data)
        {
            DoublyNode<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }


 
       
        public IEnumerable<T> BackEnumerator()
        {
            DoublyNode<T> current = tail;
            while (current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            DoublyNode<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
