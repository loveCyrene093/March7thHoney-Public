using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NALJFANPFMAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NALJFANPFMAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOQUxKRkFOUEZNQS5wcm90byI3CgtOQUxKRkFOUEZNQRITCgtNRk9LQkRD" + "SEJFQxgCIAEoDRITCgtLTUpKQ0tET0JNQRgKIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NALJFANPFMA), NALJFANPFMA.Parser, new string[2] { "MFOKBDCHBEC", "KMJJCKDOBMA" }, null, null, null, null)
		}));
	}
}
