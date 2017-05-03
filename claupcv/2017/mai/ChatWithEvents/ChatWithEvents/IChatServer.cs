﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatWithEvents
{
	public interface IChatServer
	{
		void HandleConnectRequest(IChatParticipant client);

		void HandleDisconnectRequest(IChatParticipant client);
	}
}
