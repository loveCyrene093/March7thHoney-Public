using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IdleLiveCollectIncomeCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IdleLiveCollectIncomeCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBJZGxlTGl2ZUNvbGxlY3RJbmNvbWVDc1JlcS5wcm90byJGChpJZGxlTGl2" + "ZUNvbGxlY3RJbmNvbWVDc1JlcRITCgtJSEFPUFBNQ0pMQhgDIAEoDRITCgtG" + "SUlKQ0ZKSkxPTxgGIAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IdleLiveCollectIncomeCsReq), IdleLiveCollectIncomeCsReq.Parser, new string[2] { "IHAOPPMCJLB", "FIIJCFJJLOO" }, null, null, null, null)
		}));
	}
}
