for (int i =0; i<100; i++)
{
    Console.WriteLine(i + "I will not do this 100 times");
}

int i1 = 0;

while (i1 < 100)
{
    Console.WriteLine("This is My number ");
    i1++;
}

do
{
    Console.WriteLine("I am Kb 101");
} while (i1 < 10);

//for each loop

int[] ages = [22, 23, 24, 22];

foreach(int age in ages)
{
    Console.WriteLine(age);
}