using System;
using System.Buffers;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using March7thHoney.Configuration;
using March7thHoney.Data.Custom;
using March7thHoney.Enums.Server;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet;
using March7thHoney.Kcp;
using March7thHoney.Kcp.KcpSharp;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Server;

public class Connection : March7thHoneyConnection
{
	private static readonly Logger Logger = new Logger("GameServer");

	public PlayerInstance? Player { get; set; }

	public List<PacketActionData> CustomPacketQueue { get; set; } = new List<PacketActionData>();

	public Connection(KcpConversation conversation, IPEndPoint remote)
		: base(conversation, remote)
	{
	}

	private PacketActionData? GetCurActionData()
	{
		if (CustomPacketQueue.Count == 0)
		{
			return null;
		}
		return CustomPacketQueue[0];
	}

	public override async void Start()
	{
		Logger.Info($"New connection from {RemoteEndPoint}.");
		base.State = SessionStateEnum.WAITING_FOR_TOKEN;
		await ReceiveLoop();
	}

	public override void Stop()
	{
		Player?.TrainCakeCatchManager?.LeaveSocialPlayRoom();
		Player?.OnLogoutAsync();
		March7thHoneyListener.UnregisterConnection(this);
		base.Stop();
	}

	public override async Task SendWatermarkLuaAsync()
	{
		if (Player == null)
		{
			return;
		}
		WatermarkConfig watermark = ConfigManager.Config.ServerOption.Watermark;
		if (watermark.Enabled)
		{
			string nickname = Player.Data.Name ?? "";
			string uid = Player.Uid.ToString();
			string version = (string.IsNullOrEmpty(ClientVersionCache.LatestVersion) ? "WIN4.2.0" : ClientVersionCache.LatestVersion);
			string text = BuildWatermarkLine(watermark.Line1Template, nickname, uid, version, watermark);
			string text2 = BuildWatermarkLine(watermark.Line2Template, nickname, uid, version, watermark);
			List<string> list = new List<string>();
			if (!string.IsNullOrWhiteSpace(text))
			{
				list.Add(text);
			}
			if (!string.IsNullOrWhiteSpace(text2))
			{
				list.Add(text2);
			}
			if (list.Count != 0)
			{
				string text3 = EscapeLuaString(string.Join("\n", list));
				string text4 = watermark.FontSize.ToString(CultureInfo.InvariantCulture);
				string s = "local function modify_texts()\n    local vGo = CS.UnityEngine.GameObject.Find(\"VersionText\")\n    if vGo == nil then return end\n    local vt = vGo:GetComponent(\"Text\")\n    vt.supportRichText = true\n    vt.text = \"" + text3 + "\"\n    vt.fontSize = " + text4 + "\nend\n\nlocal function on_error(err)\n    local files = io.open(\"./error.txt\", \"w\")\n    files:write(err)\n    files:close()\nend\n\nlocal status, err = pcall(modify_texts)\nif not status then on_error(err) end\n";
				HandshakePacket handshakePacket = new HandshakePacket(Encoding.UTF8.GetBytes(s));
				await SendPacket(handshakePacket.BuildPacket());
			}
		}
	}

	private static string BuildWatermarkLine(string template, string nickname, string uid, string version, WatermarkConfig watermark)
	{
		string text = template.Replace("{nickname}", nickname, StringComparison.Ordinal).Replace("{uid}", uid, StringComparison.Ordinal).Replace("{version}", version, StringComparison.Ordinal)
			.Replace("{serverName}", ConfigManager.Config.GameServer.GameServerName, StringComparison.Ordinal)
			.Replace("{serverId}", ConfigManager.Config.GameServer.GameServerId, StringComparison.Ordinal);
		if (!watermark.UseGradient)
		{
			return text;
		}
		return ApplyGradient(text, watermark.GradientStartColor, watermark.GradientEndColor);
	}

