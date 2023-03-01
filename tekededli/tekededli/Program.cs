int[] a = { 23, 12, 56, 9, 7 };
int sum = 0;

for(int i=0; i < a.Length; i++)
{
    if (a[i]%2 != 0)
    {
        sum = sum + a[i];
    }
}
Console.WriteLine(sum);
