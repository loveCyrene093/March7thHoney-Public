using March7thHoney.Command;
using March7thHoney.Database.Lineup;
using March7thHoney.GameServer.Game.Battle;
using March7thHoney.GameServer.Game.Challenge.Definitions;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Game.Scene;
using March7thHoney.GameServer.Game.Scene.Entity;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Plugin.Event;

public static class PluginEvent
{
	public delegate void OnPlayerHeartBeatHandler(PlayerInstance player);

	public delegate void OnPlayerLoginHandler(PlayerInstance player);

	public delegate void OnPlayerLogoutHandler(PlayerInstance player);

	public delegate void OnPlayerFinishSubMissionHandler(PlayerInstance player, int missionId);

	public delegate void OnPlayerFinishMainMissionHandler(PlayerInstance player, int missionId);

	public delegate void OnPlayerInteractHandler(PlayerInstance player, EntityProp prop);

	public delegate void OnPlayerLoadSceneHandler(PlayerInstance player, SceneInstance scene);

	public delegate void OnPlayerEnterBattleHandler(PlayerInstance player, BattleInstance battle);

	public delegate void OnPlayerQuitBattleHandler(PlayerInstance player, PVEBattleResultCsReq result);

	public delegate void OnPlayerEnterChallengeHandler(PlayerInstance player, BaseChallengeInstance challenge);

	public delegate void OnPlayerQuitChallengeHandler(PlayerInstance player, BaseChallengeInstance? challenge);

	public delegate void OnPlayerSyncLineupHandler(PlayerInstance player, March7thHoney.Database.Lineup.LineupInfo? lineup);

	public delegate void OnPlayerUseCommandHandler(ICommandSender sender, string command);

	public static event OnPlayerHeartBeatHandler? OnPlayerHeartBeat;

	public static event OnPlayerLoginHandler? OnPlayerLogin;

	public static event OnPlayerLogoutHandler? OnPlayerLogout;

	public static event OnPlayerFinishSubMissionHandler? OnPlayerFinishSubMission;

	public static event OnPlayerFinishMainMissionHandler? OnPlayerFinishMainMission;

	public static event OnPlayerInteractHandler? OnPlayerInteract;

	public static event OnPlayerLoadSceneHandler? OnPlayerLoadScene;

	public static event OnPlayerEnterBattleHandler? OnPlayerEnterBattle;

	public static event OnPlayerEnterChallengeHandler? OnPlayerEnterChallenge;

	public static event OnPlayerQuitBattleHandler? OnPlayerQuitBattle;

	public static event OnPlayerQuitChallengeHandler? OnPlayerQuitChallenge;

	public static event OnPlayerSyncLineupHandler? OnPlayerSyncLineup;

	public static event OnPlayerUseCommandHandler? OnPlayerUseCommand;

	public static void InvokeOnPlayerHeartBeat(PlayerInstance player)
	{
		PluginEvent.OnPlayerHeartBeat?.Invoke(player);
	}

	public static void InvokeOnPlayerLogin(PlayerInstance player)
	{
		PluginEvent.OnPlayerLogin?.Invoke(player);
	}

	public static void InvokeOnPlayerLogout(PlayerInstance player)
	{
		PluginEvent.OnPlayerLogout?.Invoke(player);
	}

	public static void InvokeOnPlayerFinishSubMission(PlayerInstance player, int missionId)
	{
		PluginEvent.OnPlayerFinishSubMission?.Invoke(player, missionId);
	}

	public static void InvokeOnPlayerFinishMainMission(PlayerInstance player, int missionId)
	{
		PluginEvent.OnPlayerFinishMainMission?.Invoke(player, missionId);
	}

	public static void InvokeOnPlayerInteract(PlayerInstance player, EntityProp prop)
	{
		PluginEvent.OnPlayerInteract?.Invoke(player, prop);
	}

	public static void InvokeOnPlayerLoadScene(PlayerInstance player, SceneInstance scene)
	{
		PluginEvent.OnPlayerLoadScene?.Invoke(player, scene);
	}

	public static void InvokeOnPlayerEnterBattle(PlayerInstance player, BattleInstance battle)
	{
		PluginEvent.OnPlayerEnterBattle?.Invoke(player, battle);
	}

	public static void InvokeOnPlayerQuitBattle(PlayerInstance player, PVEBattleResultCsReq result)
	{
		PluginEvent.OnPlayerQuitBattle?.Invoke(player, result);
	}

	public static void InvokeOnPlayerEnterChallenge(PlayerInstance player, BaseChallengeInstance challenge)
	{
		PluginEvent.OnPlayerEnterChallenge?.Invoke(player, challenge);
	}

	public static void InvokeOnPlayerQuitChallenge(PlayerInstance player, BaseChallengeInstance? challenge)
	{
		PluginEvent.OnPlayerQuitChallenge?.Invoke(player, challenge);
	}

	public static void InvokeOnPlayerSyncLineup(PlayerInstance player, March7thHoney.Database.Lineup.LineupInfo? lineup)
	{
		PluginEvent.OnPlayerSyncLineup?.Invoke(player, lineup);
	}

	public static void InvokeOnPlayerUseCommand(ICommandSender sender, string command)
	{
		PluginEvent.OnPlayerUseCommand?.Invoke(sender, command);
	}
}
