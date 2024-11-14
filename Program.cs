class Node<T>
{
    T value;
    Node<T>? Next;
    public Node(T value)
    {
        this.value = value;
    }
    public Node(T value, Node<T> next)
    {
        this.value = value;
        Next = next;
    }

    public T GetValue()
    {
        return value;
    }
    public Node<T> GetNext()
    {
        return Next;
    }
    public void SetNext(Node<T> next)
    {
        Next = next;
    }
    public void SetValue(T value)
    {
        this.value = value;
    }
}
class Question3
{
    public static bool IsCircular<T>(Node<T> head)
    {
        Node<T> temp = head;
        while (temp.GetNext() != null && temp.GetNext() != head)
        {
            temp = temp.GetNext();
        }
        return temp == head;
    }
}
class Question4<T>
{
    public static Node<T>? ReverseLinkedList(Node<T> head)
    {
        if (head == null || head.GetNext() == null) { return head; }
        Node<T> NewHead = ReverseLinkedList(head.GetNext());
        head.GetNext().SetNext(head);
        head.SetNext(null);

        return NewHead;
    }
}
class Question5
{
    public static Queue<int> GetPrimes(int max)
    {
        Queue<int> queue = new Queue<int>();
        for (int i = 2; i < max; i++)
        {
            if (IsPrime(i))
            {
                queue.Enqueue(i);
            }
        }
        return queue;
    }
    public static bool IsPrime(int num)
    {
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}

class MyStack<T>
{
    Node<T>? head;
    public MyStack()
    {

    }
    public void Push(Node<T> node)
    {
        Node<T> temp = head;
        while (temp.GetNext() != null)
        {
            temp = temp.GetNext();
        }
        temp.SetNext(node);
    }
}
class Program
{
    public static void Main()
    {
        Node<int> firstNode = new Node<int>(1);

        // Create the other nodes and link them sequentially
        Node<int> secondNode = new Node<int>(2);
        Node<int> thirdNode = new Node<int>(3);
        Node<int> fourthNode = new Node<int>(4);
        Node<int> fifthNode = new Node<int>(5);

        // Link each node to the next
        firstNode.SetNext(secondNode);
        secondNode.SetNext(thirdNode);
        thirdNode.SetNext(fourthNode);
        fourthNode.SetNext(fifthNode);

        Console.WriteLine("Is the linked list circular? " + Question3.IsCircular(firstNode));
        Question4<int>.ReverseLinkedList(firstNode);
        while (fifthNode != null)
        {
            Console.Write(fifthNode.GetValue() + " ");
            fifthNode = fifthNode.GetNext();
        }
    }
}