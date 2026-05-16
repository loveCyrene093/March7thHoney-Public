using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DelMailCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DelMailCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJEZWxNYWlsQ3NSZXEucHJvdG8iHwoMRGVsTWFpbENzUmVxEg8KB2lkX2xp" + "c3QYByADKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DelMailCsReq), DelMailCsReq.Parser, new string[1] { "IdList" }, null, null, null, null)
		}));
	}
}
