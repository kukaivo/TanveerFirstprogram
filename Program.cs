using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Car> carList = new List<Car>();

			Car obj = new Car();
			obj.AddCar("Rolls", "Silver Cloud", 12500);
			Car obj2 = new Car();
			obj2.AddCar("VW", "Passat CC", 7000);
			Car obj3 = new Car();
			obj3.AddCar("Ford", "Fiesta", 2500);
			Car obj4 = new Car();
			obj4.AddCar("Nissan", "Micra", 700);

			carList.Add(obj);
			carList.Add(obj2);
			carList.Add(obj3);
			carList.Add(obj4);

			Car.displayCars(carList);

			
			Console.ReadKey();
		}
	}
	class Car
	{
		public string make;
		public string model;
		public float price;

		public void AddCar(string mk, string md, float prc)
		{
			this.make = mk;
			this.model = md;
			this.price = prc;
		}

		public static void displayCars(List<Car> carList)
		{
			for (int i = 0; i < carList.Count; i++)
			{
				Console.WriteLine(carList[i].make + " " + carList[i].model + " £" + carList[i].price);
			}
		}
	}
}
