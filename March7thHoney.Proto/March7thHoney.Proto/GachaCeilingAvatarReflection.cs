using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GachaCeilingAvatarReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GachaCeilingAvatarReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhHYWNoYUNlaWxpbmdBdmF0YXIucHJvdG8iPQoSR2FjaGFDZWlsaW5nQXZh" + "dGFyEhQKDHJlcGVhdGVkX2NudBgFIAEoDRIRCglhdmF0YXJfaWQYDiABKA1C" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GachaCeilingAvatar), GachaCeilingAvatar.Parser, new string[2] { "RepeatedCnt", "AvatarId" }, null, null, null, null)
		}));
	}
}
