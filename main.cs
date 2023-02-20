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
			int one = 0;
			int bot1 = 100;
			int bot2 = 100;
			Console.WriteLine("Enter MAX HP:");
			int botHP_const = Int32.Parse(Console.ReadLine());
			int battleID = random.Next(1, bot_amount);
			public int randomdmg;
			int battleID2 = random.Next(battleID, bot_amount);
			while (battleID2 == battleID)
			{
				battleID2 = random.Next(battleID, bot_amount);
			}

			while (one != bot_amount)
			{
				one++;
			
				if (one == bot_amount)
				{
					Console.WriteLine("bot"+battleID+" VS "+"bot"+battleID2);

					while (bot1 > 0)
					{
						bot1 = bot1 - randomdmg;
						bot2 = bot2 - randomdmg;

						while (bot1 < botHP_const)
						{
							changeTurn2();
							break;
						}
						while (bot2 < botHP_const)
						{
							changeTurn();
							break;
						}
					}
				}
			}

			void changeTurn()
			{
				while (bot1 > 0)
				{
					randomdmg = random.Next(1, 10);
					bot1 = bot1 - randomdmg;
					Console.WriteLine("bot"+bot1+" was damaged for "+randomdmg);
					changeTurn2();
					break;
				}		
			}

			void changeTurn2()
			{
				while (bot2 > 0)
				{
					randomdmg = random.Next(1, 10);
					bot2 = bot2 - randomdmg;
					Console.WriteLine("bot"+bot2+" was damaged for "+randomdmg);
					changeTurn();
					break;
				}
			}

			if (bot1 <= 0)
			{
				Console.WriteLine("bot"+battleID+" is dead");
				Console.WriteLine("THE WINNER IS bot"+battleID2+"!!!");
			}

			if (bot2 <= 0)
			{
				Console.WriteLine("bot"+battleID2+" is dead");
				Console.WriteLine("THE WINNER IS bot"+battleID+"!!!");
			}

			Console.ReadLine();

		}
	}
}