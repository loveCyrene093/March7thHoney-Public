using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LHJCFNLPFILReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LHJCFNLPFILReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMSEpDRk5MUEZJTC5wcm90byIiCgtMSEpDRk5MUEZJTBITCgtDUEtJQU1E" + "SUpORxgBIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LHJCFNLPFIL), LHJCFNLPFIL.Parser, new string[1] { "CPKIAMDIJNG" }, null, null, null, null)
		}));
	}
}
