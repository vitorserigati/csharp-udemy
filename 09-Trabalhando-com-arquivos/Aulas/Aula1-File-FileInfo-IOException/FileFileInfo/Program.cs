namespace FileFileInfo;


class Program
{
    static void Main(string[] args)
    {
        string sourcePath = @"/tmp/FileTest.txt";
        string targetPath = @"/tmp/FileTest2.txt";

        try{
            FileInfo file = new FileInfo(sourcePath);
            file.CopyTo(targetPath);
            string[] lines = File.ReadAllLines(sourcePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

        }catch(IOException e)
        {
            Console.WriteLine("An error ocurred");
            Console.WriteLine(e.Message);
        }
    }
}
