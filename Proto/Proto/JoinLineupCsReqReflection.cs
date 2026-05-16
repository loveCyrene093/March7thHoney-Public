using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JoinLineupCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JoinLineupCsReqReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChVKb2luTGluZXVwQ3NSZXEucHJvdG8aEEF2YXRhclR5cGUucHJvdG8aFUV4";
		buffer[1] = "dHJhTGluZXVwVHlwZS5wcm90byK7AQoPSm9pbkxpbmV1cENzUmVxEg0KBWlu";
		buffer[2] = "ZGV4GAEgASgNEiAKC2F2YXRhcl90eXBlGAQgASgOMgsuQXZhdGFyVHlwZRIS";
		buffer[3] = "Cgppc192aXJ0dWFsGAcgASgIEhAKCHBsYW5lX2lkGAggASgNEisKEWV4dHJh";
		buffer[4] = "X2xpbmV1cF90eXBlGAogASgOMhAuRXh0cmFMaW5ldXBUeXBlEgwKBHNsb3QY";
		buffer[5] = "DSABKA0SFgoOYmFzZV9hdmF0YXJfaWQYDiABKA1CFqoCE01hcmNoN3RoSG9u";
		buffer[6] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			AvatarTypeReflection.Descriptor,
			ExtraLineupTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JoinLineupCsReq), JoinLineupCsReq.Parser, new string[7] { "Index", "AvatarType", "IsVirtual", "PlaneId", "ExtraLineupType", "Slot", "BaseAvatarId" }, null, null, null, null)
		}));
	}
}
