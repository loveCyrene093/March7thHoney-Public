using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class QuitTreasureDungeonCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static QuitTreasureDungeonCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5RdWl0VHJlYXN1cmVEdW5nZW9uQ3NSZXEucHJvdG8iRAoYUXVpdFRyZWFz" + "dXJlRHVuZ2VvbkNzUmVxEhMKC3RhcmdldF9zaWRlGAEgASgNEhMKC1BBTURM" + "SE9DTUNDGAcgASgIQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(QuitTreasureDungeonCsReq), QuitTreasureDungeonCsReq.Parser, new string[2] { "TargetSide", "PAMDLHOCMCC" }, null, null, null, null)
		}));
	}
}
