using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ElationActivityBattleEndScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ElationActivityBattleEndScNotifyReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CiZFbGF0aW9uQWN0aXZpdHlCYXR0bGVFbmRTY05vdGlmeS5wcm90bxoeRWxh";
		buffer[1] = "dGlvbkFjdGl2aXR5TGV2ZWxEYXRhLnByb3RvIqMBCiBFbGF0aW9uQWN0aXZp";
		buffer[2] = "dHlCYXR0bGVFbmRTY05vdGlmeRITCgtHR0NQRFBGTUFFRxgBIAEoDRIUCgxw";
		buffer[3] = "ZXJmZWN0X3dhdmUYBiABKA0SLQoKbGV2ZWxfZGF0YRgKIAEoCzIZLkVsYXRp";
		buffer[4] = "b25BY3Rpdml0eUxldmVsRGF0YRITCgtISkFBREFPR0FNUBgMIAEoDRIQCghs";
		buffer[5] = "ZXZlbF9pZBgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ElationActivityLevelDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ElationActivityBattleEndScNotify), ElationActivityBattleEndScNotify.Parser, new string[5] { "GGCPDPFMAEG", "PerfectWave", "LevelData", "HJAADAOGAMP", "LevelId" }, null, null, null, null)
		}));
	}
}
