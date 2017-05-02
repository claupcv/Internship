using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs27apr
{
	public class RadioReceiver
	{
		public RadioReceiver(string name)
		{
			this.Name = name;
		}

		public string Name { get; private set; }

		public void OnReceived(string radiomessage)
		{
			Console.WriteLine($"{this.Name}>{radiomessage}");
		}

		public void StartListening(RadioStation station)
		{
			if(station != null)
			{
				station.OnNewReceiverListening(this);
			}
		}

		public void StartListeningNewStation(RadioStationWithEvents station)
		{
			if (station!=null)
			{
				station.OnNewReceiverListening(this);
			}
		}

		public void Disconnect(RadioStationWithEvents station)
		{
			if (station != null)
			{
				station.RadioWaves -= OnReceived; 
			}
			
		}
	}
}
