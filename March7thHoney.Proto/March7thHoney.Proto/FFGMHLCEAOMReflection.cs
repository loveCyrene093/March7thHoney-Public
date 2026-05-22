using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FFGMHLCEAOMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FFGMHLCEAOMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGRkdNSExDRUFPTS5wcm90byIiCgtGRkdNSExDRUFPTRITCgtIR0ZCQklC" + "QkNORRgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FFGMHLCEAOM), FFGMHLCEAOM.Parser, new string[1] { "HGFBBIBBCNE" }, null, null, null, null)
		}));
	}
}
