using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KMOFOOGIDOPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KMOFOOGIDOPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLTU9GT09HSURPUC5wcm90bxoXR3JpZEZpZ2h0RHJvcEluZm8ucHJvdG8i" + "SwoLS01PRk9PR0lET1ASJwoLUElCTEpMQkNLSkwYCCABKAsyEi5HcmlkRmln" + "aHREcm9wSW5mbxITCgtCREJGRE5KRkFGRhgOIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { GridFightDropInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KMOFOOGIDOP), KMOFOOGIDOP.Parser, new string[2] { "PIBLJLBCKJL", "BDBFDNJFAFF" }, null, null, null, null)
		}));
	}
}
