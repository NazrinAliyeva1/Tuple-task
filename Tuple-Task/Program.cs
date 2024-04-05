namespace Tuple_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (int, double) pr = (2, 3.1);
            Console.WriteLine($"Tuple with elements {pr.Item1} and {pr.Item2}.");

            (double Sum, int Count, double Sum2) ds =(12.1, 12, 43.2);
            Console.WriteLine($"Tuple2 with elements {ds.Sum}, {ds.Count} and {ds.Sum2}.");

            (string, int, double, string) student = ("Nura", 5, 93.5, "Elaci");
            Console.WriteLine($"Tuple3 with elements {student.Item1}, {student.Item2}, {student.Item3} ve {student.Item4}.");

        }
    }
}
