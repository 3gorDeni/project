using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
	class Plane : Transport
	{
		public bool ChassisPlane;
		public Plane(string name, string color, float Weight, float Speed) : base(name, color, Weight, Speed)
		{
			Name = name;
			Color = color;
			Weight = Weight;
			Speed = Speed;
		}
		public void Chassis(bool ChassisPlane)
		{
			this.ChassisPlane = ChassisPlane;
		}

	}
}
