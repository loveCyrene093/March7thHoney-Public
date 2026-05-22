using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LMCBEJOFCGIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LMCBEJOFCGIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMTUNCRUpPRkNHSS5wcm90bxoRTUxJQkxIRkJBRkoucHJvdG8iRQoLTE1D" + "QkVKT0ZDR0kSEwoLRE1ITExLQk1IRUwYDCABKAQSIQoLRlBIR0hBUEdOQUUY" + "DiABKA4yDC5NTElCTEhGQkFGSkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { MLIBLHFBAFJReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LMCBEJOFCGI), LMCBEJOFCGI.Parser, new string[2] { "DMHLLKBMHEL", "FPHGHAPGNAE" }, null, null, null, null)
		}));
	}
}
