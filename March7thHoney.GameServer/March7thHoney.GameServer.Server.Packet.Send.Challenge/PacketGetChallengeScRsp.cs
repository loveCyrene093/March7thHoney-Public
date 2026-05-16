using System.Collections.Generic;
using System.Linq;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Challenge;
using March7thHoney.GameServer.Game.Challenge;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Challenge;

public class PacketGetChallengeScRsp : BasePacket
{
	public PacketGetChallengeScRsp(PlayerInstance player)
		: base(1710)
	{
		GetChallengeScRsp getChallengeScRsp = new GetChallengeScRsp
		{
			Retcode = 0u
		};
		foreach (ChallengeConfigExcel value3 in GameData.ChallengeConfigData.Values)
		{
			ChallengeManager? challengeManager = player.ChallengeManager;
			if (challengeManager != null && challengeManager.ChallengeData.History.TryGetValue(value3.ID, out ChallengeHistoryData value))
			{
				ChallengeHistoryData challengeHistoryData = value;
				if (challengeHistoryData.GroupId == 0)
				{
					challengeHistoryData.GroupId = value3.GroupID;
				}
				getChallengeScRsp.ChallengeList.Add(challengeHistoryData.ToProto());
			}
			else
			{
				getChallengeScRsp.ChallengeList.Add(new March7thHoney.Proto.Challenge
				{
					ChallengeId = (uint)value3.ID
				});
			}
		}
		Dictionary<int, ChallengeGroupReward> dictionary = player.ChallengeManager?.ChallengeData?.TakenRewards ?? new Dictionary<int, ChallengeGroupReward>();
		foreach (int item in GameData.ChallengeGroupData.Keys.OrderBy((int x) => x))
		{
			if (dictionary.TryGetValue(item, out var value2))
			{
				getChallengeScRsp.ChallengeGroupList.Add(value2.ToProto());
				continue;
			}
			getChallengeScRsp.ChallengeGroupList.Add(new ChallengeGroup
			{
				GroupId = (uint)item,
				TakenStarsCountReward = 0uL
			});
		}
		getChallengeScRsp.MaxLevelList.Add(new ChallengeHistoryMaxLevel
		{
			RewardDisplayType = 1u,
			Level = 12u
		});
		getChallengeScRsp.MaxLevelList.Add(new ChallengeHistoryMaxLevel
		{
			RewardDisplayType = 2u,
			Level = 4u
		});
		getChallengeScRsp.MaxLevelList.Add(new ChallengeHistoryMaxLevel
		{
			RewardDisplayType = 3u,
			Level = 4u
		});
		SetData(getChallengeScRsp);
	}
}
