using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChenLingRefreshPolicyCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChenLingRefreshPolicyCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBDaGVuTGluZ1JlZnJlc2hQb2xpY3lDc1JlcS5wcm90byIcChpDaGVuTGlu" + "Z1JlZnJlc2hQb2xpY3lDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChenLingRefreshPolicyCsReq), ChenLingRefreshPolicyCsReq.Parser, null, null, null, null, null)
		}));
	}
}
