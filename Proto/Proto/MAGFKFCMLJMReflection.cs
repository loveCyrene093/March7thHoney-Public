using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MAGFKFCMLJMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MAGFKFCMLJMReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFNQUdGS0ZDTUxKTS5wcm90bxoRQk5JQkVCSUxGTEYucHJvdG8aEURPQklP";
		buffer[1] = "T0hMR0FBLnByb3RvImgKC01BR0ZLRkNNTEpNEiEKC0hCS0pLRUVJSEtFGAUg";
		buffer[2] = "AygLMgwuQk5JQkVCSUxGTEYSIQoLRE1NTkNOR0dQSEwYBiADKAsyDC5ET0JJ";
		buffer[3] = "T09ITEdBQRITCgtGQ0xJS09BSkNGThgPIAEoDUIWqgITTWFyY2g3dGhIb25l";
		buffer[4] = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			BNIBEBILFLFReflection.Descriptor,
			DOBIOOHLGAAReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MAGFKFCMLJM), MAGFKFCMLJM.Parser, new string[3] { "HBKJKEEIHKE", "DMMNCNGGPHL", "FCLIKOAJCFN" }, null, null, null, null)
		}));
	}
}
