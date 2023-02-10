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
			Console.WriteLine("Enter bot amount: ");
			int bot_amount = Int32.Parse(Console.ReadLine());
			int FFF = 1;
			int[] bots = {1,2,3,4,5,6,7,8,9,10};
			int botHP = 100;
			//int TWO = 0;
			//int bot_amount = Convert.ToInt32(bot_amount_str);
			int power = random.Next(1, 10);
			int dPower = random.Next(1, bot_amount+100);
			//int randomJustice = random.Next(1,2);
			int battleID;
			int bot;
			int randomBOT = random.Next(1, bots.Length);

			while (FFF != bot_amount+1)
			{
				battleID = random.Next(1, bot_amount);
				bot = battleID;
				int battleID2 = random.Next(1, bot_amount);
				string result = "bot" + battleID;
				FFF++;
				Console.WriteLine(result);

				if (FFF == bot_amount+1)
				{
					Console.WriteLine("bot"+battleID+" VS "+"bot"+battleID2);
					Console.WriteLine("!!!   Bots have been split into 2 people   !!!");

					while (botHP > 0)
					{
						botHP = botHP - power;
						Console.WriteLine("bot"+battleID+" was damaged by "+"bot"+battleID2+" for -"+random.Next(1, 10));
						if (botHP <= 0)
						{
							Console.WriteLine("!!!   bot"+randomBOT+" is dead   !!!");
							break;
						}
					}
					break;
				}
				
				//while (bot_amount / 2 > 2)
				//{
				//	bot_amount--;
				//}

			}

			/*while (TWO <= 2)
			//{
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
				//TWO++;
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
				//TWO++;
			}
			//}*/

			Console.ReadLine();
			
		}
	}
}