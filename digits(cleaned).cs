using System;

class digits
{
	static void Main()
	{
		
		int counter1 = 0, counter2 = 0, counter3 = 0, counter4 = 0; //counters of number of digits a is for one digit, b is for 2 digits, c is for 3 digits and d is for more than 3 digits
		
		Console.Write("Insert a number: ");
		string signal = Console.ReadLine(); // read the number as string to check the word "end"
		
		while(signal != "end")
		{
			Console.Write("Insert a number: ");
			signal = Console.ReadLine();
			
			int input = Convert.ToInt32(signal);
			
			if(input != 0)
			{
				if(input/10 == 0) // it only has one digit
				counter1++;  
				
				else 
				
				if (input/100 == 0) // the number has 2 digits
				counter2++;  
				
				else
				
				if (input/1000 == 0) // the number has 3 digits
				counter3++;  
				
				else
				counter4++;  // the number has more than 3 digits
			}
			 
		}
			Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", counter1, counter2, counter3, counter4);
	}
}

