using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DODFLOBPGGLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DODFLOBPGGLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFET0RGTE9CUEdHTC5wcm90byIiCgtET0RGTE9CUEdHTBITCgtNRk5QSEhF" + "UFBJRBgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DODFLOBPGGL), DODFLOBPGGL.Parser, new string[1] { "MFNPHHEPPID" }, null, null, null, null)
		}));
	}
}
