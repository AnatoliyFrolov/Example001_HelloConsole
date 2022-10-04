int[] array = { 11, 13, 54, 87, 27, 4, 66, 48, 4 };
int n = array.Length;
 int find = 4;
 int index = 0;

while(index < n)
{
    
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}