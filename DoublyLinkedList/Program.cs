namespace DoublyLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<string> doublyLinkedList = new DoublyLinkedList<string>();

            doublyLinkedList.Add("Martin");
            doublyLinkedList.Add("Jac");
            doublyLinkedList.Add("Tom");
            doublyLinkedList.AddFirst("Kate");

            foreach (var item in doublyLinkedList)
            {
                Console.WriteLine(item);
            }

            doublyLinkedList.Remove("Martin");
            Console.WriteLine();


            foreach (var t in doublyLinkedList.BackEnumerator())
            {
                Console.WriteLine(t);
            }
        }
    }
}
