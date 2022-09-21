
int[] array = {11, 12, 31, 47, 18, 53, 16, 17, 18};

int n = array.Length;
int find = 18;
int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine("Индекс искомого числа - " + index);
        break;
    }
    index++;
}