	private static string ApplyGradient(string line, string startColor, string endColor)
	{
		if (!TryParseHexColor(startColor, out var r, out var g, out var b) || !TryParseHexColor(endColor, out var r2, out var g2, out var b2))
		{
			return line;
		}
		int num = 0;
		string text = line;
		for (int i = 0; i < text.Length; i++)
		{
			if (text[i] != ' ')
			{
				num++;
			}
		}
		StringBuilder stringBuilder = new StringBuilder(line.Length * 24);
		int num2 = 0;
		text = line;
		foreach (char c in text)
		{
			if (c == ' ')
			{
				stringBuilder.Append(' ');
				continue;
			}
			double num3 = ((num <= 1) ? 0.0 : ((double)num2 / (double)(num - 1)));
			int value = (int)((double)r + (double)(r2 - r) * num3);
			int value2 = (int)((double)g + (double)(g2 - g) * num3);
			int value3 = (int)((double)b + (double)(b2 - b) * num3);
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(9, 3, stringBuilder2);
			handler.AppendLiteral("<color=#");
			handler.AppendFormatted(value, "X2");
			handler.AppendFormatted(value2, "X2");
			handler.AppendFormatted(value3, "X2");
			handler.AppendLiteral(">");
			stringBuilder2.Append(ref handler).Append(c).Append("</color>");
			num2++;
		}
		return stringBuilder.ToString();
	}

