/*double [,] mat = new double[2,3];
Console.WriteLine(mat.Length);
Console.WriteLine(mat.Rank);
Console.WriteLine(mat.GetLength(0));
Console.WriteLine(mat.GetLength(1));*/
Console.WriteLine("Digite qual a ordem da matriz: ");
int ordem = int.Parse(Console.ReadLine());
int[,] matriz = new int[ordem, ordem];

for (int linha = 0; linha < ordem; linha++)
{
    for (int col = 0; col < ordem; col++)
    {
        Console.WriteLine($"Digite o item da {linha + 1}ª linha e {col + 1}ª coluna");
        matriz[linha, col] = int.Parse(Console.ReadLine());
    }
}
int negativos = 0;
for (int linha = 0; linha < ordem; linha++)
{
    for (int col = 0; col < ordem; col++)
    {
        if (col == linha) Console.WriteLine(matriz[linha, col]);

        if (matriz[linha, col] < 0) negativos += 1;

    }
}

Console.WriteLine("Negativos : {0}", negativos);
