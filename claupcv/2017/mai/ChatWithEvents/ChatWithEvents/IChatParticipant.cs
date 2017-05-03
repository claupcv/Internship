using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatWithEvents
{
	public interface IChatParticipant
	{
		string Id { get; }

		event EventHandler<ChatMessage> OnChatEvent;

		void ConnectTo(IChatServer server);

		void Disconnect(IChatServer server);

		void HandleChatMessage(object sender, ChatMessage e);

		void HandleErrorMessage(object sender, ChatMessage e);

		void Chat(ChatMessage message);
	}
}
