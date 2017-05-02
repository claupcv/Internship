using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs27apr
{
	class RadioReceiverWithPattern
	{
		public RadioReceiverWithPattern(string name)
		{
			this.Name = name;
		}

		public string Name { get; private set; }

		protected void OnReceived(object station, string radiomessage)
		{
			Console.WriteLine($"{this.Name}>{radiomessage}");
		}



		public void Disconnect(RadioReceiverWithPattern station)
		{
			if (station != null)
			{
				station.RadioWaves -= OnReceived;
			}

		}
	}
}
