using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using March7thHoney.Kcp.KcpSharp;
using March7thHoney.Util;

namespace March7thHoney.Kcp;

public class March7thHoneyConnection
{
	public const int HANDSHAKE_SIZE = 20;

	public static readonly ConcurrentBag<int> BannedPackets = new ConcurrentBag<int>();

	private static readonly Logger Logger = new Logger("GameServer");

	public static readonly ConcurrentDictionary<int, string> LogMap = new ConcurrentDictionary<int, string>();

	public static readonly ConcurrentBag<int> IgnoreLog = new ConcurrentBag<int> { 12, 77, 1491, 1410, 1591, 1510 };

	protected readonly CancellationTokenSource CancelToken;

	protected readonly KcpConversation Conversation;

	public readonly IPEndPoint RemoteEndPoint;

	public string DebugFile = "";

	public bool IsOnline = true;

	public StreamWriter? Writer;

	public byte[]? XorKey { get; set; }

	public ulong ClientSecretKeySeed { get; set; }

	public long? ConversationId => Conversation.ConversationId;

	public SessionStateEnum State { get; set; }

	public March7thHoneyConnection(KcpConversation conversation, IPEndPoint remote)
	{
		Conversation = conversation;
		RemoteEndPoint = remote;
		CancelToken = new CancellationTokenSource();
		if (ConfigManager.Config.GameServer.UsePacketEncryption)
		{
			XorKey = Crypto.ClientSecretKey.GetXorKey();
		}
		Start();
	}

	public virtual void Start()
	{
		Logger.Info($"New connection from {RemoteEndPoint}.");
		State = SessionStateEnum.WAITING_FOR_TOKEN;
	}

	public virtual void Stop()
	{
		Conversation.Dispose();
		try
		{
			CancelToken.Cancel();
			CancelToken.Dispose();
		}
		catch
		{
		}
		IsOnline = false;
	}

	public void LogPacket(string sendOrRecv, ushort opcode, byte[] payload)
	{
		if (!ConfigManager.Config.ServerOption.LogOption.EnableGamePacketLog)
		{
			return;
		}
		try
		{
			if (!IgnoreLog.Contains(opcode))
			{
				if (ConfigManager.Config.ServerOption.LogOption.DisableLogDetailPacket)
				{
					throw new Exception();
				}
				string value = PacketLogHelper.ConvertPacketToJson(opcode, payload);
				string text = $"{sendOrRecv}: {LogMap[opcode]}({opcode})\r\n{value}";
				if (ConfigManager.Config.ServerOption.LogOption.LogPacketToConsole)
				{
					Logger.Debug(text);
				}
				if (!(DebugFile == "") && ConfigManager.Config.ServerOption.LogOption.SavePersonalDebugFile)
				{
					StreamWriter writer = GetWriter();
					writer.WriteLine($"[{DateTime.Now:HH:mm:ss}] [GameServer] [DEBUG] " + text);
					writer.Flush();
				}
			}
		}
		catch
		{
			string text2 = $"{sendOrRecv}: {LogMap.GetValueOrDefault(opcode, "UnknownPacket")}({opcode})";
			if (ConfigManager.Config.ServerOption.LogOption.LogPacketToConsole)
			{
				Logger.Debug(text2);
			}
			if (DebugFile != "" && ConfigManager.Config.ServerOption.LogOption.SavePersonalDebugFile)
			{
				StreamWriter writer2 = GetWriter();
				writer2.WriteLine($"[{DateTime.Now:HH:mm:ss}] [GameServer] [DEBUG] " + text2);
				writer2.Flush();
			}
		}
	}

	private StreamWriter GetWriter()
	{
		FileInfo fileInfo = new FileInfo(DebugFile);
		if (!fileInfo.Exists)
		{
			Directory.CreateDirectory(fileInfo.DirectoryName);
			File.Create(DebugFile).Dispose();
		}
		if (Writer == null)
		{
			Writer = new StreamWriter(DebugFile, append: true);
		}
		return Writer;
	}

	public async Task SendPacket(byte[] packet)
	{
		try
		{
			if (ConfigManager.Config.GameServer.UsePacketEncryption)
			{
				Crypto.Xor(packet, XorKey);
			}
			await Conversation.SendAsync(packet, CancelToken.Token);
		}
		catch
		{
		}
	}

	public async Task SendPacket(BasePacket packet)
	{
		if (packet.CmdId <= 0)
		{
			Logger.Debug("Tried to send packet with missing cmd id!");
		}
		else if (!BannedPackets.Contains(packet.CmdId))
		{
			LogPacket("Send", packet.CmdId, packet.Data);
			byte[] packet2 = packet.BuildPacket();
			try
			{
				await SendPacket(packet2);
			}
			catch
			{
			}
			if (packet.CmdId == 1402)
			{
				await SendWatermarkLuaAsync();
			}
		}
	}

	public async Task SendPacket(int cmdId)
	{
		await SendPacket(new BasePacket((ushort)cmdId));
	}

	public virtual Task SendWatermarkLuaAsync()
	{
		return Task.CompletedTask;
	}
}
