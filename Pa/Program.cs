/// Homework 8
/// File Name: Shootout duel
/// @author: Dakota Durst
/// Date: November 1st, 2020
///
/// Problem Statement: 
/// Have 3 individuals duel out in a shootout to see who wins, the one with the lowest accuracy goes first
///
///
/// Overall Plan:
/// 1) define the 3 indivduals aaron, bob and charlie and set their accuracies to the correct numbers
/// 2) Have aaron strike first and target the one with the highest accuracy (charlie)
/// 3) run if statement to see if target dies or not
/// 4) repeat steps 2 and 3 until 1 person is left
/// 5) add 1 to number of wins and repeat
/// 6) repeat steps 1-5 for a new loop where aaron purposefully misses his first shop (making bob shoot at charlie)

using Class1;
using System;

namespace Part1
{
	public class DuelistTest
	{

		public static void Main(String[] args)
		{
			int aWin = 0;
			int bWin = 0;
			int cWin = 0;
			int a2win = 0, b2win = 0, c2win = 0;
			for (int i = 1; i <= 10000; i++)
			{
				DuelistDemo aaron = new DuelistDemo("Aaron", 0.33);
				DuelistDemo bob = new DuelistDemo("Bob", 0.5);
				DuelistDemo charlie = new DuelistDemo("Charlie", .995);
				int aliveCount = 3;
				while (aliveCount > 1)
				{

					if (aaron.isAlive())
					{
						//Console.WriteLine("aaron is alive");
						if (charlie.isAlive())
						{
							aaron.ShootAtTarget(charlie);
							if (!charlie.isAlive())
							{
								aliveCount--;
							}
						}
						else
						{
							aaron.ShootAtTarget(bob);
							if (!bob.isAlive())
							{
								aliveCount --;
							}
						}
					}
					if (bob.isAlive())
					{
						//Console.WriteLine("bob is alive");
						if (charlie.isAlive())
						{
							bob.ShootAtTarget(charlie);

							if (!charlie.isAlive())
							{
								aliveCount --;
							}
						}
						else
						{
							bob.ShootAtTarget(aaron);

							if (!aaron.isAlive())
							{
								aliveCount --;
							}
						}
					}
					if (charlie.isAlive())
					{
						//Console.WriteLine("charlie is alive");
						if (bob.isAlive())
						{
							charlie.ShootAtTarget(bob);
							if (!bob.isAlive())
							{
								aliveCount--;
							}
						}
						else
						{
							charlie.ShootAtTarget(aaron);

							if (!aaron.isAlive())
							{
								aliveCount--;
							}
						}
					}
				}
				if (aaron.isAlive())
				{
					aWin++;
				}
				else if (bob.isAlive())
				{
					bWin++;
				}
				else
				{
					cWin++;
				}
			}
			Console.WriteLine("If aaron can hit his first shot: ");
			Console.WriteLine("Aaron has won " + aWin + " times of 10000 duels.");
			Console.WriteLine("Bob has won " + bWin + " times of 10000 duels.");
			Console.WriteLine("Charlie has won " + cWin + " times of 10000 duels");

			for (int i = 1; i <= 10000; i++)
			{
				DuelistDemo aaron = new DuelistDemo("AaronMiss", 0.33);
				DuelistDemo bob = new DuelistDemo("Bob", 0.5);
				DuelistDemo charlie = new DuelistDemo("Charlie", .995);
				int aliveCount = 3;
				int aaronfirstshot = 1;
				while (aliveCount > 1)
				{

					if (aaron.isAlive())
					{
						//Console.WriteLine("aaron is alive");
						if (charlie.isAlive())
						{
							if (aaronfirstshot == 1)
							{
								aaron.SetAccuracy(0.00);
								aaronfirstshot = 0;
							}
							else
                            {
								aaron.SetAccuracy(.33);
                            }
							aaron.ShootAtTarget(charlie);

							if (!charlie.isAlive())
							{
								aliveCount--;
							}
						}
						else
						{
							aaron.ShootAtTarget(bob);
							if (!bob.isAlive())
							{
								aliveCount--;
							}
						}
					}
					if (bob.isAlive())
					{
						//Console.WriteLine("bob is alive");
						if (charlie.isAlive())
						{
							bob.ShootAtTarget(charlie);

							if (!charlie.isAlive())
							{
								aliveCount--;
							}
						}
						else
						{
							bob.ShootAtTarget(aaron);

							if (!aaron.isAlive())
							{
								aliveCount--;
							}
						}
					}
					if (charlie.isAlive())
					{
						//Console.WriteLine("charlie is alive");
						if (bob.isAlive())
						{
							charlie.ShootAtTarget(bob);
							if (!bob.isAlive())
							{
								aliveCount--;
							}
						}
						else
						{
							charlie.ShootAtTarget(aaron);

							if (!aaron.isAlive())
							{
								aliveCount--;
							}
						}
					}
				}
				if (aaron.isAlive())
				{
					a2win++;
					aaronfirstshot = 1;
				}
				else if (bob.isAlive())
				{
					b2win++;
					aaronfirstshot = 1;
				}
				else
				{
					c2win++;
					aaronfirstshot = 1;
				}
			}
			Console.WriteLine();
			Console.WriteLine("If aaron misses his first shot: ");
			Console.WriteLine("Aaron has won " + a2win + " times of 10000 duels.");
			Console.WriteLine("Bob has won " + b2win + " times of 10000 duels.");
			Console.WriteLine("Charlie has won " + c2win + " times of 10000 duels");
		}
	}
}
