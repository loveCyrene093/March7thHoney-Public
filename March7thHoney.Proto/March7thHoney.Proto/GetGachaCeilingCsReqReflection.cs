using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetGachaCeilingCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetGachaCeilingCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpHZXRHYWNoYUNlaWxpbmdDc1JlcS5wcm90byIqChRHZXRHYWNoYUNlaWxp" + "bmdDc1JlcRISCgpnYWNoYV90eXBlGAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetGachaCeilingCsReq), GetGachaCeilingCsReq.Parser, new string[1] { "GachaType" }, null, null, null, null)
		}));
	}
}
