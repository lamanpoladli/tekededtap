const a = [ 23, 12, 56, 9, 7 ];
let sum = 0;

for(let i=0; i < a.length; i++)
{
    if (a[i]%2 != 0)
    {
        sum = sum + a[i];
    }
}
Console.log(sum);
