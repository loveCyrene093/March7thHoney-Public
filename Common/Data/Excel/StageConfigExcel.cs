using System.Collections.Generic;
using March7thHoney.Proto;

namespace March7thHoney.Data.Excel;

[ResourceEntity("StageConfig.json,StageTestConfig.json", true)]
public class StageConfigExcel : ExcelResource
{
	public int StageID { get; set; }

	public HashName StageName { get; set; } = new HashName();

	public List<StageMonsterList> MonsterList { get; set; } = new List<StageMonsterList>();

	public List<StageConfigInfo> StageConfigData { get; set; } = new List<StageConfigInfo>();

	public List<int> TrialAvatarList { get; set; } = new List<int>();

	public override int GetId()
	{
		return StageID;
	}

	public override void Loaded()
	{
		GameData.StageConfigData.TryAdd(StageID, this);
	}

	public List<SceneMonsterWave> ToProto()
	{
		List<SceneMonsterWave> list = new List<SceneMonsterWave>();
		int num = 1;
		foreach (StageMonsterList monster in MonsterList)
		{
			SceneMonsterWave sceneMonsterWave = new SceneMonsterWave
			{
				BattleWaveId = (uint)num++,
				BattleStageId = (uint)StageID
			};
			if (monster.Monster0 != 0)
			{
				sceneMonsterWave.MonsterList.Add(new SceneMonster
				{
					MonsterId = (uint)monster.Monster0
				});
			}
			if (monster.Monster1 != 0)
			{
				sceneMonsterWave.MonsterList.Add(new SceneMonster
				{
					MonsterId = (uint)monster.Monster1
				});
			}
			if (monster.Monster2 != 0)
			{
				sceneMonsterWave.MonsterList.Add(new SceneMonster
				{
					MonsterId = (uint)monster.Monster2
				});
			}
			if (monster.Monster3 != 0)
			{
				sceneMonsterWave.MonsterList.Add(new SceneMonster
				{
					MonsterId = (uint)monster.Monster3
				});
			}
			if (monster.Monster4 != 0)
			{
				sceneMonsterWave.MonsterList.Add(new SceneMonster
				{
					MonsterId = (uint)monster.Monster4
				});
			}
			sceneMonsterWave.MonsterParam = new SceneMonsterWaveParam();
			list.Add(sceneMonsterWave);
		}
		return list;
	}
}
