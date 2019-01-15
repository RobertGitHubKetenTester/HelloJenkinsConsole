using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloJenkinsConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CreateMessage());

            //slechte code gemaakt vanwege sonarcubetest in Jenkins
            int a = 100;
            int b = 0;
            int c = a / b;
        }

        public static String CreateMessage()
        {
            return "Hello daar Jenkins";
        }
    }
}
