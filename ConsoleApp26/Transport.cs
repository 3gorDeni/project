using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
	class Transport
	{
		protected string Name;
		protected string Color;
		protected float Weight;
		protected float Speed;
		public bool Engine;
		//конструктор
		public Transport(string Name, string Color, float Weight, float Speed)
		{
			this.Name = Name;
			this.Color = Color;
			this.Weight = Weight;
			this.Speed = Speed;
		}
		public void EngineOn(bool Engine)
		{
			this.Engine = Engine;
		}
		public void EngineOff(bool Engine)
		{
			this.Engine = Engine;
		}
		public bool IsEngine()
		{
			return Engine;
		}
	}
	
}
