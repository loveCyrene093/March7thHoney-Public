using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IOGMLLBFDPGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IOGMLLBFDPGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJT0dNTExCRkRQRy5wcm90byINCgtJT0dNTExCRkRQR0IWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IOGMLLBFDPG), IOGMLLBFDPG.Parser, null, null, null, null, null)
		}));
	}
}
