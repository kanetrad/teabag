using System;

namespace Workspace
{
	public class Battle
	{
		static void Main(string[] args)
		{
			Random random = new Random();

			Console.WriteLine("Enter bot amount:");
			int bot_amount = Int32.Parse(Console.ReadLine());
			//int bot_amount = 2;
			int one = 1;
			int botHP = 100;
			int botHP2 = 100;
			Console.WriteLine("Enter MAX HP:");
			int botHP_const = Int32.Parse(Console.ReadLine());
			int battleID = random.Next(1, bot_amount);
			int battleID2 = random.Next(battleID, bot_amount+1);

			void changeTurn()
			{
				while (botHP > 0)
				{
					botHP = botHP - random.Next(1, 10);
					Console.WriteLine("bot"+battleID+" was damaged by "+"bot"+battleID2+" for in sum "+(botHP - botHP_const));
					changeTurn2();

					if (botHP <= 0)
					{
						botHP = 0;
						Console.WriteLine("bot"+battleID+" is dead");
						Console.WriteLine("THE WINNER IS "+"bot"+battleID2+"!!!");
						break;
					}

					if (botHP2 <= 0)
					{
						botHP2 = 0;
						Console.WriteLine("bot"+battleID2+" is dead");
						Console.WriteLine("THE WINNER IS "+"bot"+battleID+"!!!");
						break;
					}
				}
			}

			void changeTurn2()
			{
				while (botHP2 > 0)
				{
					botHP2 = botHP2 - random.Next(1, 10);
					Console.WriteLine("bot"+battleID2+" was damaged by "+"bot"+battleID+" for in sum "+(botHP2 - botHP_const));
					changeTurn();

					if (botHP <= 0)
					{
						botHP = 0;
						Console.WriteLine("bot"+battleID+" is dead");
						Console.WriteLine("THE WINNER IS "+"bot"+battleID2+"!!!");
						break;
					}

					if (botHP2 <= 0)
					{
						botHP2 = 0;
						Console.WriteLine("bot"+battleID2+" is dead");
						Console.WriteLine("THE WINNER IS "+"bot"+battleID+"!!!");
						break;
					}
				}
			}

			while (one != bot_amount+1)
			{
				one++;
			
				if (one == bot_amount+1)
				{
					Console.WriteLine("bot"+battleID+" VS "+"bot"+battleID2);

					while (botHP > 0)
					{
						botHP = botHP - random.Next(1, 10);

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
					}
				}
			}

			Console.ReadLine();
		}
	}
}