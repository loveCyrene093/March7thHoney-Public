using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NEJJDLOCGCLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NEJJDLOCGCLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFORUpKRExPQ0dDTC5wcm90bxoRSUZNR0ZQSUNHR0gucHJvdG8iRQoLTkVK" + "SkRMT0NHQ0wSIQoLTENFSERHQkJESkwYByADKAsyDC5JRk1HRlBJQ0dHSBIT" + "CgtGT09MTUlBRE1NSBgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { IFMGFPICGGHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NEJJDLOCGCL), NEJJDLOCGCL.Parser, new string[2] { "LCEHDGBBDJL", "FOOLMIADMMH" }, null, null, null, null)
		}));
	}
}
