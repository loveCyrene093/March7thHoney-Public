using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetActivityScheduleConfigScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetActivityScheduleConfigScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiRHZXRBY3Rpdml0eVNjaGVkdWxlQ29uZmlnU2NSc3AucHJvdG8aGkFjdGl2";
		buffer[1] = "aXR5U2NoZWR1bGVEYXRhLnByb3RvIl8KHkdldEFjdGl2aXR5U2NoZWR1bGVD";
		buffer[2] = "b25maWdTY1JzcBIsCg1zY2hlZHVsZV9kYXRhGAcgAygLMhUuQWN0aXZpdHlT";
		buffer[3] = "Y2hlZHVsZURhdGESDwoHcmV0Y29kZRgJIAEoDUIWqgITTWFyY2g3dGhIb25l";
		buffer[4] = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ActivityScheduleDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetActivityScheduleConfigScRsp), GetActivityScheduleConfigScRsp.Parser, new string[2] { "ScheduleData", "Retcode" }, null, null, null, null)
		}));
	}
}
