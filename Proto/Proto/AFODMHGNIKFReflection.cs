using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AFODMHGNIKFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AFODMHGNIKFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBRk9ETUhHTklLRi5wcm90byIiCgtBRk9ETUhHTklLRhITCgtIRE1ESUZQ" + "REtNSxgBIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AFODMHGNIKF), AFODMHGNIKF.Parser, new string[1] { "HDMDIFPDKMK" }, null, null, null, null)
		}));
	}
}
