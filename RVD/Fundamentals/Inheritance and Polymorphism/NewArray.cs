class NewArray : Array
{
    private int count;

    public NewArray(int size) : base(size)
    {
        count = 0;
    }

    public void Insert(int element)
    {
        arr[count] = element;
        count++;
    }
}