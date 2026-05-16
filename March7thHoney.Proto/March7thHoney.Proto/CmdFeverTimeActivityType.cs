using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdFeverTimeActivityType
{
	[OriginalName("AIELOHBCOPG_PCPDHELPKEM")]
	AielohbcopgPcpdhelpkem = 0,
	[OriginalName("CmdFeverTimeActivityBattleEndScNotify")]
	CmdFeverTimeActivityBattleEndScNotify = 7151,
	[OriginalName("CmdEnterFeverTimeActivityStageScRsp")]
	CmdEnterFeverTimeActivityStageScRsp = 7160,
	[OriginalName("CmdGetFeverTimeActivityDataScRsp")]
	CmdGetFeverTimeActivityDataScRsp = 7155,
	[OriginalName("CmdEnterFeverTimeActivityStageCsReq")]
	CmdEnterFeverTimeActivityStageCsReq = 7159,
	[OriginalName("CmdGetFeverTimeActivityDataCsReq")]
	CmdGetFeverTimeActivityDataCsReq = 7157
}
