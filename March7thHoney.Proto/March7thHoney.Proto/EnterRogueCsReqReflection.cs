using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterRogueCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterRogueCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVFbnRlclJvZ3VlQ3NSZXEucHJvdG8iIgoPRW50ZXJSb2d1ZUNzUmVxEg8K" + "B2FyZWFfaWQYCyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterRogueCsReq), EnterRogueCsReq.Parser, new string[1] { "AreaId" }, null, null, null, null)
		}));
	}
}
