using System.Text;

void swap(ref int a , ref int b)
{
    int temp = a ; a = b; b = temp;

}
void sort_arr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[i] < arr[j])
            {
                swap(ref arr[i], ref arr[j]);
            }
        }
    }
}
void sort_arr1(int[] arr)
{
    int i = 0;
    while (i < arr.Length)
    {
        int j = 0;
        while (j < arr.Length)
        {
            if (arr[i] < arr[j])
            {
                swap(ref arr[i], ref arr[j]);
            }
            j++;
        }
        i++;
    }
}
void sort_arr2(int[] arr)
{
    int i= 0;
    
    do
    {
        int j = 0;
        do
        {
            if(arr[i] < arr[j])
            {
                swap(ref arr[i],ref arr[j]);
            }
            j++;
        }while(j < arr.Length);
        i++;
    } while (i < arr.Length);
        
    
}

void create_array(int[] arr)
{
    Random rd = new Random();
    for (int i = 0; i < arr.Length; ++i)
    {
        arr[i] = rd.Next(100);
   }
}
void print_array(int[] arr)
{
    foreach(int x in arr)
    {
        Console.Write($"{x}\t");
    }
}
int[]arr=new int[10];
create_array(arr);
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Mảng trước khi sắp xếp");
print_array(arr);
Console.WriteLine("Mảng sau khi sắp xếp");
sort_arr2(arr);
print_array(arr);