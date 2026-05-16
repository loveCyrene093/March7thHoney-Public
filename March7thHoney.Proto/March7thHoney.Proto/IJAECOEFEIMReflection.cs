using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IJAECOEFEIMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IJAECOEFEIMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJSkFFQ09FRkVJTS5wcm90bxoRQ0RGT0dNQU1GR0YucHJvdG8aEUpBTUxI" + "T0hCSUdCLnByb3RvIlMKC0lKQUVDT0VGRUlNEiEKC0VOQkdOTEJNR0ZLGAQg" + "ASgLMgwuSkFNTEhPSEJJR0ISIQoLRUFFQUZJSElJTUsYDCABKAsyDC5DREZP" + "R01BTUZHRkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[2]
		{
			CDFOGMAMFGFReflection.Descriptor,
			JAMLHOHBIGBReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IJAECOEFEIM), IJAECOEFEIM.Parser, new string[2] { "ENBGNLBMGFK", "EAEAFIHIIMK" }, null, null, null, null)
		}));
	}
}
