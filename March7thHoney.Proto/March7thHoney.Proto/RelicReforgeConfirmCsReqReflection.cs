using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RelicReforgeConfirmCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RelicReforgeConfirmCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5SZWxpY1JlZm9yZ2VDb25maXJtQ3NSZXEucHJvdG8iRgoYUmVsaWNSZWZv" + "cmdlQ29uZmlybUNzUmVxEhEKCWlzX2NhbmNlbBgJIAEoCBIXCg9yZWxpY191" + "bmlxdWVfaWQYCyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv" + "Mw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RelicReforgeConfirmCsReq), RelicReforgeConfirmCsReq.Parser, new string[2] { "IsCancel", "RelicUniqueId" }, null, null, null, null)
		}));
	}
}
