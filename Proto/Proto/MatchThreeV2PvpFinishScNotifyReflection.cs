using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MatchThreeV2PvpFinishScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MatchThreeV2PvpFinishScNotifyReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "CiNNYXRjaFRocmVlVjJQdnBGaW5pc2hTY05vdGlmeS5wcm90bxoRRUNLSURM";
		buffer[1] = "SUZBRkcucHJvdG8aEUZLQU5JQkRKTktHLnByb3RvGhNGaWdodEdhbWVNb2Rl";
		buffer[2] = "LnByb3RvGhFOT0pMUE1MQUxQSS5wcm90byLSAQodTWF0Y2hUaHJlZVYyUHZw";
		buffer[3] = "RmluaXNoU2NOb3RpZnkSIQoLTUhGSE9EREJPUE0YASABKAsyDC5FQ0tJRExJ";
		buffer[4] = "RkFGRxIjCgtCRkNCR1BFSUNIRxgEIAEoDjIOLkZpZ2h0R2FtZU1vZGUSEwoL";
		buffer[5] = "SUpETUVDTEpFQkQYBiABKA0SIQoLS0pIR0dQRU1QSE0YCyABKAsyDC5OT0pM";
		buffer[6] = "UE1MQUxQSRITCgtES0FFSURKTUpDShgOIAEoDRIcCgZyZWFzb24YDyABKA4y";
		buffer[7] = "DC5GS0FOSUJESk5LR0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			ECKIDLIFAFGReflection.Descriptor,
			FKANIBDJNKGReflection.Descriptor,
			FightGameModeReflection.Descriptor,
			NOJLPMLALPIReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MatchThreeV2PvpFinishScNotify), MatchThreeV2PvpFinishScNotify.Parser, new string[6] { "MHFHODDBOPM", "BFCBGPEICHG", "IJDMECLJEBD", "KJHGGPEMPHM", "DKAEIDJMJCJ", "Reason" }, null, null, null, null)
		}));
	}
}
