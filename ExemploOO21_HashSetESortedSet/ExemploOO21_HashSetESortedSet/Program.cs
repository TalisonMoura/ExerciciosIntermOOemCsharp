using ExemploOO21_HashSetESortedSet.Entities;

namespace ExemploOO21_HashSetESortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook"));

            foreach (string p in set)
            {
                Console.WriteLine(p);
            }

            ////////////////////////////////////////////////////////////////

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int> { 5, 6, 7, 8, 9, 10 };

            // UNION: UNIÃO DE ELEMENTOS ENTRE OS DOIS CONJUNTOS.
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);

            // INTERSECTION:  VERIFICAÇÃO DE ELEMENTOS QUE EXISTEM NOS DOIS CONJUNTOS. 
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            // DIFFERENCE: VERIFICAÇÃO DE ELEMETNOS QUE EXISTE EM UM CONJUNTO E OUTRO NÃO.
            SortedSet<int> e = new SortedSet<int>(a);
            e.IntersectWith(b);
            PrintCollection(e);

            ////////////////////////////////////////////////////////////////
            ///////////COMO AS COLEÇÕES HASH COMPARAM IGUALDADE////////////

            HashSet<Product> pr = new HashSet<Product>();
            pr.Add(new Product("TV", 900.0));
            pr.Add(new Product("Notebook", 1200.0));

            HashSet<Point> po = new HashSet<Point>();
            po.Add(new Point(3, 4));
            po.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0);
            Console.WriteLine(pr.Contains(prod));

            Point point = new Point(5, 10);
            Console.WriteLine(po.Contains(point));

        }
        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write($"{obj}  ");
            }
            Console.WriteLine();
        }

    }
}