Console.WriteLine("Digite quantas linhas terá a sua matriz: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Digite quantas colunas terá a sua matriz: ");
int m = int.Parse(Console.ReadLine());

int[,] matriz = new int[n, m];
for (int lin = 0; lin < n; lin++)
{
    Console.WriteLine("Digite os números da linha {0}: ({1} elementos)", lin + 1, m);
    string[] nums = Console.ReadLine().Split(" ");
    for (int col = 0; col < m; col++)
    {
        matriz[lin, col] = int.Parse(nums[col]);
    }
}
for (int lin = 0; lin < n; lin++)
{
    for (int col = 0; col < m; col++)
    {
        Console.Write(matriz[lin, col] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Digite o número que você quer verificar");
int verify = int.Parse(Console.ReadLine());

for (int lin = 0; lin < n; lin++)
{
    for (int col = 0; col < m; col++)
    {
        if (matriz[lin, col] == verify)
        {
            Console.WriteLine("Position: {0},{1}", lin, col);
            if (lin - 1 >= 0) Console.WriteLine($"Up: {matriz[lin - 1, col]}");
            if (col - 1 >= 0) Console.WriteLine($"Left: {matriz[lin, col - 1]}");
            if (col + 1 < m) Console.WriteLine($"Right: {matriz[lin, col + 1]}");
            if (lin + 1 < n) Console.WriteLine($"Down: {matriz[lin + 1, col]}");
        }
    }
}

