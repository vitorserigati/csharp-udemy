namespace DirectoryDemo;

class Program
{
    static void Main(string[] args)
    {
        string path = @"/tmp/MyFolder";

        try{
            //Can use 'var folders' instead
            IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);            
            Console.WriteLine("Folders: ");
            foreach(string folder in folders)
            {
                Console.WriteLine(folder);
            }


            var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);            
            Console.WriteLine("Folders: ");
            foreach(string file in files)
            {
                Console.WriteLine(file);
            }

            Directory.CreateDirectory(path + "/Testing");



        }catch(IOException e)
        {
            Console.WriteLine("Deu Bayblade!");
            Console.WriteLine(e.Message);
        }

    }
}

