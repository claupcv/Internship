using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatWithEvents
{
	public class ChatParticipant : IChatParticipant, IchatMessageEmiter, IChatMessageHandler
	{
		private event EventHandler<ChatMessage> eventChatMsg;

		public ChatParticipant(string id)
		{
			if (string.IsNullOrEmpty(id))
			{
				throw new ArgumentNullException(nameof(id));
			}

			this.Id = id;
		}

		public string Id
		{
			get;
			private set;
		}

		public event EventHandler<ChatMessage> OnChatEvent
		{
			add { this.eventChatMsg += value; }
			remove { this.eventChatMsg -= value; }
		}

		public void ConnectTo(IChatServer server)
		{
			if (server != null)
			{
				server.HandleConnectRequest(this);
			}
		}

		public void Disconnect(IChatServer server)
		{
			if (server != null)
			{
				server.HandleDisconnectRequest(this);
			}
		}

		public void HandleChatMessage(object sender, ChatMessage e)
		{
			string message = string.Empty;
			if (e != null)
			{
				message = e.Text;
			}

			string from = "<unknown>";
			if (sender != null)
			{
				IChatParticipant senderParticipant = sender as IChatParticipant;
				if (senderParticipant != null)
				{
					from = senderParticipant.Id;
				}
			}

			if (!string.IsNullOrWhiteSpace(message))
			{
				Console.WriteLine($"{this.Id} - message from '{from}'> {message}");
			}
		}

		public void HandleErrorMessage(object sender, ChatMessage e)
		{
			if (e != null)
			{
				Console.WriteLine($"{Id} :: err> {e.Text}");
			}
		}

		public void Chat(ChatMessage message)
		{
			if (message != null)
			{
				this.eventChatMsg?.Invoke(this, message);
			}
		}
	}
}
