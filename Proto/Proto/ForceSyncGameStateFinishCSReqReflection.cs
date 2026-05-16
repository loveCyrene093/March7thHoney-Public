using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ForceSyncGameStateFinishCSReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ForceSyncGameStateFinishCSReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNGb3JjZVN5bmNHYW1lU3RhdGVGaW5pc2hDU1JlcS5wcm90byIfCh1Gb3Jj" + "ZVN5bmNHYW1lU3RhdGVGaW5pc2hDU1JlcUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ForceSyncGameStateFinishCSReq), ForceSyncGameStateFinishCSReq.Parser, null, null, null, null, null)
		}));
	}
}
