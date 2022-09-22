namespace MergeTwoSortedLists21
{
    public class LinkedList
    {
       

        public ListNode CreateListFromArray(int[] arr)
        {
            ListNode head = null;
            for (int i = 0; i < arr.Length; i++)
            {
                var newNode = new ListNode(arr[i]);
                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    var curr = head;
                    while (curr.next != null)
                    {
                        curr = curr.next;
                    }
                    curr.next = newNode;
                }

            }
            return head;
        }

        public void DisplayLinkedList(ListNode head)
        {
            if (head == null) { System.Console.WriteLine("List is empty"); }

            ListNode curr = head;
            System.Console.Write("[");
            while(curr!= null)
            {
                System.Console.Write(curr.val + (curr.next != null ? ", " : ""));
                curr = curr.next;
            }
            System.Console.Write("]");
        }
    }
}
