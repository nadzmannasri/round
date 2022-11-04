using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace round
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ellipse anellipse = new ellipse();
            anellipse.MajorRad = 3;
            anellipse.MinorRad = 2;
            Console.WriteLine(anellipse.Area());
            circle acircle = new circle();
            
            Console.ReadKey();
        }

    }
}
