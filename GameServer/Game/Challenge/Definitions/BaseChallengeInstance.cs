using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.Data.Excel;
using March7thHoney.GameServer.Game.Battle;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Proto;
using March7thHoney.Proto.ServerSide;

namespace March7thHoney.GameServer.Game.Challenge.Definitions;

public abstract class BaseChallengeInstance(PlayerInstance player, ChallengeDataPb data)
{
	public PlayerInstance Player { get; } = player;

	public ChallengeDataPb Data { get; } = data;

	public virtual void OnBattleStart(BattleInstance battle)
	{
		battle.OnBattleEnd += OnBattleEnd;
	}

	public virtual async ValueTask OnBattleEnd(BattleInstance battle, PVEBattleResultCsReq req)
	{
		await ValueTask.CompletedTask;
	}

	public abstract Dictionary<int, List<ChallengeConfigExcel.ChallengeMonsterInfo>> GetStageMonsters();

	public virtual void OnUpdate()
	{
	}
}
