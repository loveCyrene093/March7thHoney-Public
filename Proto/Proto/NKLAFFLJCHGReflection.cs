using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NKLAFFLJCHGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NKLAFFLJCHGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOS0xBRkZMSkNIRy5wcm90byIuCgtOS0xBRkZMSkNIRxIKCgJpZBgBIAEo" + "DRITCgtDTk9MQUlITEFBQhgCIAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NKLAFFLJCHG), NKLAFFLJCHG.Parser, new string[2] { "Id", "CNOLAIHLAAB" }, null, null, null, null)
		}));
	}
}
