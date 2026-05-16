using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EACGOHFOCJCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EACGOHFOCJCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFQUNHT0hGT0NKQy5wcm90byIiCgtFQUNHT0hGT0NKQxITCgtJTkNITEhO" + "S0hDSBgKIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EACGOHFOCJC), EACGOHFOCJC.Parser, new string[1] { "INCHLHNKHCH" }, null, null, null, null)
		}));
	}
}
