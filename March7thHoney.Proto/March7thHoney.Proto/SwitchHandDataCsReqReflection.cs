using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwitchHandDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwitchHandDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlTd2l0Y2hIYW5kRGF0YUNzUmVxLnByb3RvIigKE1N3aXRjaEhhbmREYXRh" + "Q3NSZXESEQoJY29uZmlnX2lkGAcgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwitchHandDataCsReq), SwitchHandDataCsReq.Parser, new string[1] { "ConfigId" }, null, null, null, null)
		}));
	}
}
