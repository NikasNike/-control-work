int [] Mass2 = new int [10];
Random rnd = new Random ();
int [] Mass = new int [10];
int lenght  = Mass.Length;

for (int i = 0; i < lenght; i++)
    {
        Mass[i] = (new Random()).Next(1, 20);
        Console.WriteLine(Mass[i]);

    }
    Console.WriteLine();

for(int i=0,j=0; i<Mass.Length && j < Mass2.Length; i++)
    {
        if (Mass[i]%2 == 0)
            {
                Mass2[j] = Mass[i];
                j++;
            }
            
    }
for(int j=0; j < Mass2.Length; j++)
{
    if(Mass2[j]>0)
    System.Console.WriteLine(Mass2[j]);
}
