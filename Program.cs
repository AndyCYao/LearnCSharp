using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CA_3to10 x = new CA_3to10();
            string path = @"CA.txt"; //needs to be saved at the debug bin file location.
            System.IO.StreamReader file = new System.IO.StreamReader(path);


            x.RunCA5(file);
        }
    }
}
