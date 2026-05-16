using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using March7thHoney.Internationalization;
using March7thHoney.Kcp.KcpSharp;
using March7thHoney.Util;

namespace March7thHoney.Kcp;

public class March7thHoneyListener
{
	public delegate March7thHoneyConnection ConnectionCreatedHandler(KcpConversation conversation, IPEndPoint remote);

	private static UdpClient? UDPClient;

	private static IPEndPoint? ListenAddress;

	private static IKcpTransport<IKcpMultiplexConnection>? KCPTransport;

	private static readonly Logger Logger = new Logger("GameServer");

	public static readonly SortedList<long, March7thHoneyConnection> Connections = new SortedList<long, March7thHoneyConnection>();

	private static readonly KcpConversationOptions ConvOpt = new KcpConversationOptions
	{
		StreamMode = false,
		Mtu = 1400,
		ReceiveWindow = 256,
		SendWindow = 256,
		NoDelay = true,
		UpdateInterval = 100,
		KeepAliveOptions = new KcpKeepAliveOptions(1000, 30000)
	};

	public static ConnectionCreatedHandler? CreateConnection { get; set; } = null;

	private static Socket? UDPListener => UDPClient?.Client;

	private static IKcpMultiplexConnection? Multiplex => KCPTransport?.Connection;

	private static uint PORT => ConfigManager.Config.GameServer.Port;

	public static March7thHoneyConnection? GetConnectionByEndPoint(IPEndPoint ep)
	{
		return Connections.Values.FirstOrDefault((March7thHoneyConnection c) => c.RemoteEndPoint.Equals(ep));
	}

	public static void StartListener()
	{
		ListenAddress = new IPEndPoint(IPAddress.Parse(ConfigManager.Config.GameServer.BindAddress), (int)PORT);
		UDPClient = new UdpClient(ListenAddress);
		if (UDPListener != null)
		{
			KCPTransport = KcpSocketTransport.CreateMultiplexConnection(UDPClient, 1400);
			KCPTransport.Start();
			Logger.Info(I18NManager.Translate("Server.ServerInfo.ServerRunning", I18NManager.Translate("Word.Game"), ConfigManager.Config.GameServer.GetDisplayAddress()));
		}
	}

	private static void RegisterConnection(March7thHoneyConnection con)
	{
		if (con.ConversationId.HasValue)
		{
			Connections[con.ConversationId.Value] = con;
		}
	}

	public static void UnregisterConnection(March7thHoneyConnection con)
	{
		if (con.ConversationId.HasValue)
		{
			long value = con.ConversationId.Value;
			if (Connections.Remove(value))
			{
				Multiplex?.UnregisterConversation(value);
				Logger.Info($"Connection with {con.RemoteEndPoint} has been closed");
			}
		}
	}

	public static async Task HandleHandshake(UdpReceiveResult rcv)
	{
		_ = 3;
		try
		{
			March7thHoneyConnection connectionByEndPoint = GetConnectionByEndPoint(rcv.RemoteEndPoint);
			await using MemoryStream ms = new MemoryStream(rcv.Buffer);
			using BinaryReader br = new BinaryReader(ms);
			int num = br.ReadInt32BE();
			br.ReadUInt32();
			br.ReadUInt32();
			int enet = br.ReadInt32BE();
			br.ReadUInt32();
			switch (num)
			{
			case 255:
				if (connectionByEndPoint != null)
				{
					Logger.Info($"Duplicate handshake from {connectionByEndPoint.RemoteEndPoint}");
					return;
				}
				await AcceptConnection(rcv, enet);
				break;
			case 404:
				if (connectionByEndPoint == null)
				{
					Logger.Info($"Inexistent connection asked for disconnect from {rcv.RemoteEndPoint}");
					return;
				}
				await SendDisconnectPacket(connectionByEndPoint, 5);
				break;
			case -934149376:
				if (connectionByEndPoint != null)
				{
					Logger.Info($"Duplicate handshake from {connectionByEndPoint.RemoteEndPoint}");
					return;
				}
				await AcceptConnection(rcv, enet);
				break;
			default:
				Logger.Error($"Invalid handshake code received {num}");
				return;
			}
		}
		catch (Exception value)
		{
			Logger.Error($"Failed to handle handshake: {value}");
		}
	}

	private static async Task AcceptConnection(UdpReceiveResult rcv, int enet)
	{
		long nextAvailableIndex = Connections.GetNextAvailableIndex();
		KcpConversation kcpConversation = Multiplex?.CreateConversation(nextAvailableIndex, rcv.RemoteEndPoint, ConvOpt);
		if (kcpConversation != null && CreateConnection != null)
		{
			March7thHoneyConnection march7thHoneyConnection = CreateConnection(kcpConversation, rcv.RemoteEndPoint);
			RegisterConnection(march7thHoneyConnection);
			await SendHandshakeResponse(march7thHoneyConnection, enet);
		}
	}

	private static async Task SendHandshakeResponse(March7thHoneyConnection user, int enet)
	{
		if (user == null || UDPClient == null || !user.ConversationId.HasValue)
		{
			return;
		}
		long value = user.ConversationId.Value;
		await using MemoryStream ms = new MemoryStream();
		await using BinaryWriter bw = new BinaryWriter(ms);
		bw.WriteInt32BE(325);
		bw.WriteConvID(value);
		bw.WriteInt32BE(enet);
		bw.WriteInt32BE(340870469);
		byte[] array = ms.ToArray();
		await UDPClient.SendAsync(array, array.Length, user.RemoteEndPoint);
	}

	public static async Task SendDisconnectPacket(March7thHoneyConnection user, int code)
	{
		if (user == null || UDPClient == null || !user.ConversationId.HasValue)
		{
			return;
		}
		long value = user.ConversationId.Value;
		await using MemoryStream ms = new MemoryStream();
		await using BinaryWriter bw = new BinaryWriter(ms);
		bw.WriteInt32BE(404);
		bw.WriteConvID(value);
		bw.WriteInt32BE(code);
		bw.WriteInt32BE(423728276);
		byte[] array = ms.ToArray();
		await UDPClient.SendAsync(array, array.Length, user.RemoteEndPoint);
	}
}
