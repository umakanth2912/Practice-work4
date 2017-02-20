using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myclass
{
    class Printtwonumbers

    {

        public int printtwonumbers(int a, int b) //method two add two numbers which takes
                                                 //two parameters as input and returns output/
        {
           int c = a + b;
            return c;
        }
        static void Main(string[] args)
        {
            Printtwonumbers two = new Printtwonumbers(); // instantiating the printtwonumbers class/
            int sum=two.printtwonumbers(1,2);
            Console.WriteLine("sum is:{0}", sum);
            Console.ReadLine();
        }
        
    }
}
