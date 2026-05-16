using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BCMLDKKIIKAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BCMLDKKIIKAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCQ01MREtLSUlLQS5wcm90byIiCgtCQ01MREtLSUlLQRITCgtDR0tEQ0FP" + "R0NLQhgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BCMLDKKIIKA), BCMLDKKIIKA.Parser, new string[1] { "CGKDCAOGCKB" }, null, null, null, null)
		}));
	}
}
