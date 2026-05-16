using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MKEINLFOAEAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MKEINLFOAEAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNS0VJTkxGT0FFQS5wcm90byJhCgtNS0VJTkxGT0FFQRITCgtDTUhNTkVF" + "RkNMQxgBIAEoDRITCgtCSEZPT0JQS0lBThgCIAEoDRITCgtNTExESEVBS0RK" + "QxgDIAEoDRITCgtISk1MS0ROSUlGUBgEIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MKEINLFOAEA), MKEINLFOAEA.Parser, new string[4] { "CMHMNEEFCLC", "BHFOOBPKIAN", "MLLDHEAKDJC", "HJMLKDNIIFP" }, null, null, null, null)
		}));
	}
}
