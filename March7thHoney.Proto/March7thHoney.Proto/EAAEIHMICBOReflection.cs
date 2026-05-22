using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EAAEIHMICBOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EAAEIHMICBOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFQUFFSUhNSUNCTy5wcm90bxoRSkFNTEhPSEJJR0IucHJvdG8aEUxOT0JQ" + "RktBQUdBLnByb3RvIlMKC0VBQUVJSE1JQ0JPEiEKC0VBRUFGSUhJSU1LGAQg" + "ASgLMgwuTE5PQlBGS0FBR0ESIQoLRU5CR05MQk1HRksYCiABKAsyDC5KQU1M" + "SE9IQklHQkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[2]
		{
			JAMLHOHBIGBReflection.Descriptor,
			LNOBPFKAAGAReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EAAEIHMICBO), EAAEIHMICBO.Parser, new string[2] { "EAEAFIHIIMK", "ENBGNLBMGFK" }, null, null, null, null)
		}));
	}
}
