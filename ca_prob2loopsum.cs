using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new_consoleApp
{
    class classCA2
    {
        public void CA2()
        {
            string[] line;
            string path = @"CA.txt";
            System.IO.StreamReader file = new System.IO.StreamReader(path);
<<<<<<< HEAD
            line = file.ReadLine().Split();
            int nSum = 0;
            foreach (string a in line)
            {
                nSum += Convert.ToInt32(a);
            }
            Console.WriteLine(nSum);
            file.Close();
            //return nSum;

=======
            // line = file.ReadLine().Skip(1).Take(1).First();
            //
            //while ((line = file.ReadLine()) != null)
            //{
            //    Console.WriteLine(line);
            //}
            //Console.WriteLine(line);
            //file.Close();
>>>>>>> 7b4bcf0c0912255379f859e65caf08ed78dbb3af
        }
    }
}
