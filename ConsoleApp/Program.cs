using Microsoft.Extensions.Hosting;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Host.CreateDefaultBuilder().Build().Run();
        }
    }
}
