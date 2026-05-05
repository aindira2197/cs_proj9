int[] ReverseArray(int[] arr)
{
    int n = arr.Length;
    int[] res = new int[n];
    for (int i = 0; i < n; i++)
        res[i] = arr[n - i - 1];
    return res;
}
