using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PNHDKMOKCFHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PNHDKMOKCFHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQTkhES01PS0NGSC5wcm90byIiCgtQTkhES01PS0NGSBITCgtKQUZOQ09N" + "R0FCRxgBIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PNHDKMOKCFH), PNHDKMOKCFH.Parser, new string[1] { "JAFNCOMGABG" }, null, null, null, null)
		}));
	}
}
