using System;

namespace main
{
	public class Battle
	{
		static void Main(string[] args)
		{
			Random random = new Random();

			Console.WriteLine("Enter bot amount:");
			int bot_amount = Int32.Parse(Console.ReadLine());
			string bot;
			string bot2;
			int winner;
			Console.WriteLine(bot_amount);
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

			for (int elim=bot_amount; elim>=0; elim--)
            {     
				if (random.Next(1, 100) < 60)
                {
                	winner = 1;
					Console.WriteLine("In round "+round+" won bot");
                }
				if (random.Next(1, 100) >= 60)
				{
					winner = 2;
					Console.WriteLine("In round "+round+" won bot2");
				}
			}

			Console.ReadLine();

		}
	}
}