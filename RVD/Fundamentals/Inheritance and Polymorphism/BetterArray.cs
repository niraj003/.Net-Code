class BetterArray : NewArray
{
    public BetterArray(int size) : base(size)
    {
        
    }

    public new void Insert(int element)
    {
        if (count == arr.Length)
        {
            int[] temp = new int[2 * arr.Length];
            Array.Copy(arr, temp, arr.Length);
            arr = temp;
        }
        base.Insert(element);
    }
}