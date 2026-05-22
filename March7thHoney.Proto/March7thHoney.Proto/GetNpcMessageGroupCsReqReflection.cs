using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetNpcMessageGroupCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetNpcMessageGroupCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1HZXROcGNNZXNzYWdlR3JvdXBDc1JlcS5wcm90byIyChdHZXROcGNNZXNz" + "YWdlR3JvdXBDc1JlcRIXCg9jb250YWN0X2lkX2xpc3QYCyADKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetNpcMessageGroupCsReq), GetNpcMessageGroupCsReq.Parser, new string[1] { "ContactIdList" }, null, null, null, null)
		}));
	}
}
