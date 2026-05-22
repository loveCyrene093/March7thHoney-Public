using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetTutorialScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetTutorialScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZHZXRUdXRvcmlhbFNjUnNwLnByb3RvGg5UdXRvcmlhbC5wcm90byJFChBH" + "ZXRUdXRvcmlhbFNjUnNwEiAKDXR1dG9yaWFsX2xpc3QYASADKAsyCS5UdXRv" + "cmlhbBIPCgdyZXRjb2RlGAogASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[1] { TutorialReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetTutorialScRsp), GetTutorialScRsp.Parser, new string[2] { "TutorialList", "Retcode" }, null, null, null, null)
		}));
	}
}
