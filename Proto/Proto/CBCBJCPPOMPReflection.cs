using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CBCBJCPPOMPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CBCBJCPPOMPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDQkNCSkNQUE9NUC5wcm90bxoRTEtCR09DR0RGTUwucHJvdG8iMAoLQ0JD" + "QkpDUFBPTVASIQoLQUZDTU9PRkdCUEsYZSABKAsyDC5MS0JHT0NHREZNTEIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { LKBGOCGDFMLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CBCBJCPPOMP), CBCBJCPPOMP.Parser, new string[1] { "AFCMOOFGBPK" }, null, null, null, null)
		}));
	}
}
