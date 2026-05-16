using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CancelMatchCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CancelMatchCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZDYW5jZWxNYXRjaENzUmVxLnByb3RvIhIKEENhbmNlbE1hdGNoQ3NSZXFC" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CancelMatchCsReq), CancelMatchCsReq.Parser, null, null, null, null, null)
		}));
	}
}
