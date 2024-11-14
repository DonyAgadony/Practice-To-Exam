class Question2
{
    public static Stack<int> Combine2Stacks(Stack<int> s1, Stack<int> s2)
    {
        Stack<int> rtn = new();
        while (s1.Count > 0 || s2.Count > 0)
        {
            if (s1.Peek() > s2.Peek())
            {
                rtn.Push(s1.Pop());
            }
            else if (s1.Peek() < s2.Peek())
            {
                rtn.Push(s2.Pop());
            }
            else
            {
                rtn.Push(s1.Pop());
                rtn.Push(s2.Pop());
            }
        }
        return rtn;
    }
}