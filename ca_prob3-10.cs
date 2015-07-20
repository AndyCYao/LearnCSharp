//Code abbey problem 1 Jul 19 2015
using System;
using System.Linq;

//gonna write a few more problem cases here since they are relatively simple. 
class CA_3to10{
    public void RunCA3(){
		string line;
		string path = @"codeabbey.txt"; //needs to be saved at the debug bin file location.
		System.IO.StreamReader file = new System.IO.StreamReader(path);
		double[] nums;
		string rst = "";
		double summing;
		while ((line = file.ReadLine()) != null)
		{
			nums = Array.ConvertAll(line.Split (), double.Parse);
			summing = nums [0] + nums [1];
			rst = rst + summing + " ";
			// Console.WriteLine(nums[0] + nums[1]);
		}
		Console.WriteLine (rst);
		file.Close();	
    }

    public void RunCA4()
    {
        // minimum of two  - Jul 20th 2015
        string line;
        string path = @"CA.txt"; //needs to be saved at the debug bin file location.
        System.IO.StreamReader file = new System.IO.StreamReader(path);
        double[] nums;
        string rst = "";
        while ((line = file.ReadLine()) != null)
        {
            nums = Array.ConvertAll(line.Split(), double.Parse);
            if (nums[1] > nums[0])
            {
                rst = rst + nums[0] + " ";
            }
            else
            {
                rst = rst + nums[1] + " ";
            }
        }
        Console.WriteLine(rst);
    }
    public void RunCA5(System.IO.StreamReader CA_File)
    {
        string rst = "";
        string line;
        int[] nums;
        while ((line = CA_File.ReadLine()) != null)
        {
            nums = Array.ConvertAll(line.Split(), int.Parse);
            rst = rst + nums.Min().ToString() + " ";
        }
        Console.WriteLine(rst);
    }
}