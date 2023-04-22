int [] array = {25,6,8,99,63,45,85};
int n = array.Length;
int find = 99;
int index = 0;
while (index<n)
{
    if (array[index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}