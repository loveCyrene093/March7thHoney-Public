using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DAGLHILOCKLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DAGLHILOCKLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFEQUdMSElMT0NLTC5wcm90byI3CgtEQUdMSElMT0NLTBITCgtIT0tKRktO" + "UEtBShgBIAEoDRITCgtORUVQQUpQREhLSxgCIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DAGLHILOCKL), DAGLHILOCKL.Parser, new string[2] { "HOKJFKNPKAJ", "NEEPAJPDHKK" }, null, null, null, null)
		}));
	}
}
