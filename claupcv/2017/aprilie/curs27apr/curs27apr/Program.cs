using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs27apr
{

	
	class Program
	{

		private static int Weirdame(int a, int b)
		{
			return a + b;
		}

		private static int Weirdame2(int a, int b)
		{
			return a - b;
		}
		private static void DelegatesSimple()
		{
			Sum a = Weirdame;
			IntCalculator calculator = new IntCalculator();
			Sum b = calculator.Sum;

			Sum intSum = delegate (int x, int y)
			{
				return x + y;
			};

			int sum1 = a(1, 2);
			int sum2 = b(3, 4);

			Sum n = null;
			n += Weirdame;
			n += Weirdame2;
			Console.WriteLine(n.GetInvocationList());
			Console.WriteLine("------------------");
		}

		private static void DelegatiMulticast()
		{
			RadioStation station = new RadioStation();

			RadioReceiver radio1 = new RadioReceiver("Panasonic Radio");
			RadioReceiver radio2 = new RadioReceiver("Sony Radio");

			radio1.StartListening(station);

			//station.RadioWaves += radio1.OnReceived;
			//station.RadioWaves += radio2.OnReceived;

			station.Emit("Buna aici Europa Libera ....");

			//prograamtorul Xlescu
			// he is depressed

			RadioReceiver radio3 = new RadioReceiver("Xiang Peng radio");
			radio3.StartListening(station);
			//station.RadioWaves = radio3.OnReceived;

			station.Emit("Buna ziua aici Radio Europa....");
			//station.RadioWaves("Hacked emit");
		}

		private static void RadioStationWithEventsMethod()
		{
			RadioStationWithEvents station = new RadioStationWithEvents();

			RadioReceiver radio1 = new RadioReceiver("Panasonic Radio");
			RadioReceiver radio2 = new RadioReceiver("Sony Radio");

			radio1.StartListeningNewStation(station);
			radio2.StartListeningNewStation(station);

			station.Emit("Buna ziua Europa Libera...");

			radio2.Disconnect(station);

			station.Emit("Buna ziua din nou....");
		}

		private static void ExampleWithEventsWithPattern()
		{
			RadioStationWithPattrn station = new RadioStationWithPattrn();

			RadioReceiverWithPattern radio1 = new RadioReceiverWithPattern("Panasonic Radio");
			RadioReceiverWithPattern radio2 = new RadioReceiverWithPattern("Sony Radio");

			radio1.StartListeningNewStation(station);
			radio2.StartListeningNewStation(station);

			station.Emit("Buna ziua Europa Libera...");

			radio2.Disconnect(station);

			station.Emit("Buna ziua din nou....");
		}
		static void Main(string[] args)
		{
						
			var sum = ArrayHelper.Sum(
				new[] { 1,2,3,4},
				new[] {5,6,7,8 },
				(int a, int b)=> { return a + b; });

			for (int i = 0; i < sum.Length; i++)
			{
				Console.WriteLine(sum[i]);
			}

			var sumString = ArrayHelper.Sum(
				new[] { "cucu", "bau" },
				new[] { "clau", "traian" },
				(s1, s2) => { return s1 + "/" + s2; });


			Console.ReadKey();
		}
	}
}
