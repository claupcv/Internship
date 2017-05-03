using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatWithEvents
{
	public class ChatServer : IChatServer
	{
		private enum ConnectionRegisterStatus
		{
			RegisterFaild=0,

			Alreadyregistered,

			RegisteredSuccesfuly
		}
		private readonly Dictionary<string, IChatParticipant> participants;

		public ChatServer()
		{
			this.participants = new Dictionary<string, IChatParticipant>();
		}

		public void HandleConnectRequest(IChatParticipant client)
		{
			
			if (client == null)
			{
				// we don't accept null clients
				return;
			}

			if (this.participants.ContainsKey(client.Id))
			{
				// client already connected
				return;
			}

			this.participants.Add(client.Id, client);

			client.OnChatEvent += this.Client_OnChatEvent;

			Console.WriteLine($"User '{client.Id}' a intrat");
		}

		public void HandleDisconnectRequest(IChatParticipant client)
		{
			if (client == null)
			{
				// we don't accept null clients
				return;
			}

			if (!this.participants.ContainsKey(client.Id))
			{
				// client wasn't connected
				return;
			}

			client.OnChatEvent -= this.Client_OnChatEvent;

			Console.WriteLine($"User '{client.Id}' a iesit");

			this.participants.Remove(client.Id);
		}

		private void OnConect_Rgister()
		{

		}

		private void OnConnect_AtachToEventSource(IChatParticipant client)
		{
			IchatMessageEmiter emiter = client as IchatMessageEmiter;

			if (emiter == null)
			{
				throw new ArgumentException($"Class ");
			}
		}
		private void Client_OnChatEvent(object sender, ChatMessage e)
		{
			if (e == null)
			{
				return;
			}

			switch (e.Type)
			{
				case ChatMessageType.PeerToPeer:
					ForwardPeerToPeerMessage(sender, e);
					break;

				case ChatMessageType.Broadcast:
				default:
					ForwardBroadcastMessage(sender, e);
					break;
			}
		}

		private void ForwardPeerToPeerMessage(object sender, ChatMessage msg)
		{
			IChatParticipant client;
			if (this.participants.TryGetValue(msg.DestinatarId, out client))
			{
				client.HandleChatMessage(sender, msg);
			}
			else
			{
				client = sender as IChatParticipant;
				if (client != null)
				{
					client.HandleErrorMessage(
					  this,
					  ChatMessage.PeerToPeer(
						$"Destinatar '{msg.DestinatarId}' doesn't exist",
						msg.DestinatarId));
				}
			}
		}

		private void ForwardBroadcastMessage(object sender, ChatMessage msg)
		{
			foreach (var client in this.participants.Values)
			{
				client.HandleChatMessage(sender, msg);
			}
		}
	}
}
