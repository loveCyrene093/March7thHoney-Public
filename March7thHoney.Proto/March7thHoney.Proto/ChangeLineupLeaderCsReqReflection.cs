using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChangeLineupLeaderCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChangeLineupLeaderCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1DaGFuZ2VMaW5ldXBMZWFkZXJDc1JlcS5wcm90byInChdDaGFuZ2VMaW5l" + "dXBMZWFkZXJDc1JlcRIMCgRzbG90GAMgASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChangeLineupLeaderCsReq), ChangeLineupLeaderCsReq.Parser, new string[1] { "Slot" }, null, null, null, null)
		}));
	}
}
