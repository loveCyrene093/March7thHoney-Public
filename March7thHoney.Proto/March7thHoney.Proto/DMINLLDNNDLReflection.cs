using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DMINLLDNNDLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DMINLLDNNDLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFETUlOTExETk5ETC5wcm90byIuCgtETUlOTExETk5ETBIKCgJpZBgHIAEo" + "DRITCgtBQk1LS09LREFGSxgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DMINLLDNNDL), DMINLLDNNDL.Parser, new string[2] { "Id", "ABMKKOKDAFK" }, null, null, null, null)
		}));
	}
}
