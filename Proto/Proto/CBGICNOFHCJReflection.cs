using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CBGICNOFHCJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CBGICNOFHCJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDQkdJQ05PRkhDSi5wcm90byIiCgtDQkdJQ05PRkhDShITCgtLQkZET1BO" + "T0RCTBgJIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CBGICNOFHCJ), CBGICNOFHCJ.Parser, new string[1] { "KBFDOPNODBL" }, null, null, null, null)
		}));
	}
}
