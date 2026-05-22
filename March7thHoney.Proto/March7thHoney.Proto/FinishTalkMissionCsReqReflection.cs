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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChxGaW5pc2hUYWxrTWlzc2lvbkNzUmVxLnByb3RvGhhNaXNzaW9uQ3VzdG9t";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "VmFsdWUucHJvdG8icgoWRmluaXNoVGFsa01pc3Npb25Dc1JlcRIQCgh0YWxr";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "X3N0chgBIAEoCRIuChFjdXN0b21fdmFsdWVfbGlzdBgHIAMoCzITLk1pc3Np";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "b25DdXN0b21WYWx1ZRIWCg5zdWJfbWlzc2lvbl9pZBgKIAEoDUIWqgITTWFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { MissionCustomValueReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishTalkMissionCsReq), FinishTalkMissionCsReq.Parser, new string[3] { "TalkStr", "CustomValueList", "SubMissionId" }, null, null, null, null)
		}));
	}
}
