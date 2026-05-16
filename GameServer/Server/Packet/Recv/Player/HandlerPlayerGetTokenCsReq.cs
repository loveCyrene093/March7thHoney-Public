using System;
using System.IO;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Database;
using March7thHoney.Database.Account;
using March7thHoney.Database.Player;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Server.Packet.Recv.Player;

[Opcode(14)]
public class HandlerPlayerGetTokenCsReq : Handler
{
	private readonly Logger _logger = new Logger("GameServer");

	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		PlayerGetTokenCsReq playerGetTokenCsReq = PlayerGetTokenCsReq.Parser.ParseFrom(data);
		int num;
		if (ConfigManager.Config.ServerOption.ServerConfig.RunDispatch || string.IsNullOrEmpty(ConfigManager.Config.ServerOption.ServerConfig.FromDispatchBaseUrl))
		{
			AccountData accountData = DatabaseHelper.Instance?.GetInstance<AccountData>(int.Parse(playerGetTokenCsReq.AccountUid));
			if (accountData == null)
			{
				await connection.SendPacket(new PacketPlayerGetTokenScRsp(0u, Retcode.RetNotInWhiteList));
				return;
			}
			num = accountData.Uid;
		}
		else
		{
			(int, string) tuple = await HttpNetwork.SendGetRequest(ConfigManager.Config.ServerOption.ServerConfig.FromDispatchBaseUrl + "/get_account_info?accountUid=" + playerGetTokenCsReq.AccountUid);
			if (tuple.Item1 != 200 || tuple.Item2 == null)
			{
				await connection.SendPacket(new PacketPlayerGetTokenScRsp(0u, Retcode.RetNotInWhiteList));
				return;
			}
			num = int.Parse(tuple.Item2);
		}
		if (ResourceManager.IsLoaded)
		{
			Listener.GetActiveConnection(num)?.Stop();
			connection.State = SessionStateEnum.WAITING_FOR_LOGIN;
			PlayerData playerData = DatabaseHelper.Instance?.GetInstance<PlayerData>(num);
			connection.Player = ((playerData == null) ? new PlayerInstance(num) : new PlayerInstance(playerData));
			connection.DebugFile = Path.Combine(ConfigManager.Config.Path.LogPath, "Debug/", $"{num}/", $"Debug-{DateTime.Now:yyyy-MM-dd HH-mm-ss}.log");
			await connection.Player.OnGetToken();
			connection.Player.Connection = connection;
			await connection.SendPacket(new PacketPlayerGetTokenScRsp(connection));
			if (ConfigManager.Config.GameServer.UsePacketEncryption)
			{
				connection.XorKey = Crypto.GenerateXorKey(connection.ClientSecretKeySeed);
				_logger.Info($"{connection.RemoteEndPoint} key exchange successful");
			}
		}
	}
}
