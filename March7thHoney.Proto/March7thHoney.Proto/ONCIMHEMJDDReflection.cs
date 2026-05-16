using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ONCIMHEMJDDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ONCIMHEMJDDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPTkNJTUhFTUpERC5wcm90byIZCgtPTkNJTUhFTUpERBIKCgJpZBgCIAEo" + "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ONCIMHEMJDD), ONCIMHEMJDD.Parser, new string[1] { "Id" }, null, null, null, null)
		}));
	}
}
