using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetSaveLogisticsMapCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetSaveLogisticsMapCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5HZXRTYXZlTG9naXN0aWNzTWFwQ3NSZXEucHJvdG8iGgoYR2V0U2F2ZUxv" + "Z2lzdGljc01hcENzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetSaveLogisticsMapCsReq), GetSaveLogisticsMapCsReq.Parser, null, null, null, null, null)
		}));
	}
}
