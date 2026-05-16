using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KFGCNNPOADIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KFGCNNPOADIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLRkdDTk5QT0FESS5wcm90byI3CgtLRkdDTk5QT0FESRITCgtNQUZNQ0lQ" + "QUlLSxgEIAEoDRITCgtPTEtNSUxOR1BOThgKIAEoCEIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KFGCNNPOADI), KFGCNNPOADI.Parser, new string[2] { "MAFMCIPAIKK", "OLKMILNGPNN" }, null, null, null, null)
		}));
	}
}
