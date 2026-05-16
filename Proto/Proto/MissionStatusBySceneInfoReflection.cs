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
		buffer[0] = "Ch5NaXNzaW9uU3RhdHVzQnlTY2VuZUluZm8ucHJvdG8aHE1haW5NaXNzaW9u";
		buffer[1] = "Q3VzdG9tVmFsdWUucHJvdG8aDU1pc3Npb24ucHJvdG8i6gEKGE1pc3Npb25T";
		buffer[2] = "dGF0dXNCeVNjZW5lSW5mbxIlCh1kaXNhYmxlZF9tYWluX21pc3Npb25faWRf";
		buffer[3] = "bGlzdBgBIAMoDRIpChdzdWJfbWlzc2lvbl9zdGF0dXNfbGlzdBgCIAMoCzII";
		buffer[4] = "Lk1pc3Npb24SLAoLTkVESkdKTkxJUEYYBCADKAsyFy5NYWluTWlzc2lvbkN1";
		buffer[5] = "c3RvbVZhbHVlEicKH3VuZmluaXNoZWRfbWFpbl9taXNzaW9uX2lkX2xpc3QY";
		buffer[6] = "CSADKA0SJQodZmluaXNoZWRfbWFpbl9taXNzaW9uX2lkX2xpc3QYDSADKA1C";
		buffer[7] = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			MainMissionCustomValueReflection.Descriptor,
			MissionReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MissionStatusBySceneInfo), MissionStatusBySceneInfo.Parser, new string[5] { "DisabledMainMissionIdList", "SubMissionStatusList", "NEDJGJNLIPF", "UnfinishedMainMissionIdList", "FinishedMainMissionIdList" }, null, null, null, null)
		}));
	}
}
