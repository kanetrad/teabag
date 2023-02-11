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

			Console.WriteLine("Enter bot amount: ");
			int bot_amount = Int32.Parse(Console.ReadLine());
			int FFF = 1;
			int[] bots = {1,2,3,4,5,6,7,8,9,10};
			int botHP = 100;
			int botHP2 = 100;
			const int botHP_const = 100;
			int power = random.Next(1, 10);
			int dPower = random.Next(1, bot_amount+100);
			int randomBOT = random.Next(1, bots.Length);
			int battleID = random.Next(1, bot_amount);
			int bot = battleID;
			int battleID2 = random.Next(1, bot_amount);

			void changeTurn()
			{
				while (botHP > 0)
				{
					botHP = botHP - power;
					Console.WriteLine("bot"+battleID+" was damaged by "+"bot"+battleID2+" for -"+random.Next(1,10));
					changeTurn2();
				}
			}

			void changeTurn2()
			{
				while (botHP2 > 0)
				{
					botHP2 = botHP2 - random.Next(1, 10);
					Console.WriteLine("   bot"+battleID2+" was damaged by "+"bot"+battleID+" for -"+random.Next(1,10));
					changeTurn();
				}
			}

			while (FFF != bot_amount+1)
			{
				//string result = "bot" + random.Next(1, bot_amount);
				FFF++;
				//Console.WriteLine(result);
			
				if (FFF == bot_amount+1)
				{
					Console.WriteLine("bot"+battleID+" VS "+"bot"+battleID2);
					//Console.WriteLine("!!!   Bots have been split into 2 people   !!!");

					while (botHP > 0)
					{
						botHP = botHP - power;
						//Console.WriteLine("bot"+battleID+" was damaged by "+"bot"+battleID2+" for -"+power);
						while (botHP < botHP_const)
						{
							changeTurn2();
							break;
						}
						while (botHP2 < botHP_const)
						{
							changeTurn();
							break;
						}
						if (botHP <= 0)
						{
							botHP = 0;
							Console.WriteLine("!!!   bot"+randomBOT+" is dead   !!!");
							Console.WriteLine("THE WINNER IS "+"bot"+battleID+"!!!");
							break;
						}
					}
				}
			}

			Console.ReadLine();
			
		}
	}
}