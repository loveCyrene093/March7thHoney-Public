using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using March7thHoney.Database;
using March7thHoney.Database.Avatar;
using March7thHoney.Database.Inventory;
using March7thHoney.GameServer.Game.Calyx;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.PlayerSync;
using March7thHoney.Internationalization;
using March7thHoney.Util;

namespace March7thHoney.Command.Command.Cmd;

[CommandInfo("json", "Game.Command.Json.Desc", "Game.Command.Json.Usage", "", "")]
public class CommandJson : ICommand
{
	private static readonly string[] JsonDirectoryRelativePaths = new string[1] { "Config/Json" };

	private static List<DirectoryInfo> GetJsonDirectories(bool createIfMissing = false)
	{
		List<DirectoryInfo> list = new List<DirectoryInfo>(JsonDirectoryRelativePaths.Length);
		string[] jsonDirectoryRelativePaths = JsonDirectoryRelativePaths;
		foreach (string text in jsonDirectoryRelativePaths)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetFullPath(text));
			if (createIfMissing && !directoryInfo.Exists && text.Equals("Config/Json", StringComparison.OrdinalIgnoreCase))
			{
				directoryInfo.Create();
			}
			list.Add(directoryInfo);
		}
		return list;
	}

	[CommandDefault]
	public async ValueTask Import(CommandArg arg)
	{
		PlayerInstance player = arg.Target?.Player;
		if (player == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		string text = ((arg.Args.Count > 0 && !string.IsNullOrEmpty(arg.Args[0])) ? arg.Args[0] : null);
		if (string.IsNullOrWhiteSpace(text))
		{
			await ShowFileList(arg);
			return;
		}
		if (text.Equals("clear", StringComparison.OrdinalIgnoreCase))
		{
			List<FormalAvatarInfo> list;
			List<ItemData> removedItems;
			(list, removedItems) = await FreesrShared.ClearRelicAndEquipment(player);
			if (list.Count > 0)
			{
				await player.SendPacket(new PacketPlayerSyncScNotify(list));
			}
			if (removedItems.Count > 0)
			{
				await player.SendPacket(new PacketPlayerSyncScNotify(removedItems));
			}
			DatabaseHelper.ToSaveUidList.SafeAdd(player.Uid);
			await arg.SendMsg(I18NManager.Translate("Game.Command.Json.ClearInventory"));
			return;
		}
		if (text.Equals("export", StringComparison.OrdinalIgnoreCase))
		{
			bool result = false;
			string outputFileName = $"freesr-data_{player.Data.Name}_{player.Data.Uid}_{DateTime.Now:yyMMddHHmmss}.json";
			if (arg.Args.Count == 2)
			{
				if (!bool.TryParse(arg.Args[1], out result))
				{
					outputFileName = arg.Args[1] + ".json";
					result = true;
				}
			}
			else if (arg.Args.Count == 3)
			{
				outputFileName = arg.Args[1] + ".json";
				if (!bool.TryParse(arg.Args[2], out result))
				{
					result = true;
				}
			}
			string contents = await FreesrShared.ExportPlayerDataAsync(player.Uid, result);
			await File.WriteAllTextAsync(Path.Combine(GetJsonDirectories(createIfMissing: true)[0].FullName, outputFileName), contents, Encoding.UTF8);
			await arg.SendMsg(I18NManager.Translate("Game.Command.Json.ExportSuccess", outputFileName));
			return;
		}
		string error;
		string selectedPath = ResolveInputPath(text, out error);
		if (selectedPath == null)
		{
			if (!string.IsNullOrWhiteSpace(error))
			{
				await arg.SendMsg(error);
			}
			return;
		}
		if (!File.Exists(selectedPath))
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Json.FileNotFound", selectedPath));
			return;
		}
		_ = string.Empty;
		string json;
		try
		{
			json = await File.ReadAllTextAsync(selectedPath);
		}
		catch (Exception ex)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Json.ReadOrParseFailed", ex.Message));
			return;
		}
		await FreesrShared.ImportJson(json, player, async delegate(string[] msg)
		{
			if (msg[0] == "Game.Command.Json.ImportSummary")
			{
				await arg.SendMsg(I18NManager.Translate("Game.Command.Json.ImportSummary", Path.GetFileName(selectedPath), msg[1], msg[2], msg[3]));
			}
			else
			{
				await arg.SendMsg(I18NManager.Translate(msg[0], msg.Skip(1).ToArray()));
			}
		});
	}

	private static string? ResolveInputPath(string input, out string? error)
	{
		error = null;
		input = input.Trim();
		string text;
		if (input.Length >= 2 && input.StartsWith('"') && input.EndsWith('"'))
		{
			text = input;
			input = text.Substring(1, text.Length - 1 - 1);
		}
		if (int.TryParse(input, out var result))
		{
			List<FileInfo> list = (from f in GetJsonFiles()
				orderby f.LastWriteTimeUtc
				select f).ToList();
			if (list.Count == 0)
			{
				error = I18NManager.Translate("Game.Command.Json.NoFileFoundWithHint");
				return null;
			}
			if (result < 1 || result > list.Count)
			{
				error = I18NManager.Translate("Game.Command.Json.InvalidChoice", list.Count.ToString());
				return null;
			}
			return list[result - 1].FullName;
		}
		if (input.Contains('/') || input.Contains('\\') || Path.IsPathRooted(input))
		{
			return Path.GetFullPath(input);
		}
		List<DirectoryInfo> jsonDirectories = GetJsonDirectories(createIfMissing: true);
		string path = (input.EndsWith(".json", StringComparison.OrdinalIgnoreCase) ? input : (input + ".json"));
		foreach (DirectoryInfo item in jsonDirectories)
		{
			string text2 = Path.Combine(item.FullName, input);
			if (File.Exists(text2))
			{
				text = text2;
			}
			else
			{
				text2 = Path.Combine(item.FullName, path);
				if (!File.Exists(text2))
				{
					continue;
				}
				text = text2;
			}
			goto IL_019e;
		}
		return Path.Combine(jsonDirectories[0].FullName, path);
		IL_019e:
		return text;
	}

	private static List<FileInfo> GetJsonFiles()
	{
		List<DirectoryInfo> jsonDirectories = GetJsonDirectories(createIfMissing: true);
		try
		{
			return jsonDirectories.Where((DirectoryInfo x) => x.Exists).SelectMany((DirectoryInfo x) => x.GetFiles("*.json", SearchOption.TopDirectoryOnly)).DistinctBy((FileInfo x) => x.FullName)
				.ToList();
		}
		catch
		{
			return new List<FileInfo>();
		}
	}

	private static async ValueTask ShowFileList(CommandArg arg)
	{
		List<FileInfo> files = (from f in GetJsonFiles()
			orderby f.LastWriteTimeUtc
			select f).ToList();
		if (files.Count == 0)
		{
			List<string> searched = (from x in GetJsonDirectories(createIfMissing: true)
				select x.FullName).ToList();
			await arg.SendMsg(I18NManager.Translate("Game.Command.Json.NoFileFound"));
			if (searched.Count <= 0)
			{
				return;
			}
			await arg.SendMsg(I18NManager.Translate("Game.Command.Json.SearchedDirectories"));
			foreach (string item in searched)
			{
				await arg.SendMsg(I18NManager.Translate("Game.Command.Json.SearchedDirectoryItem", item));
			}
		}
		else
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Json.FoundFiles"));
			for (int i = 0; i < files.Count; i++)
			{
				await arg.SendMsg(I18NManager.Translate("Game.Command.Json.FileListItem", (i + 1).ToString(), files[i].Name));
			}
			await arg.SendMsg(I18NManager.Translate("Game.Command.Json.UsageSelectHint"));
		}
	}
}
