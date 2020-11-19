using System;

public class Average
{	
	public static void Main()
	{
		double a = 0, b, c = 0, d;
		string mark;
		
		Console.Write("Insert a mark: ");
		mark = Console.ReadLine();	// we read the mark as string to check the word "end"
			 
		while(mark != "end") // if the mark isn't an end then we pass it to double to work with it
		{ 	
			b = Convert.ToDouble(mark);
		
			c++;   //counter of numbers
			a+=b;  // sum of all the notes
		
			Console.Write("Insert a mark: ");
			mark = Console.ReadLine();
		}
			if(c != 0)
			{
				d = a/c;  //calculate the average
				Console.WriteLine("The average is {0}.", d);
			}
	}
}
