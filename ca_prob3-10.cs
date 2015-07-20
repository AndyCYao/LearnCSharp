//Code abbey problem 1 Jul 19 2015
using System;

//gonna write a few more problem cases here since they are relatively simple. 
class CA_3{
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
}