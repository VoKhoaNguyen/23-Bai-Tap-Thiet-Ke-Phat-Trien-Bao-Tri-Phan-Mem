using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Tạo đối tượng adapter và gọi request
            Target target = new Adapter();
            target.Request();

            Console.ReadKey();
        }
    }
}
