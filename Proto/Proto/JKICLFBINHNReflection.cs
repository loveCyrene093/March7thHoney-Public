using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JKICLFBINHNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JKICLFBINHNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKS0lDTEZCSU5ITi5wcm90byI3CgtKS0lDTEZCSU5IThITCgtCR0pLQlBO" + "Q05MRRgDIAEoBRITCgtGRkJDSUVGR0xOQxgHIAEoAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JKICLFBINHN), JKICLFBINHN.Parser, new string[2] { "BGJKBPNCNLE", "FFBCIEFGLNC" }, null, null, null, null)
		}));
	}
}
