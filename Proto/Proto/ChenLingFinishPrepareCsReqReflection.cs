using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChenLingFinishPrepareCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChenLingFinishPrepareCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBDaGVuTGluZ0ZpbmlzaFByZXBhcmVDc1JlcS5wcm90byIcChpDaGVuTGlu" + "Z0ZpbmlzaFByZXBhcmVDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChenLingFinishPrepareCsReq), ChenLingFinishPrepareCsReq.Parser, null, null, null, null, null)
		}));
	}
}
