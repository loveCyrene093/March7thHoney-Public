using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeOffAvatarSkinCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeOffAvatarSkinCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxUYWtlT2ZmQXZhdGFyU2tpbkNzUmVxLnByb3RvIisKFlRha2VPZmZBdmF0" + "YXJTa2luQ3NSZXESEQoJYXZhdGFyX2lkGA4gASgNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeOffAvatarSkinCsReq), TakeOffAvatarSkinCsReq.Parser, new string[1] { "AvatarId" }, null, null, null, null)
		}));
	}
}
