using System.ComponentModel;
using System.Data;

public class ReadWriteFile {
	
	public static double [,]  genData (int n) {
		
		double [,] res = new double [n,n];

		Random rd = new Random ();

		for (int i=0; i<n; i++)
		{
			for (int j=i; j<n; j++)
			{
				double val = Math.Round(rd.NextDouble()*100,2);
				res[i,j] = val;
				res[j,i] = val;
				if (i==j)
					res[i,j] = 0.00;
			}
		}
		return res;
	}
	
	public static void writeResult(double [,] result) //you may need to add 1 more parameter to make the method dynamic for datasets
	{
		
		string filename = "mstData_xx.csv"; //modify this variable so that it can take a dynamic process. E.g., mstData_datasize.csv

		using(StreamWriter sw = new StreamWriter(filename))
		{
			for (int i=0; i<result.GetLength(0); i++)
			{
				for (int j=0; j<result.GetLength(1); j++)
				{
					sw.Write(result[i,j]);
					if(j<result.GetLength(1)-1)
						sw.Write(",");
				}
				sw.WriteLine();
			}
		}
	}
	
	public static double [,] readCSV () {
		
		String file = @"/Users/zairulmazwan/Dotnet/SolADSLabWeek10/SolADSLabWeek10/mstData.csv";
		double [,] graph = null;
		int row=0, col=0;
		
		using(StreamReader sr = new StreamReader(file))
		{
			while (!sr.EndOfStream)
			{
				row++;
				var line = sr.ReadLine();
				var values = line.Split(",");
				col = values.Length;

			}
		}

		graph = new double [row,col];


		using(StreamReader sr = new StreamReader(file))
		{
			string line = null;
			int i=0;
			while  ((line = sr.ReadLine()) != null)
			{
				var val = line.Split(",");
				for (int j=0; j<val.Length; j++)
				{
					graph[i,j] = Double.Parse(val[j]);
					
				}
				i++;
			}
		}
		return graph;	
	}
	
	public static void printArray (double [,] array) {
		
		for (int i=0; i<array.GetLength(0); i++)
		{
			for (int j=0; j<array.GetLength(1); j++)
			{
				Console.Write(array[i,j]);
				Console.Write(" ");
			}
			Console.WriteLine();
		}
	}

	public static void genExpDataset ()
	{
		for (int i=1000; i<10000; i+=2000)
		{
			//Call genData method, pass i to this method
			//Call writeResult method. You may need to modify the method which should take a file name for the dataset e.g 1000
		}
	}
}
//©Zairul Mazwan©