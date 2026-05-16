using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Mission;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Game.Quest;
using March7thHoney.GameServer.Server.Packet.Send.Player;
using March7thHoney.Internationalization;
using March7thHoney.Proto;

namespace March7thHoney.Command.Command.Cmd;

[CommandInfo("unlockall", "Game.Command.UnlockAll.Desc", "Game.Command.UnlockAll.Usage", new string[] { "ua" }, "", "")]
public class CommandUnlockAll : ICommand
{
	[CommandMethod("0 mission")]
	public async ValueTask UnlockAllMissions(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		PlayerInstance player = arg.Target.Player;
		MissionManager missionManager = player.MissionManager;
		foreach (SubMissionData value in GameData.SubMissionInfoData.Values)
		{
			missionManager.Data.SetSubMissionStatus(value.MissionId, MissionPhaseEnum.Finish);
		}
		foreach (MainMissionExcel value2 in GameData.MainMissionData.Values)
		{
			missionManager.Data.SetMainMissionStatus(value2.MainMissionID, MissionPhaseEnum.Finish);
		}
		if (player.Data.CurrentGender == Gender.Man)
		{
			player.Data.CurrentGender = Gender.Man;
			player.Data.CurBasicType = 8001;
		}
		else
		{
			player.Data.CurrentGender = Gender.Woman;
			player.Data.CurBasicType = 8002;
			player.AvatarManager.GetHero().AvatarId = 8002;
		}
		await arg.SendMsg(I18NManager.Translate("Game.Command.UnlockAll.UnlockedAll", I18NManager.Translate("Word.Mission")));
		await arg.Target.Player.SendPacket(new PacketPlayerSqueezedScNotify());
		arg.Target.Stop();
	}

	[CommandMethod("0 quest")]
	public async ValueTask UnlockAllQuests(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		PlayerInstance player = arg.Target.Player;
		QuestManager questManager = player.QuestManager;
		foreach (QuestDataExcel value in GameData.QuestDataData.Values)
		{
			await questManager.FinishQuest(value.QuestID, push: false);
		}
		await questManager.SyncQuest();
		await arg.SendMsg(I18NManager.Translate("Game.Command.UnlockAll.UnlockedAll", I18NManager.Translate("Word.Quest")));
	}

	[CommandMethod("0 tutorial")]
	public async ValueTask UnlockAllTutorial(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		PlayerInstance player = arg.Target.Player;
		foreach (KeyValuePair<int, TutorialDataExcel> tutorialDataDatum in GameData.TutorialDataData)
		{
			player.TutorialData.Tutorials[tutorialDataDatum.Key] = TutorialStatus.TutorialFinish;
		}
		foreach (KeyValuePair<int, TutorialGuideDataExcel> tutorialGuideDataDatum in GameData.TutorialGuideDataData)
		{
			player.TutorialGuideData.Tutorials[tutorialGuideDataDatum.Key] = TutorialStatus.TutorialFinish;
		}
		await arg.SendMsg(I18NManager.Translate("Game.Command.UnlockAll.UnlockedAll", I18NManager.Translate("Word.Tutorial")));
		await arg.Target.Player.SendPacket(new PacketPlayerSqueezedScNotify());
		arg.Target.Stop();
	}

	[CommandMethod("0 rogue")]
	public async ValueTask UnlockAllRogue(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		PlayerInstance player = arg.Target.Player;
		List<int> collection = new List<int>(10) { 8013101, 8013102, 8013103, 8013104, 8013105, 8013106, 8013107, 8013108, 8013109, 8013110 };
		List<int> collection2 = new List<int>(6) { 8016101, 8016102, 8016103, 8016104, 8016105, 8016106 };
		List<int> collection3 = new List<int>(3) { 8023401, 8023501, 8023601 };
		List<int> collection4 = new List<int>(2) { 8026401, 8026402 };
		List<int> list = new List<int>();
		list.AddRange(collection);
		list.AddRange(collection2);
		list.AddRange(collection3);
		list.AddRange(collection4);
		List<int> list2 = list;
		foreach (int id in list2)
		{
			await player.MissionManager.AcceptMainMission(id);
			await player.MissionManager.FinishMainMission(id);
		}
		await arg.SendMsg(I18NManager.Translate("Game.Command.UnlockAll.UnlockedAll", I18NManager.Translate("Word.TypesOfRogue")));
		await arg.Target.Player.SendPacket(new PacketPlayerSqueezedScNotify());
		arg.Target.Stop();
	}

	[CommandMethod("0 challenge")]
	public async ValueTask UnlockAllChallenge(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		PlayerInstance player = arg.Target.Player;
		List<int> list = new List<int>(4) { 2200503, 2200504, 2200505, 2200506 }.ToList();
		foreach (int id in list)
		{
			await player.QuestManager.AcceptQuest(id);
			await player.QuestManager.FinishQuest(id);
		}
		await arg.SendMsg(I18NManager.Translate("Game.Command.UnlockAll.UnlockedAll", I18NManager.Translate("Word.TypesOfChallenge")));
	}

	[CommandMethod("0 grid")]
	public async ValueTask UnlockAllGrid(CommandArg arg)
	{
		if (arg.Target == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		PlayerInstance player = arg.Target.Player;
		List<int> list = new List<int>(5) { 2100162, 2100163, 7300022, 7300038, 6071325 }.ToList();
		foreach (int id in list)
		{
			await player.QuestManager.AcceptQuest(id);
			await player.QuestManager.FinishQuest(id);
		}
		if (player.SceneInstance.FloorId == 20322001)
		{
			await player.SceneInstance.UpdateFloorSavedValue("FSV_370GridFight", 1);
		}
		await arg.SendMsg(I18NManager.Translate("Game.Command.UnlockAll.UnlockedAll", I18NManager.Translate("Word.TypesOfGridFight")));
	}
}
