using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DressRelicAvatarCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DressRelicAvatarCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtEcmVzc1JlbGljQXZhdGFyQ3NSZXEucHJvdG8aFURyZXNzUmVsaWNQYXJh" + "bS5wcm90byJRChVEcmVzc1JlbGljQXZhdGFyQ3NSZXESEQoJYXZhdGFyX2lk" + "GAYgASgNEiUKC3N3aXRjaF9saXN0GAogAygLMhAuRHJlc3NSZWxpY1BhcmFt" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { DressRelicParamReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DressRelicAvatarCsReq), DressRelicAvatarCsReq.Parser, new string[2] { "AvatarId", "SwitchList" }, null, null, null, null)
		}));
	}
}
