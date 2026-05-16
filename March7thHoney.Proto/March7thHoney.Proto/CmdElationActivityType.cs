using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdElationActivityType
{
	[OriginalName("LMALBOAPKOH_PCPDHELPKEM")]
	LmalboapkohPcpdhelpkem = 0,
	[OriginalName("CmdElationActivityBattleEndScNotify")]
	CmdElationActivityBattleEndScNotify = 9105,
	[OriginalName("CmdEnterElationActivityStageScRsp")]
	CmdEnterElationActivityStageScRsp = 9107,
	[OriginalName("CmdEnterElationActivityStageCsReq")]
	CmdEnterElationActivityStageCsReq = 9101,
	[OriginalName("CmdGetElationActivityDataScRsp")]
	CmdGetElationActivityDataScRsp = 9110,
	[OriginalName("CmdGetActivityElationDataCsReq")]
	CmdGetActivityElationDataCsReq = 9109
}
