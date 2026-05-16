using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SettleTrackPhotoStageScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SettleTrackPhotoStageScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiBTZXR0bGVUcmFja1Bob3RvU3RhZ2VTY1JzcC5wcm90bxoRTUJDQ0JJQU1J";
		buffer[1] = "SlAucHJvdG8idAoaU2V0dGxlVHJhY2tQaG90b1N0YWdlU2NSc3ASEAoIc2Nv";
		buffer[2] = "cmVfaWQYAiABKA0SDwoHcmV0Y29kZRgFIAEoDRIhCgtBSkRLQ0JGQ05MRxgN";
		buffer[3] = "IAMoCzIMLk1CQ0NCSUFNSUpQEhAKCHN0YWdlX2lkGA8gASgNQhaqAhNNYXJj";
		buffer[4] = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MBCCBIAMIJPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SettleTrackPhotoStageScRsp), SettleTrackPhotoStageScRsp.Parser, new string[4] { "ScoreId", "Retcode", "AJDKCBFCNLG", "StageId" }, null, null, null, null)
		}));
	}
}
