using System.Threading.Tasks;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Chat;

[Opcode(3991)]
public class HandlerSendMsgCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		SendMsgCsReq sendMsgCsReq = SendMsgCsReq.Parser.ParseFrom(data);
		ChatData chatData = sendMsgCsReq.MessageDatas?.ChatData;
		string text = null;
		if (chatData != null && chatData.HasMessageText)
		{
			text = chatData.MessageText;
		}
		text = text?.Trim('\0').Trim();
		uint extraId = 0u;
		if (chatData != null && chatData.HasExtraId)
		{
			extraId = chatData.ExtraId;
		}
		MsgType msgType = MsgType.None;
		if (sendMsgCsReq.MessageDatas != null && sendMsgCsReq.MessageDatas.MessageType != MsgType.None)
		{
			msgType = sendMsgCsReq.MessageDatas.MessageType;
		}
		else if (!string.IsNullOrWhiteSpace(text))
		{
			msgType = MsgType.CustomText;
		}
		else if (extraId != 0)
		{
			msgType = MsgType.Emoji;
		}
		if (sendMsgCsReq.TargetList.Count == 0)
		{
			await connection.SendPacket(3910);
			return;
		}
		foreach (uint target in sendMsgCsReq.TargetList)
		{
			switch (msgType)
			{
			case MsgType.CustomText:
				await connection.Player.FriendManager.SendMessage(connection.Player.Uid, (int)target, text);
				break;
			case MsgType.Emoji:
				await connection.Player.FriendManager.SendMessage(connection.Player.Uid, (int)target, null, (int)extraId);
				break;
			}
		}
		await connection.SendPacket(3910);
	}
}
