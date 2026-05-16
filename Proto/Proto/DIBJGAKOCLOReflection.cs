using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DIBJGAKOCLOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DIBJGAKOCLOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFESUJKR0FLT0NMTy5wcm90byI0CgtESUJKR0FLT0NMTxIQCghhZmZpeF9p" + "ZBgEIAEoDRITCgtKSlBDTE9JTUFLQhgPIAEoCEIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DIBJGAKOCLO), DIBJGAKOCLO.Parser, new string[2] { "AffixId", "JJPCLOIMAKB" }, null, null, null, null)
		}));
	}
}
