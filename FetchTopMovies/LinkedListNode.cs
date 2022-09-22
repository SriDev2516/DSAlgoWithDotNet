namespace FetchTopMovies
{
    public class LinkedListNode
    {
        public int key;
        public int data;
        public LinkedListNode next;
        public LinkedListNode arbitraryPointer;

        public LinkedListNode(int data)
        {
            this.data = data;
            this.next = null;
        }

        public LinkedListNode(int data, int key)
        {
            this.data = data;
            this.next = null;
            this.key = key;
        }

        public LinkedListNode(int data, LinkedListNode next)
        {
            this.data= data;
            this.next = next;
        }

        public LinkedListNode(int data, LinkedListNode next, LinkedListNode arbitraryPointer)
        {
            this.next = next;
            this.data = data;
            this.arbitraryPointer = arbitraryPointer;
        }
    }
}
