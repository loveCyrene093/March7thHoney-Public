using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class QuitBattleCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static QuitBattleCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChVRdWl0QmF0dGxlQ3NSZXEucHJvdG8aFkJhdHRsZVN0YXRpc3RpY3MucHJv";
		buffer[1] = "dG8aElJlYmF0dGxlVHlwZS5wcm90byJVCg9RdWl0QmF0dGxlQ3NSZXESIgoL";
		buffer[2] = "TUdBQk1DQk9ITUsYAiABKA4yDS5SZWJhdHRsZVR5cGUSHgoDc3R0GAggASgL";
		buffer[3] = "MhEuQmF0dGxlU3RhdGlzdGljc0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG";
		buffer[4] = "cHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			BattleStatisticsReflection.Descriptor,
			RebattleTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(QuitBattleCsReq), QuitBattleCsReq.Parser, new string[2] { "MGABMCBOHMK", "Stt" }, null, null, null, null)
		}));
	}
}
