void hinh1(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (j == 0 || j == n - 1 || j == i)
            {
                Console.Write("*");
            }
            else
                Console.Write(" ");
        }
        Console.WriteLine("");
    }
   
}





void hinh2(int n)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (j == 0 || j == n  || j == i)
            {
                Console.Write("*");
            }
            else
                Console.Write(" ");
        }
        Console.WriteLine("");
    }

}
hinh2(50);