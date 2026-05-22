using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MarkAvatarCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MarkAvatarCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVNYXJrQXZhdGFyQ3NSZXEucHJvdG8iNwoPTWFya0F2YXRhckNzUmVxEhEK" + "CWlzX21hcmtlZBgBIAEoCBIRCglhdmF0YXJfaWQYCSABKA1CFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MarkAvatarCsReq), MarkAvatarCsReq.Parser, new string[2] { "IsMarked", "AvatarId" }, null, null, null, null)
		}));
	}
}
