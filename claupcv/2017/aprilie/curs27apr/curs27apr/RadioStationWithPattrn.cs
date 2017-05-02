using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs27apr
{
	class RadioStationWithPattrn
	{
		private event EventHandler<string> eventRadioWaves;

		public event EventHandler<string> RadioWaves
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
			this.eventRadioWaves?.BeginInvoke();
		}
	}
}
