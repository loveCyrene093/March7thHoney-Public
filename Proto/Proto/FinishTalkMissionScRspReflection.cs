using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishTalkMissionScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishTalkMissionScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChxGaW5pc2hUYWxrTWlzc2lvblNjUnNwLnByb3RvGhhNaXNzaW9uQ3VzdG9t";
		buffer[1] = "VmFsdWUucHJvdG8igwEKFkZpbmlzaFRhbGtNaXNzaW9uU2NSc3ASFgoOc3Vi";
		buffer[2] = "X21pc3Npb25faWQYAiABKA0SDwoHcmV0Y29kZRgEIAEoDRIQCgh0YWxrX3N0";
		buffer[3] = "chgJIAEoCRIuChFjdXN0b21fdmFsdWVfbGlzdBgKIAMoCzITLk1pc3Npb25D";
		buffer[4] = "dXN0b21WYWx1ZUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MissionCustomValueReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishTalkMissionScRsp), FinishTalkMissionScRsp.Parser, new string[4] { "SubMissionId", "Retcode", "TalkStr", "CustomValueList" }, null, null, null, null)
		}));
	}
}
