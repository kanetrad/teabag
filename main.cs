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

			//foreach (int el in bots)
			//{
			//	int battleID = random.Next(1, 5);

			//	string resultofid = "bot" + battleID.ToString();
			//}

			int bot_amount = 0;
			int botHP = 100;
			int power = random.Next(1, 10);
			int dPower = random.Next(1,100);
			int randomSword = random.Next(2,5);
			int randomJustice = random.Next(1,2);

			if (dPower>60)
			{
				int attack = random.Next(50,100);
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