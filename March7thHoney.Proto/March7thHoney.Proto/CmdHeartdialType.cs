using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdHeartdialType
{
	[OriginalName("NIOFDIFADEK_PCPDHELPKEM")]
	NiofdifadekPcpdhelpkem = 0,
	[OriginalName("CmdSubmitEmotionItemCsReq")]
	CmdSubmitEmotionItemCsReq = 6314,
	[OriginalName("CmdHeartDialTraceScriptCsReq")]
	CmdHeartDialTraceScriptCsReq = 6326,
	[OriginalName("CmdSubmitEmotionItemScRsp")]
	CmdSubmitEmotionItemScRsp = 6318,
	[OriginalName("CmdHeartDialScriptChangeScNotify")]
	CmdHeartDialScriptChangeScNotify = 6363,
	[OriginalName("CmdGetHeartDialInfoCsReq")]
	CmdGetHeartDialInfoCsReq = 6391,
	[OriginalName("CmdHeartDialTraceScriptScRsp")]
	CmdHeartDialTraceScriptScRsp = 6339,
	[OriginalName("CmdChangeScriptEmotionCsReq")]
	CmdChangeScriptEmotionCsReq = 6394,
	[OriginalName("CmdFinishEmotionDialoguePerformanceScRsp")]
	CmdFinishEmotionDialoguePerformanceScRsp = 6398,
	[OriginalName("CmdChangeScriptEmotionScRsp")]
	CmdChangeScriptEmotionScRsp = 6395,
	[OriginalName("CmdFinishEmotionDialoguePerformanceCsReq")]
	CmdFinishEmotionDialoguePerformanceCsReq = 6309,
	[OriginalName("CmdGetHeartDialInfoScRsp")]
	CmdGetHeartDialInfoScRsp = 6310
}
