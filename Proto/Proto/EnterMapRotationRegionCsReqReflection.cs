using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterMapRotationRegionCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterMapRotationRegionCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiFFbnRlck1hcFJvdGF0aW9uUmVnaW9uQ3NSZXEucHJvdG8aEE1vdGlvbklu";
		buffer[1] = "Zm8ucHJvdG8iZAobRW50ZXJNYXBSb3RhdGlvblJlZ2lvbkNzUmVxEhMKC0pI";
		buffer[2] = "RExOQlBORUtHGAEgASgNEhMKC0JDUENCSE1GSUlOGAcgASgNEhsKBm1vdGlv";
		buffer[3] = "bhgPIAEoCzILLk1vdGlvbkluZm9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[4] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MotionInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterMapRotationRegionCsReq), EnterMapRotationRegionCsReq.Parser, new string[3] { "JHDLNBPNEKG", "BCPCBHMFIIN", "Motion" }, null, null, null, null)
		}));
	}
}
