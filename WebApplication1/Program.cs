using System.Reflection;
using System.Runtime.InteropServices;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Serve.Run(RunOptions.Default.ConfigureBuilder(builder =>
            {
                builder.Host.UseSerilogDefault();
            }));

        }
    }
}