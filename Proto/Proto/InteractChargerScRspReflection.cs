using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class InteractChargerScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static InteractChargerScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChpJbnRlcmFjdENoYXJnZXJTY1JzcC5wcm90bxoRQ2hhcmdlckluZm8ucHJv";
		buffer[1] = "dG8aF1JvdGF0ZXJFbmVyZ3lJbmZvLnByb3RvInQKFEludGVyYWN0Q2hhcmdl";
		buffer[2] = "clNjUnNwEiIKDGNoYXJnZXJfaW5mbxgIIAEoCzIMLkNoYXJnZXJJbmZvEicK";
		buffer[3] = "C2VuZXJneV9pbmZvGAogASgLMhIuUm90YXRlckVuZXJneUluZm8SDwoHcmV0";
		buffer[4] = "Y29kZRgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ChargerInfoReflection.Descriptor,
			RotaterEnergyInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(InteractChargerScRsp), InteractChargerScRsp.Parser, new string[3] { "ChargerInfo", "EnergyInfo", "Retcode" }, null, null, null, null)
		}));
	}
}
