namespace PathDemo;

class Program
{
    static void Main(string[] args)
    {
        string path = @"~/dev/csharp/Aula9-Trabalhando-com-arquivos/Aulas/README.md";


        Console.WriteLine(Path.GetDirectoryName(path));
        Console.WriteLine("Path Directory Separator char: " + Path.DirectorySeparatorChar);
        Console.WriteLine("Path Separator : " + Path.PathSeparator);
        Console.WriteLine("Path get file name: " + Path.GetFileName(path));
        Console.WriteLine("Path get file name without extension: " + Path.GetFileNameWithoutExtension(path));
        Console.WriteLine("Path get extension: " + Path.GetExtension(path));
        Console.WriteLine("Path get temp path " + Path.GetTempPath());
        Console.WriteLine("Path get full Path " + Path.GetFullPath(path));
    }
}
