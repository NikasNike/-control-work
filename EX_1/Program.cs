int [] Mass = new int [10];

int[] FillMass(int[] Mass)
{
    for (int i = 0; i < Mass.Length; i++)       //заполнение первого массива
        {
            Mass[i] = (new Random()).Next(1, 20);
        }
        return Mass;
}
int[] SortMass(int[] Mass)
{
    int p=0;
    for (int i = 0; i < Mass.Length; i++) //длинна второго массива
        {
            if (Mass[i]%2 == 0)
                {
                    p++;     
                }
        }
    int [] Mass2 = new int [p];

    for(int u = 0,j=0; u<Mass.Length && j < Mass2.Length; u++) // заполнение второго массива
    {
        if (Mass[u]%2 == 0)
            {
                Mass2[j]  = Mass[u];
                j++;  
            }
    }
    return Mass2;
}

void PrintArray(int[] col)  // Вывод массива в консоль
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
            if(count-1>position)
            {
            Console.Write(col[position] +", ");
            position++;
            }
            else
            {
                Console.Write(col[position] +" ");
                position++;
            }
    }  
    Console.WriteLine();
}

Mass = FillMass(Mass);
Console.Write("First array: ");
PrintArray(Mass);
Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||");
Console.Write("Second array: ");
PrintArray(SortMass(Mass));


 