	private static bool TryParseHexColor(string value, out int r, out int g, out int b)
	{
		r = (g = (b = 0));
		string text = value.Trim();
		if (text.StartsWith("#", StringComparison.Ordinal))
		{
			string text2 = text;
			text = text2.Substring(1, text2.Length - 1);
		}
		if (text.Length != 6)
		{
			return false;
		}
		if (!int.TryParse(text.Substring(0, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out r))
		{
			return false;
		}
		if (!int.TryParse(text.Substring(2, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out g))
		{
			return false;
		}
		return int.TryParse(text.Substring(4, 2), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out b);
	}

	private static string EscapeLuaString(string s)
	{
		return s.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\n", "\\n")
			.Replace("\r", "");
	}

	protected async Task ReceiveLoop()
	{
		while (!CancelToken.IsCancellationRequested)
		{
			KcpConversationReceiveResult result = await Conversation.WaitToReceiveAsync(CancelToken.Token);
			if (result.TransportClosed)
			{
				Logger.Debug("Connection was closed");
				break;
			}
			byte[] buffer = ArrayPool<byte>.Shared.Rent(result.BytesReceived);
			try
			{
				if (!Conversation.TryReceive(buffer, out result))
				{
					Logger.Error("Failed to receive packet");
					break;
				}
				await ProcessMessageAsync(buffer.AsMemory(0, result.BytesReceived));
			}
			catch (Exception e)
			{
				Logger.Error("Packet parse error", e);
			}
			finally
			{
				ArrayPool<byte>.Shared.Return(buffer);
			}
		}
		Stop();
	}

	private async Task ProcessMessageAsync(Memory<byte> data)
	{
		byte[] array = data.ToArray();
		if (ConfigManager.Config.GameServer.UsePacketEncryption)
		{
			Crypto.Xor(array, base.XorKey);
		}
		await using MemoryStream ms = new MemoryStream(array);
		using BinaryReader br = new BinaryReader(ms);
		try
		{
			while (br.BaseStream.Position < br.BaseStream.Length && br.BaseStream.Length - br.BaseStream.Position >= 12)
			{
				uint num = br.ReadUInt32BE();
				if (num != 2641676052u)
				{
					Logger.Error($"Bad Data Package Received: got 0x{num:X}, expect 0x9D74C714");
					break;
				}
				ushort opcode = br.ReadUInt16BE();
				ushort count = br.ReadUInt16BE();
				uint count2 = br.ReadUInt32BE();
				byte[] header = br.ReadBytes(count);
				byte[] payload = br.ReadBytes((int)count2);
				LogPacket("Recv", opcode, payload);
				await HandlePacket(opcode, header, payload);
			}
		}
		catch (Exception ex)
		{
			Logger.Error(ex.Message, ex);
		}
	}

	private async Task HandlePacket(ushort opcode, byte[] header, byte[] payload)
	{
		PacketActionData action = GetCurActionData();
		string packetName = March7thHoneyConnection.LogMap.GetValueOrDefault(opcode);
		if (action != null && action.Action == PacketActionTypeEnum.WaitForPacket && action.Param.PacketName == packetName)
		{
			bool interrupt = action.Param.InterruptFormalHandler;
			do
			{
				PacketActionTypeEnum action2 = action.Action;
				if (action2 != PacketActionTypeEnum.WaitForPacket && action2 == PacketActionTypeEnum.SendPacket)
				{
					BasePacket basePacket = new BasePacket((ushort)March7thHoneyConnection.LogMap.FirstOrDefault<KeyValuePair<int, string>>((KeyValuePair<int, string> x) => x.Value == action.Param.PacketName).Key);
					basePacket.SetData(action.Param.PacketData);
					await SendPacket(basePacket);
				}
				CustomPacketQueue.RemoveAt(0);
				action = GetCurActionData();
			}
			while (action != null && action.Action != PacketActionTypeEnum.WaitForPacket);
			if (interrupt)
			{
				return;
			}
		}
		Handler handler = HandlerManager.GetHandler(opcode);
		if (handler != null)
		{
			SessionStateEnum state = base.State;
			switch (opcode)
			{
			case 14:
				if (state != SessionStateEnum.WAITING_FOR_TOKEN)
				{
					return;
				}
				break;
			case 91:
				if (state != SessionStateEnum.WAITING_FOR_LOGIN)
				{
					return;
				}
				break;
			}
			try
			{
				await handler.OnHandle(this, header, payload);
			}
			catch (Exception e)
			{
				Logger.Error("An error occured ", e);
				string curPacket = March7thHoneyConnection.LogMap.GetValueOrDefault(opcode);
				if (curPacket == null)
				{
					return;
				}
				string rspName = curPacket.Replace("Cs", "Sc").Replace("Req", "Rsp");
				if (rspName == curPacket)
				{
					return;
				}
				int key = March7thHoneyConnection.LogMap.FirstOrDefault<KeyValuePair<int, string>>((KeyValuePair<int, string> x) => x.Value == rspName).Key;
				Type type = AppDomain.CurrentDomain.GetAssemblies().SingleOrDefault((Assembly assembly) => assembly.GetName().Name == "March7thHoney.Proto").GetTypes()
					.First((Type t) => t.Name == rspName);
				Type type2 = AppDomain.CurrentDomain.GetAssemblies().SingleOrDefault((Assembly assembly) => assembly.GetName().Name == "March7thHoney.Proto").GetTypes()
					.First((Type t) => t.Name == curPacket);
				if (!(Activator.CreateInstance(type) is IMessage message))
				{
					return;
				}
				type.GetProperty("Retcode")?.SetValue(message, 1u);
				IMessage obj = (type2.GetProperty("Descriptor", BindingFlags.Static | BindingFlags.Public)?.GetValue(null, null) as MessageDescriptor)?.Parser.ParseFrom(payload);
				PropertyInfo[] properties = type2.GetProperties();
				foreach (PropertyInfo propertyInfo in properties)
				{
					PropertyInfo property = type.GetProperty(propertyInfo.Name);
					if (property != null && property.CanWrite)
					{
						object value = propertyInfo.GetValue(obj);
						if (value != null)
						{
							property.SetValue(message, value);
						}
					}
				}
				BasePacket basePacket2 = new BasePacket((ushort)key);
				basePacket2.SetData(message);
				await SendPacket(basePacket2);
			}
		}
		else
		{
			if (packetName == null)
			{
				return;
			}
			string respName = packetName.Replace("Cs", "Sc").Replace("Req", "Rsp");
			if (!(respName == packetName))
			{
				int key2 = March7thHoneyConnection.LogMap.FirstOrDefault<KeyValuePair<int, string>>((KeyValuePair<int, string> x) => x.Value == respName).Key;
				await SendPacket(key2);
			}
		}
	}
}
