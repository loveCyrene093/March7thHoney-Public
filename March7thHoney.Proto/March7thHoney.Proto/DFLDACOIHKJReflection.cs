using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DFLDACOIHKJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DFLDACOIHKJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFERkxEQUNPSUhLSi5wcm90byIiCgtERkxEQUNPSUhLShITCgtKQUZOQ09N" + "R0FCRxgBIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DFLDACOIHKJ), DFLDACOIHKJ.Parser, new string[1] { "JAFNCOMGABG" }, null, null, null, null)
		}));
	}
}
