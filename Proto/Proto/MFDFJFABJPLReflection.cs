using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MFDFJFABJPLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MFDFJFABJPLReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFNRkRGSkZBQkpQTC5wcm90bxoRTUxJQkxIRkJBRkoucHJvdG8aEU9CUE1Q";
		buffer[1] = "UENGTkxKLnByb3RvImgKC01GREZKRkFCSlBMEiEKC0ZQSEdIQVBHTkFFGAEg";
		buffer[2] = "ASgOMgwuTUxJQkxIRkJBRkoSEwoLRE1ITExLQk1IRUwYAyABKAQSIQoLQVBI";
		buffer[3] = "SklBRk9ESEoYBiADKAsyDC5PQlBNUFBDRk5MSkIWqgITTWFyY2g3dGhIb25l";
		buffer[4] = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			MLIBLHFBAFJReflection.Descriptor,
			OBPMPPCFNLJReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MFDFJFABJPL), MFDFJFABJPL.Parser, new string[3] { "FPHGHAPGNAE", "DMHLLKBMHEL", "APHJIAFODHJ" }, null, null, null, null)
		}));
	}
}
