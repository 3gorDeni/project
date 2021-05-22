using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
	class Moto : Transport
	{
		public bool Engine;
		public Moto(string name, string color, float weight, float speed) : base(name, color, weight, speed)
		{
			Name = name;
			Color = color;
			Weight = weight;
			Speed = speed;
		}
		public void Door(bool DoorTrain)
		{
			this.Engine = DoorTrain;
		}
	}
}
