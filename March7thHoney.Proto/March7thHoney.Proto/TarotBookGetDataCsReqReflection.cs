using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TarotBookGetDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TarotBookGetDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtUYXJvdEJvb2tHZXREYXRhQ3NSZXEucHJvdG8iFwoVVGFyb3RCb29rR2V0" + "RGF0YUNzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TarotBookGetDataCsReq), TarotBookGetDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
