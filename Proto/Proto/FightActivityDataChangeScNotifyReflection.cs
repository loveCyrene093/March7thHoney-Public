using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FightActivityDataChangeScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FightActivityDataChangeScNotifyReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "CiVGaWdodEFjdGl2aXR5RGF0YUNoYW5nZVNjTm90aWZ5LnByb3RvGhFJRk5F";
		buffer[1] = "Q0pPT0lHRy5wcm90byLAAQofRmlnaHRBY3Rpdml0eURhdGFDaGFuZ2VTY05v";
		buffer[2] = "dGlmeRIhCgtFQ0dMR0RLRERJRBgEIAMoCzIMLklGTkVDSk9PSUdHEkYKC0lN";
		buffer[3] = "R0dQTUVPSkFKGAogAygLMjEuRmlnaHRBY3Rpdml0eURhdGFDaGFuZ2VTY05v";
		buffer[4] = "dGlmeS5JTUdHUE1FT0pBSkVudHJ5GjIKEElNR0dQTUVPSkFKRW50cnkSCwoD";
		buffer[5] = "a2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4AUIWqgITTWFyY2g3dGhIb25l";
		buffer[6] = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { IFNECJOOIGGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FightActivityDataChangeScNotify), FightActivityDataChangeScNotify.Parser, new string[2] { "ECGLGDKDDID", "IMGGPMEOJAJ" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
