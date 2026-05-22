using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LockRelicCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LockRelicCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRMb2NrUmVsaWNDc1JlcS5wcm90byJLCg5Mb2NrUmVsaWNDc1JlcRIRCgly" + "ZWxpY19pZHMYASADKA0SEQoJaXNfbG9ja2VkGAkgASgIEhMKC0tJUEJJTkJJ" + "REFFGAsgASgIQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LockRelicCsReq), LockRelicCsReq.Parser, new string[3] { "RelicIds", "IsLocked", "KIPBINBIDAE" }, null, null, null, null)
		}));
	}
}
