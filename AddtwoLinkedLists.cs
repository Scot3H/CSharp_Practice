public class AddLists
{
    public LinkedListNode<int> AddLinkedList(LinkedListNode<int> i, LinkedListNode<int> j)
    {
        int carry = 0;
        LinkedListNode<int> dummy = new LinkedListNode<int>(0);
        LinkedListNode<int> curr = dummy;
        LinkedList<int> curr_hold = new LinkedList<int>();
        curr_hold.AddLast(curr);
        while (i != null || j != null || carry == 1)
        {
            int sum = 0;
            if (i != null)
            {
                sum += i.Value;
                i = i.Next;
            }
            if (j != null)
            {
                sum += j.Value;
                j = j.Next;
            }
            sum += carry;
            carry = sum/10;
            LinkedListNode<int> node = new LinkedListNode<int>(sum % 10);
            curr_hold.AddLast(node);
            curr = curr.Next;

        }
        return dummy.Next;
    }
}