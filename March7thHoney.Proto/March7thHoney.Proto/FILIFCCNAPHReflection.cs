using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FILIFCCNAPHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FILIFCCNAPHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGSUxJRkNDTkFQSC5wcm90bxoRR0tERUtKS09JSk4ucHJvdG8iMAoLRklM" + "SUZDQ05BUEgSIQoLQUFDREtHS0VDQUgYAyADKAsyDC5HS0RFS0pLT0lKTkIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { GKDEKJKOIJNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FILIFCCNAPH), FILIFCCNAPH.Parser, new string[1] { "AACDKGKECAH" }, null, null, null, null)
		}));
	}
}
