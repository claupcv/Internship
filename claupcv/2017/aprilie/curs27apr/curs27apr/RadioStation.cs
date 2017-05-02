using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs27apr
{
	public class RadioStation
	{
		private RadioBrodcast RadioWaves = null;

		public void Emit(string message)
		{

			//var listeners = this.RadioWaves;
			//if(listeners != null)
			//{
			//	listeners(message);
			//} sau cum e mai jos

			this.RadioWaves?.Invoke(message);
		}

		public void OnNewReceiverListening(RadioStationWithEvents receiver)
		{
			if (receiver != null)
			{
				this.RadioWaves += receiver.OnReceived;
			}
		}

	}
}
