using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdBattleType
{
	[OriginalName("JHHEBHOKOEK_PCPDHELPKEM")]
	JhhebhokoekPcpdhelpkem = 0,
	[OriginalName("CmdPVEBattleResultScRsp")]
	CmdPvebattleResultScRsp = 110,
	[OriginalName("CmdSyncClientResVersionCsReq")]
	CmdSyncClientResVersionCsReq = 109,
	[OriginalName("CmdPDNPICPECAC")]
	CmdPdnpicpecac = 195,
	[OriginalName("CmdQuitBattleScNotify")]
	CmdQuitBattleScNotify = 163,
	[OriginalName("JHHEBHOKOEK_KAPOBGDLHGC")]
	JhhebhokoekKapobgdlhgc = 126,
	[OriginalName("CmdServerSimulateBattleFinishScNotify")]
	CmdServerSimulateBattleFinishScNotify = 101,
	[OriginalName("CmdRebattleByClientCsNotify")]
	CmdRebattleByClientCsNotify = 137,
	[OriginalName("CmdBattleLogReportScRsp")]
	CmdBattleLogReportScRsp = 139,
	[OriginalName("CmdQuitBattleCsReq")]
	CmdQuitBattleCsReq = 194,
	[OriginalName("CmdGetCurBattleInfoScRsp")]
	CmdGetCurBattleInfoScRsp = 118,
	[OriginalName("CmdGetCurBattleInfoCsReq")]
	CmdGetCurBattleInfoCsReq = 114,
	[OriginalName("CmdReBattleAfterBattleLoseCsNotify")]
	CmdReBattleAfterBattleLoseCsNotify = 174,
	[OriginalName("CmdPVEBattleResultCsReq")]
	CmdPvebattleResultCsReq = 191,
	[OriginalName("CmdSyncClientResVersionScRsp")]
	CmdSyncClientResVersionScRsp = 198
}
