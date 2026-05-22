using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdTrackPhotoActivityType
{
	[OriginalName("IGNAEJEMBFO_PCPDHELPKEM")]
	IgnaejembfoPcpdhelpkem = 0,
	[OriginalName("CmdStartTrackPhotoStageCsReq")]
	CmdStartTrackPhotoStageCsReq = 7555,
	[OriginalName("CmdSettleTrackPhotoStageCsReq")]
	CmdSettleTrackPhotoStageCsReq = 7551,
	[OriginalName("CmdEAAHNDOHPPH")]
	CmdEaahndohpph = 7556,
	[OriginalName("CmdSettleTrackPhotoStageScRsp")]
	CmdSettleTrackPhotoStageScRsp = 7557,
	[OriginalName("CmdGetTrackPhotoActivityDataCsReq")]
	CmdGetTrackPhotoActivityDataCsReq = 7559,
	[OriginalName("CmdQuitTrackPhotoStageCsReq")]
	CmdQuitTrackPhotoStageCsReq = 7552,
	[OriginalName("CmdGetTrackPhotoActivityDataScRsp")]
	CmdGetTrackPhotoActivityDataScRsp = 7560,
	[OriginalName("CmdStartTrackPhotoStageScRsp")]
	CmdStartTrackPhotoStageScRsp = 7554
}
