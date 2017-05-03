using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatWithEvents
{
	public enum ChatMessageType
	{
		Broadcast = 0,

		PeerToPeer
	}

	public class ChatMessage
	{
		private ChatMessage(string text, ChatMessageType type, string destinatarId)
		{
			this.Text = text;
			this.Type = type;
			this.DestinatarId = destinatarId;
		}

		public string Text { get; private set; }

		public ChatMessageType Type { get; private set; }

		public string DestinatarId { get; private set; }

		public static ChatMessage Broadcast(string message)
		{
			return new ChatMessage(message, ChatMessageType.Broadcast, null);
		}

		public static ChatMessage PeerToPeer(string message, string destinatarId)
		{
			if (string.IsNullOrEmpty(destinatarId))
			{
				throw new ArgumentException(nameof(destinatarId));
			}
			return new ChatMessage(message, ChatMessageType.PeerToPeer, destinatarId);
		}
	}
}
