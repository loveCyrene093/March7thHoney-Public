using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IdleLiveStartDungeonCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IdleLiveStartDungeonCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "Ch9JZGxlTGl2ZVN0YXJ0RHVuZ2VvbkNzUmVxLnByb3RvGhFHS0RFS0pLT0lK";
		buffer[1] = "Ti5wcm90byKLAQoZSWRsZUxpdmVTdGFydER1bmdlb25Dc1JlcRIhCgtDUE9N";
		buffer[2] = "TkdKREJDTBgDIAMoCzIMLkdLREVLSktPSUpOEhMKC0NQTUdISkZBSUFCGAkg";
		buffer[3] = "AygNEiEKC09JQ0VKSU1FT05HGA4gAygLMgwuR0tERUtKS09JSk4SEwoLdGFy";
		buffer[4] = "Z2V0X3NpZGUYDyABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[5] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GKDEKJKOIJNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IdleLiveStartDungeonCsReq), IdleLiveStartDungeonCsReq.Parser, new string[4] { "CPOMNGJDBCL", "CPMGHJFAIAB", "OICEJIMEONG", "TargetSide" }, null, null, null, null)
		}));
	}
}
