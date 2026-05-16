using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MissionStatusBySceneInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MissionStatusBySceneInfoReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "Ch5NaXNzaW9uU3RhdHVzQnlTY2VuZUluZm8ucHJvdG8aHE1haW5NaXNzaW9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "Q3VzdG9tVmFsdWUucHJvdG8aDU1pc3Npb24ucHJvdG8i6gEKGE1pc3Npb25T";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "dGF0dXNCeVNjZW5lSW5mbxIlCh1kaXNhYmxlZF9tYWluX21pc3Npb25faWRf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "bGlzdBgBIAMoDRIpChdzdWJfbWlzc2lvbl9zdGF0dXNfbGlzdBgCIAMoCzII";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "Lk1pc3Npb24SLAoLTkVESkdKTkxJUEYYBCADKAsyFy5NYWluTWlzc2lvbkN1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "c3RvbVZhbHVlEicKH3VuZmluaXNoZWRfbWFpbl9taXNzaW9uX2lkX2xpc3QY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "CSADKA0SJQodZmluaXNoZWRfbWFpbl9taXNzaW9uX2lkX2xpc3QYDSADKA1C";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[2]
		{
			MainMissionCustomValueReflection.Descriptor,
			MissionReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MissionStatusBySceneInfo), MissionStatusBySceneInfo.Parser, new string[5] { "DisabledMainMissionIdList", "SubMissionStatusList", "NEDJGJNLIPF", "UnfinishedMainMissionIdList", "FinishedMainMissionIdList" }, null, null, null, null)
		}));
	}
}
