using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Class1 {
   public class DuelistDemo
{
	private String name;
	private double accuracy;
	private bool alive;
    Random rand = new Random();
	double random;
		public DuelistDemo(String n, double acc)
	{
		this.name = n;
		this.accuracy = acc;
		alive = true;
	}
	public bool isAlive()
	{
		return alive;
	}
        public void SetAccuracy(double acc)
        {
            accuracy = acc;
		}
	public String getName()
	{
		return name;
	}
	public void ShootAtTarget(DuelistDemo dd)
	{
			random = rand.NextDouble();
            if (random < accuracy)
            {
                dd.alive = false;
            }
        }
}
}

