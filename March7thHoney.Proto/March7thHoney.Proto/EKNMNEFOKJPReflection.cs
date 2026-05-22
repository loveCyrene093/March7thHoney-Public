using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EKNMNEFOKJPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EKNMNEFOKJPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFS05NTkVGT0tKUC5wcm90bxoRQUhNTUVDTU1QQkwucHJvdG8iMAoLRUtO" + "TU5FRk9LSlASIQoLQ0RESkRHSEVLTUgYBiADKAsyDC5BSE1NRUNNTVBCTEIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { AHMMECMMPBLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EKNMNEFOKJP), EKNMNEFOKJP.Parser, new string[1] { "CDDJDGHEKMH" }, null, null, null, null)
		}));
	}
}
