using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HHIAOANDGALReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HHIAOANDGALReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFISElBT0FOREdBTC5wcm90bxoYVHJhaW5WaXNpdG9yU3RhdHVzLnByb3Rv";
		buffer[1] = "IoUBCgtISElBT0FOREdBTBISCgp2aXNpdG9yX2lkGAggASgNEhMKC0FKTElJ";
		buffer[2] = "TU5EUEdMGAogAygNEiMKBnN0YXR1cxgLIAEoDjITLlRyYWluVmlzaXRvclN0";
		buffer[3] = "YXR1cxITCgtMQU1JT0tGSk1FRhgOIAEoDRITCgtPTERNS05BSURFTBgPIAEo";
		buffer[4] = "CEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { TrainVisitorStatusReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HHIAOANDGAL), HHIAOANDGAL.Parser, new string[5] { "VisitorId", "AJLIIMNDPGL", "Status", "LAMIOKFJMEF", "OLDMKNAIDEL" }, null, null, null, null)
		}));
	}
}
