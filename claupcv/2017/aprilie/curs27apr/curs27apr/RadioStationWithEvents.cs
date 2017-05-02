using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs27apr
{
	public class RadioStationWithEvents
	{
		private event RadioBrodcast eventRadioWaves;

		public event RadioBrodcast RadioWaves
		{
			add
			{
				// custom logic
				this.eventRadioWaves += value;
			}

			remove
			{
				this.eventRadioWaves -= value;
			}
		}

		public void Emit(string message)
		{

			//var listeners = this.RadioWaves;
			//if(listeners != null)
			//{
			//	listeners(message);
			//} sau cum e mai jos

			this.eventRadioWaves?.Invoke(message);
		}
	}
}
