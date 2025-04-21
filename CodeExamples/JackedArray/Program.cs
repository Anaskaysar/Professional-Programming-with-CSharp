int[][] w = new int[3][]; // jagged array

w[0] = new int[3];
w[1] = new int[4];
w[2] = new int[5];

w[0][0] = 1;
w[0][1] = 5;
w[0][2] = 2;

w[1][0] = 1;
w[1][1] = 5;
w[1][2] = 2;
w[1][3] = 2;

w[2][0] = 1;
w[2][1] = 5;
w[2][2] = 2;
w[2][3] = 1;
w[2][4] = 5;

// Printing the contents of the jagged array
for (int i = 0; i < w.Length; i++)
{
    for (int j = 0; j < w[i].Length; j++)
    {
        Console.Write(w[i][j] + " ");
    }
    Console.WriteLine();
}


int wi = 0;
int v = wi + 2;
Console.WriteLine(v);