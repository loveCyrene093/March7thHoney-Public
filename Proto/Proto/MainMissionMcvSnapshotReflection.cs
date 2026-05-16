using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MainMissionMcvSnapshotReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MainMissionMcvSnapshotReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChxNYWluTWlzc2lvbk1jdlNuYXBzaG90LnByb3RvGiRNaXNzaW9uQ3VzdG9t";
		buffer[1] = "VmFsdWVTbmFwc2hvdExpc3QucHJvdG8ibQoWTWFpbk1pc3Npb25NY3ZTbmFw";
		buffer[2] = "c2hvdBIXCg9tYWluX21pc3Npb25faWQYASABKA0SOgoRY3VzdG9tX3ZhbHVl";
		buffer[3] = "X2xpc3QYAiABKAsyHy5NaXNzaW9uQ3VzdG9tVmFsdWVTbmFwc2hvdExpc3RC";
		buffer[4] = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MissionCustomValueSnapshotListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MainMissionMcvSnapshot), MainMissionMcvSnapshot.Parser, new string[2] { "MainMissionId", "CustomValueList" }, null, null, null, null)
		}));
	}
}
