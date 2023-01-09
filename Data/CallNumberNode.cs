namespace PROG7312_POE;


class CallNumberNode<T>
{
    // Where a node is an Area
    public T Value { get; set; }
    public CallNumberNode<T> Parent { get; set; }
    public List<CallNumberNode<T>> Children { get; set; }
}

