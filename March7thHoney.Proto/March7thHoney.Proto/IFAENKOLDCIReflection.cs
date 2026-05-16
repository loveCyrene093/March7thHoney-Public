using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IFAENKOLDCIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IFAENKOLDCIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJRkFFTktPTERDSS5wcm90bypkCgtJRkFFTktPTERDSRIbChdJRkFFTktP" + "TERDSV9BTU1LSElFTk5PShAAEhsKF0lGQUVOS09MRENJX09DS0VNSE1GRkJG" + "EAESGwoXSUZBRU5LT0xEQ0lfTk5BQk1QTU1HTUMQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(IFAENKOLDCI) }, null, null));
	}
}
