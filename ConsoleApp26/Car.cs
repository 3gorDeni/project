using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
	class Car : Transport
	{
		public bool Signaling;
		public Car(string name, string color, float weight, float speed) : base(name, color, weight,speed)
		{
			Name = name;
			Color = color;
			Weight = weight;
			Speed = speed;
		}
		public void SignalingCar(bool Signaling)
		{
			this.Signaling = Signaling;
		}
	}
}
