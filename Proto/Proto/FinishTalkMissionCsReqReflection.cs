using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishTalkMissionCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishTalkMissionCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChxGaW5pc2hUYWxrTWlzc2lvbkNzUmVxLnByb3RvGhhNaXNzaW9uQ3VzdG9t";
		buffer[1] = "VmFsdWUucHJvdG8icgoWRmluaXNoVGFsa01pc3Npb25Dc1JlcRIQCgh0YWxr";
		buffer[2] = "X3N0chgBIAEoCRIuChFjdXN0b21fdmFsdWVfbGlzdBgHIAMoCzITLk1pc3Np";
		buffer[3] = "b25DdXN0b21WYWx1ZRIWCg5zdWJfbWlzc2lvbl9pZBgKIAEoDUIWqgITTWFy";
		buffer[4] = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MissionCustomValueReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishTalkMissionCsReq), FinishTalkMissionCsReq.Parser, new string[3] { "TalkStr", "CustomValueList", "SubMissionId" }, null, null, null, null)
		}));
	}
}
