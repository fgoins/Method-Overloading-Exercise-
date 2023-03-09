namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
           var whole= methods.Add(1, 2);
            var points =methods.Add(2.03m, 3.53m);
            var isMoney = methods.Add(1, 2, true);
            Console.WriteLine(  $"{whole} and \n {points} \n {isMoney}");



        }
    }
}
