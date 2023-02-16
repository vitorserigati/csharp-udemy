namespace Listas
{
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Vitor");
            list.Add("Henrique");
            list.Add("Mayara");
            list.Add("Suco");
            list.Add("Soca");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            list.Insert(3, "Morgana");
            list.Insert(4, "Tequila");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine($"List count: {list.Count}");
            Console.WriteLine($"List find: {list.Find(x => x[0] == 'M')}");
            Console.WriteLine($"List findLast: {list.FindLast(x => x[0] == 'M')}");
            Console.WriteLine($"List FindIndex: {list.FindIndex(x => x[0] == 'M')}");
            Console.WriteLine($"List FindLastIndex: {list.FindLastIndex(x => x[0] == 'M')}");
            List<string> list2 = list.FindAll(x => x.Length <= 5);
            foreach (string nome in list2)
            {
                Console.WriteLine($"List.Filter: {nome}");
            }
            list.RemoveAll(x => x.Length == 4);
            foreach (string nome in list)
            {
                Console.WriteLine($"After Removing: {nome}");

            }
            list2.RemoveAt(0);
            foreach (string name in list2)
            {
                Console.WriteLine($"List.RemoveAt(0) : {name}");
            }

            list.RemoveRange(2, 2);
            foreach (string nome in list)
            {
                Console.WriteLine($"After removing Range: {nome}");
            }


        }
    }
}
