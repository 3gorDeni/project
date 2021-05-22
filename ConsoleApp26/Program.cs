using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
	class Program
	{
		public static void EngineOffOn(Transport a, string b)
		{
			if (a.IsEngine() == true)
			{
				Console.WriteLine(b + " - едит ");
			}
			else
			{
				Console.WriteLine(b + " - стоит");
			}
		}
		static void Main(string[] args)
		{
			Car NewCar = new Car("BMW", "Black", 99, 158);
			NewCar.EngineOn(true);
			NewCar.SignalingCar(false);
			Bus NewBus = new Bus("ПАЗ", "White", 502, 156);
			NewBus.DoorBus(false);
			NewBus.EngineOn(true);
			Plane NewPlane = new Plane("AirBus", "White", 180, 180);
			NewPlane.EngineOff(false);
			NewPlane.Chassis(true);
			Moto NewTrain = new Moto("JR-Maglev", "White", 85, 152);
			NewTrain.EngineOn(true);
			NewTrain.Door(false);

			EngineOffOn(NewCar, "Mашина");
			EngineOffOn(NewBus, "Aвтобус");
			EngineOffOn(NewPlane, "Cамолет");
			EngineOffOn(NewTrain, "Поезд");

			Console.ReadKey();
		}
	}
}
