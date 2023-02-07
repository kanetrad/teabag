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

			int[] bots = {1, 2, 3, 4, 5};
			int bot_amount = 0;
			int botHP = 100;
			int power = random.Next(1, 10);
			int dPower = random.Next(1,100);
			int randomSword = random.Next(2,5);
			int randomJustice = random.Next(1,2);

			if (dPower>60)
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

			if (dPower<60)
			{
				int attack = random.Next(20,100);
			}

			while (bot_amount != 5)
			{
				int battleID = random.Next(1, 5);
				string resultofid = "bot" + battleID.ToString();
				bot_amount++;
				Console.WriteLine(resultofid);
			}

			Console.ReadLine();
		}
	}
}