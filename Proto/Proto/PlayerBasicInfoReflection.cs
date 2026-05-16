using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerBasicInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerBasicInfoReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChVQbGF5ZXJCYXNpY0luZm8ucHJvdG8ikgEKD1BsYXllckJhc2ljSW5mbxIQ";
		buffer[1] = "CghuaWNrbmFtZRgBIAEoCRINCgVsZXZlbBgCIAEoDRILCgNleHAYAyABKA0S";
		buffer[2] = "DwoHc3RhbWluYRgEIAEoDRINCgVtY29pbhgFIAEoDRINCgVoY29pbhgGIAEo";
		buffer[3] = "DRINCgVzY29pbhgHIAEoDRITCgt3b3JsZF9sZXZlbBgIIAEoDUIWqgITTWFy";
		buffer[4] = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerBasicInfo), PlayerBasicInfo.Parser, new string[8] { "Nickname", "Level", "Exp", "Stamina", "Mcoin", "Hcoin", "Scoin", "WorldLevel" }, null, null, null, null)
		}));
	}
}
