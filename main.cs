using System;

namespace main
{
	public class Battle
	{
		static void Main(string[] args)
		{
			Random random = new Random();

			Console.WriteLine("Enter round amount:");
			int bot_amount = Int32.Parse(Console.ReadLine());
			string bot, bot2;
			int winner;
			int winner_score = 0;
			int winner_score2 = 0;
			int round = 0;
			//Console.WriteLine(bot_amount);
			for (int num=1; num<=bot_amount; num++)
            		{
				Console.WriteLine(num);
				bot = "bot" + random.Next(1, bot_amount);
				bot2 = "bot" + random.Next(1, bot_amount);
				while (bot == bot2)
                		{
					bot2 = "bot" + random.Next(1, bot_amount);
				}
				Console.WriteLine(bot);
				Console.WriteLine(bot2);
			}

			Console.WriteLine("Loop complete");
			Console.WriteLine(" ");

			for (int elim=bot_amount; elim>0; elim--)
            		{
            			for (int num=1; elim>0; num++)
            			{
            				while (round<bot_amount)
					{
						round++;

						if (random.Next(1, 100) < 50)
                				{
                					winner = 1;
                					winner_score++;
							Console.WriteLine("In round "+round+" won FIRST bot");
                				}
						if (random.Next(1, 100) >= 50)
						{
							winner = 2;
							winner_score2++;
							Console.WriteLine("In round "+round+" won SECOND bot");
						}
					}
				}
			}

			Console.WriteLine(" ");
			Console.WriteLine("pretend that airplanes in the night sky..");
			Console.WriteLine("oh (*___*)");
			Console.WriteLine("i meant-");
			Console.WriteLine("pretend that rounds' numbers are ordinal as usual");
			Console.WriteLine("bc idk how to make them like that >.<");

			Console.ReadLine();

		}
	}
}
