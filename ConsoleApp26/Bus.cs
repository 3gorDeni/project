using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
	class Bus : Transport
	{
		public bool DoorOpen;
		public Bus(string name, string color, float weight, float speed) : base(name, color, weight, speed)
		{
			Name = name;
			Color = color;
			Weight = weight;
			Speed = speed;
		}
		public void DoorBus(bool DoorOpen)
		{
			this.DoorOpen = DoorOpen;
		}
	}
}
