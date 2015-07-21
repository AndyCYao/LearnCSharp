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
        // Minimum of Three
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
<<<<<<< HEAD

    public void RunCA6(System.IO.StreamReader CA_File)
    {
        // Rounding
        string line;
        double[] nums;
        double rnd_ans;
        string rst = "";
        while ((line = CA_File.ReadLine()) != null)
        {
            nums = Array.ConvertAll(line.Split(), double.Parse);
            rnd_ans = Math.Round(nums[0] / nums[1]);
            // Console.WriteLine(rnd_ans);
            rst = rst + rnd_ans.ToString() + " ";
        }
        Console.WriteLine(rst);
    }

    public void RunCA7(System.IO.StreamReader CA_File)
    {
        // Fahrenheit to Celsius
        int i = 1; // Counter
        string line;
        double[] nums;
        double rnd_ans;
        string rst = "";
        while ((line = CA_File.ReadLine()) != null)
        {
            nums = Array.ConvertAll(line.Split(), double.Parse);
            while(i < nums.Length){
    
                rnd_ans = Math.Round((nums[i] - 32) * (5.0 / 9.0));
                // Console.WriteLine(rnd_ans);
                rst = rst + rnd_ans.ToString() + " ";
                i += 1;
            }
        }
        Console.WriteLine(rst);
    }
=======
>>>>>>> 886a5ceae152af8d26a9567d8fcd17d428c35769
}