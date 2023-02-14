namespace FileExcerciseDemo;
using FileExcerciseDemo.Entities;
class Program
{
    static void Main(string[] args)
    {
        string path = @"/home/vitor/dev/csharp/Aula9-Trabalhando-com-arquivos/Exercicio/db/Products.csv";
        string destinyPath = Directory.GetParent(path).ToString();
        List<Product> products = new List<Product>();

        try
        {
            using (StreamReader data = File.OpenText(path))
            {
                while (!data.EndOfStream)
                {
                    string[] line = data.ReadLine().Split(",");
                    Product prod = new(line);
                    products.Add(prod);
                }
                if (!Directory.Exists(@$"{destinyPath}/out"))
                {
                    Directory.CreateDirectory(@$"{destinyPath}/out");
                }

                using (StreamWriter sw = File.AppendText(@$"{destinyPath}/out/summary.csv"))
                {
                        sw.WriteLine("Product Name,Total Sold");
                    foreach (Product product in products)
                    {
                        sw.WriteLine(product.ToString());
                    }
                }

            }
        }
        catch (IOException e)
        {
            Console.WriteLine($"Something went wrong! {e.Message}");
        }
    }
}
