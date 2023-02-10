using System;

namespace Workspace
{
	//public class Creation
	//{
	//	static void CreationBot()
	//	{
			
	//	}
	//}

	public class Battle
	{
		static void Main(string[] args)
		{
			Random random = new Random();

			//string bot_amount = Console.ReadLine();
			int bot_amount = Int32.Parse(Console.ReadLine());
			int FFF = 1;
			//int bot_amount = Convert.ToInt32(bot_amount_str);
			int botHP = 100;
			int power = random.Next(1, 10);
			int dPower = random.Next(1, bot_amount*2);
			int randomSword = random.Next(2,5);
			int randomJustice = random.Next(1,2);

			while (FFF != bot_amount+1)
			{
				int battleID = random.Next(1, bot_amount);
				int bot = battleID;
				string result = "bot" + battleID;
				FFF++;
				Console.WriteLine(result);
				//if (FFF == bot_amount)
				//{
					//Console.WriteLine(result);
					//break;
				//}
			}

			/*if (dPower>60)
			{
				int attack = random.Next(50,100);
				int bot_random = random.Next(1,5);
				if (bot_random == 1)
				{
					int bot1 = 1;
					Console.WriteLine("Lucky is "+bot1.ToString());
					int bot_lucky = bot1;
				}
				if (bot_random == 2)
				{
					int bot2 = 2;
					Console.WriteLine("Lucky is "+bot2.ToString());
					int bot_lucky = bot2;
				}
				if (bot_random == 3)
				{
					int bot3 = 3;
					Console.WriteLine("Lucky is "+bot3.ToString());
					int bot_lucky = bot3;
				}
				if (bot_random == 4)
				{
					int bot4 = 4;
					Console.WriteLine("Lucky is "+bot4.ToString());
					int bot_lucky = bot4;
				}
				if (bot_random == 5)
				{
					int bot5 = 5;
					Console.WriteLine("Lucky is "+bot5.ToString());
					int bot_lucky = bot5;
				}
			}

			if (dPower<=60)
			{
				int attack_power = random.Next(20,90);
				int bot_random = random.Next(1,5);
				if (bot_random == 1)
				{
					int bot1 = 1;
					Console.WriteLine("Not so lucky is "+bot1.ToString());
					int bot_lucky = bot1;
				}
				if (bot_random == 2)
				{
					int bot2 = 2;
					Console.WriteLine("Not so lucky is "+bot2.ToString());
					int bot_lucky = bot2;
				}
				if (bot_random == 3)
				{
					int bot3 = 3;
					Console.WriteLine("Not so lucky is "+bot3.ToString());
					int bot_lucky = bot3;
				}
				if (bot_random == 4)
				{
					int bot4 = 4;
					Console.WriteLine("Not so lucky is "+bot4.ToString());
					int bot_lucky = bot4;
				}
				if (bot_random == 5)
				{
					int bot5 = 5;
					Console.WriteLine("Not so lucky is "+bot5.ToString());
					int bot_lucky = bot5;
				}
			}*/

			Console.ReadLine();
		}
	}
}